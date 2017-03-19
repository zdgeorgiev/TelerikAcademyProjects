/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category title must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
    var library = (function () {
        var books = [];
        var categories = [];
        var categoriesCount = 1;

        function listBooks(searchObject) {

            let author,
                category;

            if (typeof searchObject !== 'undefined') {
                if (searchObject.hasOwnProperty('author'))
                    author = searchObject.author;
                if (searchObject.hasOwnProperty('category'))
                    category = searchObject.category;
            }

            return books
                .filter(b => typeof author === 'undefined' || b.author === author)
                .filter(b => typeof category === 'undefined' || b.category === category)
        }

        function addBook(book) {

            validateBook(book);

            book.ID = books.length + 1;
            books.push(book);

            if (categories.hasOwnProperty(book.category))
                categories[book.category].books.push(book.title);
            else
                categories[book.category] = {
                    ID: categoriesCount++,
                    books: [book.title],
                };

            return book;
        }

        function validateBook(book) {
            // Properties even exist
            if (!book.hasOwnProperty('title'))
                throw Error("Book title is mandatory property.");
            if (!book.hasOwnProperty('category'))
                throw Error("Book title is mandatory property.");
            if (!book.hasOwnProperty('author'))
                throw Error("Book category is mandatory property.");
            if (!book.hasOwnProperty('ISBN'))
                throw Error("Book ISBN is mandatory property.");

            // Properties validation
            if (typeof book.author !== 'string' || book.author.length < 1)
                throw Error("Authod must be a non empty string.");

            if (typeof book.title !== 'string' || !/^(.*){2,100}/g.test(book.title))
                throw Error("Book title must be between 2 and 100 symbols");

            books.forEach(x => {
                if (x.title === book.title)
                    throw Error(`Book with title ${book.title} already exist.`);
            });

            if (typeof book.category !== 'string' || !/^(.*){2,100}/g.test(book.category))
                throw Error("Book category must be between 2 and 100 symbols");

            if (typeof book.ISBN !== 'number' || !/^([0-9]){10,13}/g.test(book.ISBN))
                throw Error("Book ISBN must be between 10 and 13 digits");

            books.forEach(x => {
                if (x.ISBN === book.ISBN)
                    throw Error(`Book with ISBN ${book.ISBN} already exist`);
            })
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

module.exports = solve;

const bookStore = solve();

bookStore.books.add({ title: "Harry Potter", author: "Me", category: "Action/Fantasy", ISBN: 1234567890 });
bookStore.books.add({ title: "Shit movie", author: "You", category: "Drama/Comedy", ISBN: 1234567891 });
bookStore.books.add({ title: "Harry Potter 2", author: "We", category: "Action/Fantasy", ISBN: 1234567892 });

// Add invalid book
bookStore.books.add({ title: "Harry Potter 3", author: "We", category: "Action/Fantasy", ISBN: 1234567892 });

console.log('====== All Categories ======')
console.log(bookStore.categories.list());

console.log('====== All Books ======')
console.log(bookStore.books.list());

console.log('====== Books with author "We" ======')
console.log(bookStore.books.list({ author: "We" }));

console.log('====== Books with category "Drama/Comedy" ======')
console.log(bookStore.books.list({ category: "Drama/Comedy" }));