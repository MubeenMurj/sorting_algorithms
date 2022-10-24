fun bubbleSort(arr: Array<Int>): Array<Int> {
  var i = 0
  var noSwaps = false
  while (i < arr.size && !noSwaps) {
    var j = 0
    noSwaps = true
    while (j < arr.size - 1) {
      if (arr[j] > arr[j + 1]) {
        var temp = arr[j + 1]
        arr[j + 1] = arr[j]
        arr[j] = temp
        noSwaps = false
      }
      j++
    }
    i++
  }
  return arr
}