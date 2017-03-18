function substringInText(args) {
    const needle = args[0].toLowerCase(),
        text = args[1].toLowerCase(),
        needleLen = needle.length;

    let occurs = 0,
        startIndex = -1;

    while((startIndex = text.indexOf(needle, startIndex + 1)) !== -1) {
        occurs++;
    }

    return occurs;
}

console.log(substringInText([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]));