Array.prototype.remove = function() {
    const toRemove = this.shift();
    let newArr = [];

    for(const i of this)
        if(i !== toRemove)
            newArr.push(i);

    this.splice(this);

    for(const i of newArr)
        this.push(i);
}

function solve(arr) {
    arr.remove();
    arr.forEach(x => console.log(x));
}

solve([ '1', '2', '3', '2', '1', '2', '3', '2' ]);