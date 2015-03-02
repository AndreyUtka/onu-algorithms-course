'use strict';

/**
 * Insertion Sort with O(n^2) complexity
 * Loop invariant is array[1..i-1]
 * @param {Array} input array
 * @param {Function} comparator
 * @returns {Array} bubble sorted array
 */
var insertionSort = function (array, comparator) {
    for (var i = 1; i < array.length; i++) {

        var currentElement = array[i];
        var previousKey = i - 1;

        while (previousKey >= 0 && comparator(array[previousKey], currentElement)) {
            array[previousKey + 1] = array[previousKey];
            previousKey--;
        }
        array[previousKey + 1] = currentElement;
    }
    return array;
};

module.exports = insertionSort;