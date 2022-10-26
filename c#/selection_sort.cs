public static int[] SelectionSort(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    int min_value_index = i;
    for (int j = i; j < arr.Length; j++)
    {
      if (arr[j] < arr[min_value_index])
      {
        min_value_index = j;
      }
    }
    if (min_value_index != i)
    {
      int temp = arr[i];
      arr[i] = arr[min_value_index];
      arr[min_value_index] = temp;
    }
  }
  return arr;
}