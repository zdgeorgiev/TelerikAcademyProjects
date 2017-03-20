/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is Number	
*/
"use strict";

function solve() {

    if (typeof arguments === 'undefined' || typeof arguments[0] !== 'object')
        throw Error("First argument must be an array");

    const arr = arguments[0];

    if (arr.length === 0)
        return null;

    return (function sum() {
        return arr
            .filter(x => {
                if (typeof x !== 'number') {
                    throw Error(`All parameters must be numbers: ${x}`);
                }
                return x;
            })
            .reduce((x, y) => x + y);
    })();
}

module.exports = solve;