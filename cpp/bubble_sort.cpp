int *bubble_sort(int arr[], int size)
{
  bool no_swaps;
  for (int i = 0; i < size; i++)
  {
    no_swaps = false;
    for (int j = 0; j < size; j++)
    {
      if (arr[j] > arr[j + 1])
      {
        int temp = arr[j + 1];
        arr[j + 1] = arr[j];
        arr[j] = temp;
        no_swaps = true;
      }
    }
    if (!no_swaps)
    {
      break;
    }
  }

  return arr;
}