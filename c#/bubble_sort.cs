public static int[] BubbleSort(int[] arr)
{
  bool noSwaps;
  for (int i = 0; i < arr.Length; i++)
  {
    noSwaps = true;
    for (int j = 0; j < arr.Length - 1; j++)
    {
      if (arr[j] > arr[j + 1])
      {
        int temp = arr[j + 1];
        arr[j + 1] = arr[j];
        arr[j] = temp;
        noSwaps = false;
      }
    }
    if (noSwaps)
    {
      break;
    }
  }

  return arr;
}