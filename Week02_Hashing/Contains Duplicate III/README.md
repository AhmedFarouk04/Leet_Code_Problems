# Contains Duplicate III



---

## Problem Summary
Given an integer array `nums`, check whether there exist two indices `i` and `j` such that:

- `|nums[i] - nums[j]| ≤ t`
- `|i - j| ≤ k`

---

## Core Idea
We must check **both**:
- Distance between indices (sliding window of size `k`)
- Distance between values (range search within `± t`)

---

## Pattern Used
**Sliding Window + Ordered Set**

---

## Solution Approach
1. Maintain a sliding window of size at most `k`.
2. Store window elements in a **sorted structure**.
3. For each element, check if any value exists in the range:[current - t , current + t]
4. If a value exists in this range, return `true`.
5. Add the current element to the window and remove elements that fall outside the window.

---

## Time & Space Complexity
- **Time Complexity:** `O(n log k)`  
- Each insert, remove, and range search takes `O(log k)`
- **Space Complexity:** `O(k)`  
- The sliding window stores at most `k` elements

---

## Why SortedSet and Not Hash or Dictionary?
A `Dictionary` (hash table) only supports **exact key lookup**.

This problem requires:
- Searching for **any value within a range** (`current ± t`)
- Not just checking if a specific value exists

A `SortedSet` keeps elements ordered, which allows efficient range queries.
Therefore, hashing alone is not sufficient for this problem.

---

## Key Takeaway
When a problem requires **value range searching**, ordered data structures are required instead of hash-based ones.

