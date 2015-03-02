var insertionSort = require('../src/insertion.sort');
var expect = require('chai').expect;

describe('Insertion Sort', function () {
    it('should be sorted array by descending', function () {
        var notSortedArray = [5, 10, 9, 0, 6, 17];
        var sortedArray = [0, 5, 6, 9, 10, 17];

        var resultArray = insertionSort(notSortedArray, function (x, y) {
            return x > y;
        });

        expect(resultArray).to.deep.equal(sortedArray);
    });

    it('should be sorted array by ascending', function () {
        var notSortedArray = [5, 10, 9, 0, 6, 17];
        var sortedArray = [17, 10, 9, 6, 5, 0];

        var resultArray = insertionSort(notSortedArray, function (x, y) {
            return x < y;
        });

        expect(resultArray).to.deep.equal(sortedArray);
    });
});