var mergeSort = require('../src/merge.sort');
var expect = require('chai').expect;

describe('Merge Sort', function () {
    it('should be sorted array by ascending', function () {
        var notSortedArray = [5, 10, 9, 0, 6, 17, 3];
        var sortedArray = [0, 3, 5, 6, 9, 10, 17];
        var comparator = function (x, y) {
            return x - y;
        };

        var resultArray = mergeSort(notSortedArray, comparator);

        expect(resultArray).to.deep.equal(sortedArray);
    });

    it('should be sorted array by descending', function () {
        var notSortedArray = [5, 10, 9, 0, 6, 17, 3];
        var sortedArray = [17, 10, 9, 6, 5, 3, 0];
        var comparator = function (x, y) {
            return y - x;
        };

        var resultArray = mergeSort(notSortedArray, comparator);

        expect(resultArray).to.deep.equal(sortedArray);
    });
});