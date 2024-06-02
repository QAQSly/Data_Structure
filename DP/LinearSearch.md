# LinearSearch
* `int[] a = {10, 5, 20, 60, 50, 70, 18, 21, 30, 7}`

| | | | | | | | | | | |
|---|----|----|----|----|----|----|----|----|----|----|
|Address|1000|1004|1008|1013|1016|1020|1024|1028|1032|1036|
|Values|10|5|20|60|50|70|18|21|30|7|
|Index|0|1|2|3|4|5|6|7|8|9|

``` c#
for (int = 0; i < arrLength;i++)
{
    if (arr[i] == key)
    {
        return i;
    }
}
return -1;
```

* Search element : 70 return 5
* Search element : 30 return 8
* Search element : 60 return 3
* Search element : 99 return -1

``` mermaid
flowchart TD;
Start[初始化 i = 0] --> B{i < arrLength};
B -- yes --> C{arr.i == key};
C -- yes --> D(i的位置);
C -- no --> E[i++];
E --> B;
D -- 返回i的值 --> F(结束);
B -- no --> G[循环中没有返回循环结束];
G --> H[返回-1];
```
