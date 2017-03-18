function apply(args) {

    const text = args[0],
        normalize = function (text) {
            let transformed = text;
            for (const f in functions) {
                transformed = transformed
                    .replace(new RegExp(`${f}`, 'g'), '')
                    .replace(new RegExp(`${functions[f].closed}`, 'g'), '');
            }
            return transformed;
        },
        functions = {
            "<orgcase>": {
                closed: '</orgcase>',
                apply: function (text) {
                    return normalize(text);
                }
            },
            "<lowcase>": {
                closed: '</lowcase>',
                apply: function (text) {
                    return normalize(text).toLowerCase();
                }
            },
            "<upcase>": {
                closed: '</upcase>',
                apply: function (text) {
                    return normalize(text).toUpperCase();
                }
            }
        };

    let transformed = text;

    for (let i = 0; i < text.length; i++) {

        let startIndexOpen = i,
            startIndexClosed = i,
            additionalOpenTags = 0,
            currentIteration;

        for (const f in functions) {
            if (transformed.substr(i, f.length) === f) {

                startIndexClosed = transformed.indexOf(functions[f].closed, i + 1);

                while ((startIndexOpen = transformed.indexOf(f, startIndexOpen + 1)) !== -1
                    && startIndexOpen < startIndexClosed) {
                    additionalOpenTags++;
                }
                while (additionalOpenTags-- != 0) {
                    startIndexClosed = transformed.indexOf(functions[f].closed, startIndexClosed + 1);
                }

                // Splice to the beggining of the tag
                currentIteration = transformed.slice(0, i);

                // Append the tag content with applied function
                currentIteration = currentIteration.concat(
                    functions[f].apply(
                        transformed.substring(i + f.length, startIndexClosed)));

                // Append the remaining part after the closed tag
                currentIteration = currentIteration.concat(
                    transformed.slice(startIndexClosed + functions[f].closed.length));

                transformed = currentIteration;
                break;
            }
        }
    }

    return transformed;
}

console.log(apply(['<orgcase>We are <upcase>not <orgcase><upcase>fools</upcase></orgcase> Mate ;)</upcase>.</orgcase>']))
console.log(apply(['We are <upcase>not <orgcase><upcase>fools</upcase></orgcase> mate ;)</upcase>.']))
console.log(apply(['We are <lowcase>not <upcase>fools</upcase> mate ;)</lowcase>.']))
console.log(apply(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']));