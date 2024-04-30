# 383. Ransom Note

Level: ![Easy](https://img.shields.io/badge/Easy-lightgreen)

Language: C#

Topic: `String`

Unit Tests: [![383 - Testing Results](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/383.yml/badge.svg)](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/383.yml)

---

Given two strings `ransomNote` and `magazine`, return **true** if `ransomNote` can be constructed by using the letters from `magazine` and **false** otherwise.

Each letter in `magazine` can only be used once in `ransomNote`.

## Example 1:

- Input: ransomNote = "a", magazine = "b"
- Output: false

## Example 2:

- Input: ransomNote = "aa", magazine = "ab"
- Output: false

## Example 3:

- Input: ransomNote = "aa", magazine = "aab"
- Output: true
 
## Constraints:

- 1 <= ransomNote.length, magazine.length <= 105
- `ransomNote` and `magazine` consist of lowercase English letters.