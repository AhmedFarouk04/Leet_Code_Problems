# Longest Substring Without Repeating Characters

## Pattern
- Sliding Window

## Key Idea
- Use a sliding window to maintain a substring with unique characters
- Use a HashSet to track characters inside the current window
- Expand the window when characters are unique
- Shrink the window when a duplicate character appears

## Why HashSet?
- We only need to check if a character exists in the window
- No need to store indices or counts
- HashSet provides O(1) add, remove, and lookup

## Time Complexity
- O(n)

## Space Complexity
- O(n)
