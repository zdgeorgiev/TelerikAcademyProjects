function solve(args) {

    let n = +args[0],
        output = '';

    if(n >= 100) {

        switch(parseInt(n / 100)) {
            case 1: output += 'One'; break;
            case 2: output += 'Two'; break;
            case 3: output += 'Three'; break;
            case 4: output += 'Four'; break;
            case 5: output += 'Five'; break;
            case 6: output += 'Six'; break;
            case 7: output += 'Seven'; break;
            case 8: output += 'Eight'; break;
            case 9: output += 'Nine'; break;
        }

        output += ' hundred';
        n %= 100;
    }

    if(n >= 20) {

        if(output !== '') {
            output += ' and ';
        }

        switch(parseInt(n / 10)) {
            case 2: output += 'twenty'; break;
            case 3: output += 'thirty'; break;
            case 4: output += 'forty'; break;
            case 5: output += 'fifty'; break;
            case 6: output += 'sixty'; break;
            case 7: output += 'seventy'; break;
            case 8: output += 'eighty'; break;
            case 9: output += 'ninety'; break;
        }

        n %= 10;
    }

    if(n == 0 && !output)
        console.log('Zero');

    if(n > 0) {

        if(output !== '') {
            if(output.indexOf('ty') === -1)
                output += ' and';

            output += ' ';
        }

        switch(n) {
            case 1: output += 'one'; break;
            case 2: output += 'two'; break;
            case 3: output += 'three'; break;
            case 4: output += 'four'; break;
            case 5: output += 'five'; break;
            case 6: output += 'six'; break;
            case 7: output += 'seven'; break;
            case 8: output += 'eight'; break;
            case 9: output += 'nine'; break;
            case 10: output += 'ten'; break;
            case 11: output += 'eleven'; break;
            case 12: output += 'twelve'; break;
            case 13: output += 'thirteen'; break;
            case 14: output += 'fourteen'; break;
            case 15: output += 'fifteen'; break;
            case 16: output += 'sixteen'; break;
            case 17: output += 'seventeen'; break;
            case 18: output += 'eighteen'; break;
            case 19: output += 'nineteen'; break;
        }
    }

    output = output.charAt(0).toUpperCase() + output.slice(1);
    console.log(output);
}