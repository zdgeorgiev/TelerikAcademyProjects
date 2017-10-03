function solve() {

    const VALIDATOR = (function () {
        return {
            nonEmptyString(string) {
                if (string.length === 0) {
                    throw new Error('String cannot be empty');
                }
            },
            stringBetween(low, high, string) {

                if (typeof string !== 'string') {
                    throw new Error('Invalid string');
                }

                let stringLen = string.length;

                if (stringLen < low || stringLen > high) {
                    throw new Error(`String length must be in range [${low}-${high}]`);
                }
            },
            validISBN(isbn) {
                let stringLen = isbn.length;

                if (stringLen !== 10 && stringLen !== 13) {
                    throw new Error(`ISBN length must be 10 or 13 numbers`);
                }

                switch (+stringLen) {
                    case 10:
                        if (/[0-9]{10}/.test(isbn)) {
                            return;
                        }
                    case 13:
                        if (/[0-9]{13}/.test(isbn)) {
                            return;
                        }
                }

                throw new Error('ISBN must contains only digits');
            },
            numberBetween(low, high, n) {
                this.isNumber(n);

                if (n < low || n > high) {
                    throw new Error(`Number ${n} must be in range [${low}-${high}]`);
                }
            },
            isNumber(n) {
                if (typeof n !== 'number') {
                    throw new Error('N is not a number');
                }
            },
            validateItems(items) {

                if (items.length === 0) {
                    throw new Error('No items are added');
                }

                items.forEach(i => {
                    if (!(i instanceof Item)) {
                        throw new Error('Invalid item');
                    }
                });
            },
            validateBooks(books) {

                books.forEach(b => {
                    if (!(b instanceof Book)) {
                        throw new Error('Invalid book');
                    }
                });
            },
            validateMedias(medias) {

                medias.forEach(m => {
                    if (!(m instanceof Media)) {
                        throw new Error('Invalid media');
                    }
                });
            },
            filterByOptional(arr, propObject, prop) {
                if (arr === null) {
                    return null;
                }

                if (arr.length === 0) {
                    return [];
                }

                if (!propObject.hasOwnProperty(prop)) {
                    return arr;
                }

                let filtered = arr.filter(x => x[prop] === propObject[prop]);
                return filtered.length === 0 ? null : filtered;
            }
        };
    })();

    const getNextId = (function (clazz) {
        let itemId = -1,
            catalogId = -1;

        return function (clazz) {
            switch (clazz) {
                case "Item": itemId++; return itemId;
                case "Catalog": catalogId++; return catalogId;
                default: throw new Error(`Invalid class name ${clazz}`);
            }
        }
    })();

    class Item {
        constructor(description, name) {
            this._id = getNextId(`Item`);
            this.description = description;
            this.name = name;
        }

        get id() {
            return this._id;
        }

        get description() {
            return this._description;
        }

        set description(description) {
            VALIDATOR.nonEmptyString(description);
            this._description = description;
        }

        get name() {
            return this._name;
        }

        set name(name) {
            VALIDATOR.stringBetween(2, 40, name);
            this._name = name;
        }
    }

    class Book extends Item {
        constructor(description, name, isbn, genre) {
            super(description, name);
            this.isbn = isbn;
            this.genre = genre;
        }

        get isbn() {
            return this._isbn;
        }

        set isbn(isbn) {
            VALIDATOR.validISBN(isbn);
            this._isbn = isbn;
        }

        get genre() {
            return this._genre;
        }

        set genre(genre) {
            VALIDATOR.stringBetween(2, 20, genre);
            this._genre = genre;
        }
    }

    class Media extends Item {
        constructor(description, name, duration, rating) {
            super(description, name);
            this.duration = duration;
            this.rating = rating;
        }

        get duration() {
            return this._duration;
        }

        set duration(duration) {
            VALIDATOR.numberBetween(1, Number.MAX_SAFE_INTEGER, duration);
            this._duration = duration;
        }

        get rating() {
            return this._rating;
        }

        set rating(rating) {
            VALIDATOR.numberBetween(1, 5, rating);
            this._rating = rating;
        }
    }

    class Catalog {
        constructor(name) {
            this._id = getNextId('Catalog');
            this.name = name;
            this._items = [];
        }

        get id() {
            return this._id;
        }

        get name() {
            return this._name;
        }

        set name(name) {
            VALIDATOR.stringBetween(2, 40, name);
            this._name = name;
        }

        get items() {
            return this._items;
        }

        add(...items) {

            if (Array.isArray(items[0])) {
                items = items[0];
            }

            VALIDATOR.validateItems(items);
            this.items.push(...items);
            return this;
        }

        find(x) {
            if (typeof x === 'number') {
                for (let item of this.items) {
                    if (item.id === x) {
                        return item;
                    }
                }

                return null;
            }

            if (x !== null && typeof x === 'object') {
                return this.items.filter(item => {
                    return Object.keys(x).every(function (prop) {
                        return x[prop] === item[prop];
                    });
                });
            }

            throw 'Invalid options or id';
        }

        search(pattern) {
            VALIDATOR.nonEmptyString(pattern);
            return this.items.filter(item => item.name.indexOf(pattern) >= 0 || item.description.indexOf(pattern) >= 0);
        }
    }

    class BookCatalog extends Catalog {
        constructor(name) {
            super(name);
        }

        add(...books) {

            if (Array.isArray(books[0])) {
                books = books[0];
            }

            VALIDATOR.validateBooks(books);
            super.add(...books);
            return this;
        }

        getGenres() {
            return Array.from(new Set(this.items.map(x => x.genre.toLowerCase())));
        }

        find(options) {
            let filtered = super.find(options);
            return VALIDATOR.filterByOptional(filtered, options, 'genre');
        }
    }

    class MediaCatalog extends Catalog {
        constructor(name) {
            super(name);
        }

        add(...medias) {

            if (Array.isArray(medias[0])) {
                medias = medias[0];
            }

            VALIDATOR.validateMedias(medias);
            super.add(...medias);
            return this;
        }

        getTop(count) {
            VALIDATOR.numberBetween(1, Number.MAX_SAFE_INTEGER, count);

            return this.items
                .sort((a, b) => { a.rating > b.rating; })
                .map(m => ({ id: m.id, name: m.name }))
                .slice(0, count);
        }

        getSortedByDuration() {
            return this.items
                .sort((a, b) => {
                    if (a.duration === b.duration) {
                        return a.id < b.id;
                    }

                    return a.duration > b.duration;
                });
        }

        find(options) {
            let filtered = super.find(options);
            return VALIDATOR.filterByOptional(filtered, options, 'rating');
        }
    }

    return {
        getBook: function (name, isbn, genre, description) {
            return new Book(description, name, isbn, genre);
        },
        getMedia: function (name, rating, duration, description) {
            return new Media(description, name, duration, rating);
        },
        getBookCatalog: function (name) {
            return new BookCatalog(name);
        },
        getMediaCatalog: function (name) {
            return new MediaCatalog(name);
        }
    };
}

module.exports = solve;