function encodeSpaces(args) {
    let text = args[0],
        startIndex = -1;

    while ((startIndex = text.indexOf(' ', startIndex + 1)) !== -1) {
        text = text.replace(' ', '&nbsp;');
    }
    return text;
}

console.log(encodeSpaces([ 'This text contains 4 spaces!!' ]));