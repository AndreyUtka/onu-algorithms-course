var mergeSort = (function () {

    /**
     * Merge Sort with O(n log n) complexity
     * @param {Array} array The array to sort
     * @param {Function} comparator
     */
    function sort(array, comparator) {

        if (array.length <= 1) {
            return array;
        }

        var midpoint = Math.floor(array.length / 2),
            left = array.slice(0, midpoint),
            right = array.slice(midpoint, array.length);

        left = sort(left, comparator);
        right = sort(right, comparator);

        return merge(left, right, comparator);
    }

    /**
     * @param {Array} left The left hand sublist
     * @param {Array} right The right hand sublist
     * @param {Function} comparator
     */
    function merge(left, right, comparator) {

        var result = [];

        while (left.length && right.length) {
            if (comparator(left[0], right[0]) <= 0) {
                result.push(left.shift());
            } else {
                result.push(right.shift());
            }
        }

        while (left.length)
            result.push(left.shift());

        while (right.length)
            result.push(right.shift());

        return result.concat(left, right);
    }

    return {
        sort: sort
    };

})();

module.exports = mergeSort.sort;