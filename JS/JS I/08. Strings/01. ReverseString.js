function reverse(args) {
    return [...args[0].split('')].reduceRight((x, y) => x + y, '');
}

console.log(reverse(['sample']));