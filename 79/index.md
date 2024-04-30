# 79. Word Search

Level: ![Medium](https://img.shields.io/badge/Medium-yellow)

Language: C#

Topic: `Matrix`

Unit Test: [![79 - Testing Results](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/79.yml/badge.svg)](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/79.yml)

---

Given an `m x n` grid of characters board and a string word, return true if word exists in the grid.

The word can be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring. The same letter cell may not be used more than once.

## Example 1:

![image1](https://assets.leetcode.com/uploads/2020/11/04/word2.jpg)

- Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
- Output: true

## Example 2:

![image2](https://assets.leetcode.com/uploads/2020/11/04/word-1.jpg)

- Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
- Output: true

## Example 3:

![image3](https://assets.leetcode.com/uploads/2020/10/15/word3.jpg)

- Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"
- Output: false
 
## Constraints:

- m == board.length
- n = board[i].length
- 1 <= m, n <= 6
- 1 <= word.length <= 15
- board and word consists of only lowercase and uppercase English letters.

