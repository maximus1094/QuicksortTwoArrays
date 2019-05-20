# QuicksortTwoArrays
Modified quicksort algorithm to sort 2 arrays of integers in-place without combining them into 1 array.
Can be used when arrays are too large to combine, also can be expanded to work on n number of arrays.

### Description.
Modified quicksort algorithm that takes two arrays as input and
treats them as one. It sorts the arrays inplace without combining them in memory.

### Efficiency notes.
The algorithm can be made more efficient by using the randomized version
of Quicksort.

### Example.
Input `[4, 6, 1] [2, 3, 9]`<br />
Output `[1, 2, 3] [4, 6, 9]`

### Testing.
To test this algorithm, call SortArrays function with 2 arrays as input.
