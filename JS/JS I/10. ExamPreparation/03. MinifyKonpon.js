function minify(text) {

    let transformed = text.join(''),
        totalLen = 0,
        variablesCount = 0,
        variables = [];

    transformed = transformed.replace(/\s+/gm, '');
    transformed = transformed.replace(/;+/gm, ';');

    for (let i = 0; i < 50; i++) {
        transformed = transformed.replace(/\{;*\}/g, '');
        transformed = transformed.replace(/;+/gm, ';');
    }

    transformed = transformed.replace(/([{}]);([0-9aA-zZ_]*)/g, '$1' + '$2');
    transformed = transformed.replace(/([0-9aA-zZ_]*);([\{\}])/g, '$1' + '$2');

    transformed = transformed.replace(/^;/g, '');
    transformed = transformed.replace(/;$/g, '');

    matches = transformed.match(/[0-9aA-zZ_]+/g);

    if (matches === null)
        return 0;

    for (const v of matches) {
        if (!variables.hasOwnProperty(v))
            variables[v] = 1;
        else
            variables[v]++;
    }

    // Remove the variables
    transformed = transformed.replace(/[0-9aA-zZ_]+/g, '');

    // all symbols allowed are [aA-zZ] + [0-9] + _ => 52 + 10 + 1 = 63 CHARS
    // 63^1 = 63 ( all variables with 1 letter )
    // 63^2 = 3969 ( all variables with 2 letters )
    // Total : 4032 variables
    totalLen += transformed.length;

    let charsUsed = 1;

    for (const l in variables) {
        if (charsUsed > 63) {
            totalLen += 2 * +variables[l];
        }
        else {
            totalLen += +variables[l];
        }

        charsUsed++;
    }

    return totalLen;
}

console.log(minify(['{;;;;;;;;;;{;;;;;;;a;;;{;;;;;;;;;;;;;};;;;;;;;;;;;};;;;;;;;;;}']));

console.log(minify([
    '; ;;;jGefn4E5Pvq    ;;  ;  ; ;',
    'tQRZ5MMj26Ov { {    {;    ;;    5OVyKBFu7o1T2 ;szDVN2dWhex1V;1gDdNdANG2',
    ';    ;    ;  ;; jGefn4E5Pvq   ;;    ;p0OWoVFZ8c;;}    ;  ; ;',
    '5OVyKBFu7o1T2   ;  szDVN2dWhex1V ;    ;tQRZ5MMj26Ov    ;  ;   };',
    '1gDdNdANG2    ;   p0OWoVFZ8c ;  jGefn4E5Pvq ;; {;Z9n;;',
    ';1gDdNdANG2;   ;;    ;   ;jGefn4E5Pvq    ;; ;;p0OWoVFZ8c;;    ;;',
    ';',
    'tQRZ5MMj26Ov  ;',
    '{    ;szDVN2dWhex1V;   ;',
    ';   jGefn4E5Pvq   ;  ;  } }}'
]));

console.log(minify([
    '1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14;',
    '15; 16; 17; 18; 19; 20; 21; 22; 23; 24; 25; 26; 27; 28;',
    '29; 30; 31; 32; 33; 34; 35; 36; 37; 38; 39; 40; 41; 42;',
    '43; 44; 45; 46; 47; 48; 49; 50; 51; 52; 53; 54; 55; 56;',
    '57; 58; 59; 60; 61; 62; 63; 64; 65; 66; 67; 68; 69; 70;'
]));

console.log(minify([
	'hello;',
	'{this; is',
	' ; an;;;example;',
	'}',
	'of;',
	'{',
	'KONPOT;',
	'{',
	'Some_numbers;',
	'42;5;3}',
	'_}'
]));