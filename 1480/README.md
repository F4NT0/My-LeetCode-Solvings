# 1480. Running Sum of 1d Array

Level: $\color{lightgreen}{\sf Easy}$

Language: C#

Topic: $\color{yellow} \sf Arrays$

Unit Tests: [![1480 - Testing Results](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/1480.yml/badge.svg)](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/1480.yml)

---

Given an array `nums`. We define a running sum of an array as 

```csharp
runningSum[i] = sum(nums[0]…nums[i]).
```

Expected: **Return the running sum of nums.**


## Example 1:

- Input: nums = [1,2,3,4]
- Output: [1,3,6,10]
- Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

## Example 2:

- Input: nums = [1,1,1,1,1]
- Output: [1,2,3,4,5]
- Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].

## Example 3:

- Input: nums = [3,1,2,10,1]
- Output: [3,4,6,16,17]
 
## Constraints:

- 1 <= nums.length <= 1000
- -10^6 <= nums[i] <= 10^6

