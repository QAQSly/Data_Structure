# BinarySearch
* `int[] a = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}`

| | | | | | | | | | | |
|---|----|----|----|----|----|----|----|----|----|----|
|Address|1000|1004|1008|1012|1016|1020|1024|1028|1032|1036|
|Values|10|20|30|40|50|60|70|80|90|100|
|Index|0|1|2|3|4|5|6|7|8|9|

``` c#
while (low < high)
{
    mid = (low + high) / 2
    if (arr[mid] == key)
    {
        return mid;
    }
    else if (arr[mid] < key)
    {
        low = mid + 1;
    }
    else if (arr[mid] > key)
    {
        high = mid -1;
    }
}
return -1
```

``` mermaid
flowchart TD
1[Start] --> 2{low < high};
2 --yes --> 3[mid = （low + high） / 2];
3 --> 4{arr.mid == key};
4 -- yes --> 5[return mid];
4 -- no --> 6{arr.mid < key};
6 -- yes -->7[low = mid + 1];
6 -- no --> 8{arr.mid > key};
8 -- yes --> 9[high = mid -1];
7 --> 2;
9 --> 2;
2 -- no --> 10[return -1];
```