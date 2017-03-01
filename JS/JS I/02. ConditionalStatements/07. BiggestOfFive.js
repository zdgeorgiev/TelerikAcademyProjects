function sovle(args) {

    let maxInt = Number.MIN_SAFE_INTEGER;

    for (let i = 0; i < 5; i += 1) {
        if(maxInt < +args[i])
            maxInt = args[i];
    }

    return maxInt;
}