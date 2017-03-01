function solve(args) {

    const text1 = args[0];
        text2 = args[1];

    for(let i in text1) {
        if(text1[i] > text2[i])
            return '>';
        else if(text1[i] < text2[i])
            return '<';
    }

    if(text1.length === text2.length)
        return '=';
    else 
        return text1.length > text2.length ? '>' : '<';
}