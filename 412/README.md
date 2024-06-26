# 412. Fizz Buzz

Level: ![Easy](https://img.shields.io/badge/Easy-lightgreen)

Language: C#

Topic: `String`

Unit Tests: [![412 - Testing Results](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/412.yml/badge.svg)](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/412.yml)

---

Given an integer `n`, return a string array `answer` **(1-indexed)** where:

- answer[i] == "FizzBuzz" if `i` is divisible by `3 and 5`.
- answer[i] == "Fizz" if `i` is divisible by `3`.
- answer[i] == "Buzz" if `i` is divisible by `5`.
- answer[i] == `i` (as a string) if **none of the above conditions are true**.
 
## Example 1:

- Input: n = 3
- Output: ["1","2","Fizz"]

## Example 2:

- Input: n = 5
- Output: ["1","2","Fizz","4","Buzz"]

## Example 3:

- Input: n = 15
- Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 
## Constraints:

- 1 <= n <= 104

