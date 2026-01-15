# Contains Duplicate


---

## Problem Summary
Given an integer array, determine if any value appears at least twice.

---

## Key Idea
- We only need to know if a number has appeared before.
- No need to track index or frequency.

---

## Approach
- Use a HashSet to store seen elements.
- While iterating:
  - If the element already exists in the set → return true.
  - Otherwise, add it to the set.

---

## Why HashSet?
- Fast lookup: O(1)
- Simple logic for existence checking

---

## Time Complexity
- O(n)

## Space Complexity
- O(n)
