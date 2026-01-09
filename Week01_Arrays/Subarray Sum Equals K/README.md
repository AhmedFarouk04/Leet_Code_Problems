# Subarray Sum Equals K

**LeetCode #:** 560  
**Difficulty:** Medium  

## Pattern
- Prefix Sum
- Hash Map

## Key Idea
- Keep a running prefix sum
- If (currentSum - k) appeared before, a valid subarray exists
- Use a hash map to store counts of prefix sums

## Time Complexity
- O(n)

## Space Complexity
- O(n)

## Notes
- Works with negative numbers
- Sliding Window does NOT work here(do not work in negative value)
