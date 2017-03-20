/* Task Description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/
"use strict";

function solve(start, end) {

    if (typeof start === 'undefined' || Number(start).toString() === `NaN` ||
        typeof end === 'undefined' || Number(end).toString() === `NaN`) {
        throw Error('Start and end parameters must be convertable to numbers');
    }

    return (function findPrimes() {
        let primes = [],
            isPrime = true;

        for (let i = start; i <= end; i++) {

            isPrime = true

            // Slow O(N^2)
            for (let j = 2; j < i; j++) {
                if (i % j === 0) {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && i !== 1)
                primes.push(i);
        }

        return primes;
    })();
}

module.exports = solve;

console.log(solve(1, 10));