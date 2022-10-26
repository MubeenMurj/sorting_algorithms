<?php
function selection_sort($arr)
{
  for ($i = 0; $i < count($arr); $i++) {
    $min = $i;
    for ($j = $i + 1; $j < count($arr); $j++) {
      if ($arr[$j] < $arr[$min]) {
        $min = $j;
      }
    }
    if ($i !== $min) {
      $temp = $arr[$i];
      $arr[$i] = $arr[$min];
      $arr[$min] = $temp;
    }
  }
  return $arr;
}