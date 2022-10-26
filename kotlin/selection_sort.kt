fun SelectionSort(arr: Array<Int>): Array<Int> {
  var i = 0
  while (i < arr.size) {
    var min = i
    var j = i + 1
    while (j < arr.size) {
      if (arr[j] < arr[min]) {
        min = j
      }
      j++
    }
    if (min != i) {
      var temp = arr[i]
      arr[i] = arr[min]
      arr[min] = temp
    }
    i++
  }
  return arr
}