function solve(arr) {

    let maxSequence = 1,
        currentSequence = 1;

    for(let i = 1; i < arr.length; i++) {
        if(arr[i - 1] === arr[i])
            currentSequence++;
        else {
            maxSequence < currentSequence ?
                maxSequence = currentSequence :
                maxSequence = maxSequence;
            currentSequence = 1;
        }
    }

    maxSequence < currentSequence ?
        maxSequence = currentSequence :
        maxSequence = maxSequence;

    console.log(maxSequence);
}