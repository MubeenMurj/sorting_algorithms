def bubble_sort(arr):
  noSwaps = False
  i = 0
  while i < len(arr) and not noSwaps:
    j = 0
    noSwaps = True
    while j < len(arr) - 1:
      if arr[j] > arr[j + 1]:
        arr[j], arr[j + 1] = arr[j + 1], arr[j]
        noSwaps = False
      j += 1
    i += 1

  return arr