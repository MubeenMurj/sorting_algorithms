List selectedSort(List arr) {
  for (int i = 0; i < arr.length - 1; i++) {
    int min_val_index = i;
    for (int j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[min_val_index]) {
        min_val_index = j;
      }
    }
    if (min_val_index != i) {
      var temp = arr[i];
      arr[i] = arr[min_val_index];
      arr[min_val_index] = temp;
    }
  }
  return arr;
}
