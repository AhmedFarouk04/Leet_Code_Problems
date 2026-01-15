# Contains Duplicate II



---

## Problem Summary
Check if there are two equal values such that the difference between their indices is at most k.

---

## Key Idea
- We need to know where each number was last seen.
- Simply knowing existence is not enough.

---

## Approach
- Use a Dictionary to map each number to its last index.
- While iterating:
  - If the number exists, check the distance between indices.
  - If the distance ≤ k → return true.
  - Update the last index.

---

## Why Dictionary?
- Stores additional information (index).
- Enables distance calculation between occurrences.

---

## Time Complexity
- O(n)

## Space Complexity
- O(n)
