'use strict';

class LinkedList {
    constructor() {
        this._head = null;
        this._tail = null;
        this._size = 0;
    }

    append(...numbers) {
        for (const number of numbers) {
            const nextNode = new ListNode(number);

            if (this._size++ === 0) {
                this._head = nextNode;
                this._tail = nextNode;
            }

            this._tail._next = nextNode;
            this._tail = nextNode;
        }

        return this;
    }

    prepend(...numbers) {
        const list = new LinkedList();
        list.append(...numbers);
        list._tail.next = this._head; // connect left and right lists
        this._head = list._head; // reset the head to the left list head
        this._size += list._size;
    }

    insert(index, ...numbers) {
        if (index > this._size || index < 0) {
            throw new Error('Invalid index');
        }

        // Add in the beggining
        if (index === 0) {
            return this.prepend(...numbers);
        }

        // Add in the end
        if (index === this._size) {
            return this.insert(...numbers);
        }

        // Add in the middle
        let headCpy = this._head;
        for (let i = 0; i < index; i++) {
            headCpy = headCpy._next;
        }

        const list = new LinkedList();
        list.append(...numbers);

        list._tail = headCpy._next;
        headCpy._next = list._head;

        return this;
    }

    at(index, value) {
        if (index > this._size || index < 0) {
            throw new Error('Invalid index');
        }

        let headCpy = this._head;
        for (let i = 0; i < index; i++) {
            headCpy = headCpy._next;
        }

        if (value === undefined) {
            return headCpy.value;
        }

        headCpy.value = value;
    }

    removeAt(index) {
        if (index > this._size || index < 0) {
            throw new Error('Invalid index');
        }

        let curr = this._head,
            prev = null,
            next = curr.next;

        for (let i = 0; i < index; i++) {
            prev = curr;
            curr = curr.next;
            next = curr.next;
        }
        
        const value = curr.value;
        curr.next = null;

        if(prev !== null) {
            prev.next = next;
        } else {
            this._head = next;
        }

        if(next === null) {
            this._tail = prev;
        }

        this._size--;
        return value;
    }

    [Symbol.iterator]() {
        let current = this._head;

        return {
            next: function () {
                if (current === null) {
                    return { value: undefined, done: true };
                }

                let headValue = current.value;
                current = current.next;

                return { value: headValue, done: false };
            }
        }
    }

    toArray() {
        const elements = [];
        for (const node of this) {
            elements.push(node);
        }
        return elements;
    }

    toString() {
        return this.toArray().join(' -> ').toString();
    }
}

class ListNode {
    constructor(value, nextNode = null) {
        this._value = value;
        this._next = nextNode;
    }

    get value() {
        return this._value;
    }

    set value(newValue) {
        this._next = newValue;
    }

    get next() {
        return this._next;
    }

    set next(nextNode) {
        this._next = nextNode;
    }

    print() {
        console.log(`${this._value}`);
    }
}

// const list = new LinkedList();
// list.append(1, 2, 3, 4).append(5);
// list.prepend(-1, 0);

// console.log(list.toString());

const list = new LinkedList();
list.append(1, 2, 3, 4, 5, 6);
list.removeAt(1);
console.log(list.toString()); // [1, 2, 3, 4, 5, 6]