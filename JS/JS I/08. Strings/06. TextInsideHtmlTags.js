function getText(args) {
    let insideText = ''
    text = [...args].join(''),
        inTag = false;

    reg = new RegExp(/(\<\/?\w+\>)+([^\<]+)?/g);
    var result;
    while ((result = reg.exec(text)) !== null) {
        if (result[2] === undefined || result[2].trim() === '')
            continue;
        insideText = insideText.concat(result[2].trim());
    }

    return insideText;
}

console.log(getText([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]));