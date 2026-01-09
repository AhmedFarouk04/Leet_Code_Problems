# Contiguous Array

**LeetCode #:** 525  
**Difficulty:** Medium  

---

## Problem Summary
Given a binary array `nums` containing only `0` and `1`, find the length of the longest contiguous subarray with an equal number of `0` and `1`.

---

## Key Idea
- Convert the problem into a prefix sum problem.
- Replace:
  - `0` with `-1`
  - `1` with `+1`
- If the same prefix sum appears at two different indices, the subarray between them has an equal number of `0` and `1`.

---

## Why This Works
- A prefix sum represents the difference between the number of `1`s and `0`s.
- When the prefix sum repeats, the difference becomes zero in between.
- Storing the **first occurrence** of each prefix sum gives the maximum possible subarray length.

---

## Algorithm
1. Initialize a dictionary to store the first index of each prefix sum.
2. Start with `sum = 0` at index `-1`.
3. Traverse the array:
   - Update the sum (`-1` for `0`, `+1` for `1`).
   - If the sum has been seen before, calculate the subarray length.
   - Otherwise, store the current index as the first occurrence.
4. Return the maximum length found.

---

## Time Complexity
- **O(n)**

## Space Complexity
- **O(n)**

---

## Notes
- Sliding Window does NOT work for this problem.
- Only the first occurrence of each prefix sum is stored.
- This is a classic Prefix Sum + Hash Map problem.
