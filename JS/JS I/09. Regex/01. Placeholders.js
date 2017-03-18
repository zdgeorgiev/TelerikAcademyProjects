String.prototype.format = function (format) {

    const holders = JSON.parse(format),
        regex = new RegExp('(#{(\\w+)})', 'g');

    let transformed = this,
        currentMatch = '';

    while ((currentMatch = regex.exec(this)) !== null) {
        transformed = transformed.replace(currentMatch[1], holders[currentMatch[2]]);
    }

    return transformed;
}

console.log("My name is #{name} and I am #{age}-years-old".format('{ "name": "John", "age": 13 }'));