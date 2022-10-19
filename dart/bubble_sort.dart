List bubbleSort(List arr) {
  bool noSwaps;
  for (int i = 0; i < arr.length; i++) {
    noSwaps = true;
    for (int j = 0; j < arr.length - 1; j++) {
      if (arr[j] > arr[j + 1]) {
        int temp = arr[j + 1];
        arr[j + 1] = arr[j];
        arr[j] = temp;
        noSwaps = false;
      }
    }
    if (noSwaps) break;
  }

  return arr;
}
