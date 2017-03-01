function solve(arr) {

    const n = arr.shift(),
        target = arr.pop();

    let low = 0,
        heigh = arr.length - 1,
        middle;

    while(low <= heigh) {

        middle = Math.floor((low + heigh) / 2);

        if(arr[middle] === target) {
            while(middle > 0 && arr[middle - 1] === target) { middle--; }
            return middle;
        }
        else if(arr[middle] > target)
            heigh = middle - 1;
        else if(arr[middle] < target)
            low = middle + 1;
    }

    return -1;
}