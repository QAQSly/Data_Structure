# Hash
## 两数之和
1. 为了覆盖所有结果的路径，需要一次检查所有的元素
2. 针对所选元素，对输入中的元素与所选元素求和满足目标

* 暴力解决：
* 直接使用循环多次遍历
* 哈希解决：
* 利用特别的数据结构来省略循环步骤

``` java
class Solution {
    public int[] twoSum(int[] nums, int target) {
        // ---定义一个哈希表 存储选择的数以及下标
        HashMap<Integer, Integer> map = new HashMap<>();
        // ---遍历整个数组
        for (int i = 0; i < nums.length; i++) {
            // --- 当前选择的数
            int choose = nums[i];
            // --- 计算需要的数
            int need = target - choose;
            // --- 在哈希表寻找需要的数
            if (map.containsKey(need)) {
                // --- 找到了就返回需要的数组值和选择的数的下标
                return new int[] { map.get(need), i };
            }
            // --- 填入选择的数
            map.put(choose, i);
        }
        return null;

    }
}
```

