# Week 01 – Arrays & Core Patterns

This week focuses on building strong fundamentals in array-based problem solving.
The main goal is to recognize common patterns instead of memorizing solutions.

---

## 🎯 Goals of This Week

- Learn how to analyze array problems
- Recognize patterns quickly
- Write clean and efficient solutions in C#
- Think before coding

---

## 🧠 Core Patterns Learned

### 1️⃣ Two Pointers

Used when:

- The array is sorted
- We are searching for pairs or triplets
- We want to reduce time complexity from O(n²) to O(n)

Key idea:
Move pointers based on comparison with target.

Problems:

- Two Sum
- Two Sum II (Input Array Is Sorted)
- Container With Most Water
- 3Sum

---

### 2️⃣ Sliding Window

Used when:

- Working with contiguous subarrays or substrings
- Searching for longest / shortest range

Key idea:
Expand and shrink a window while maintaining a condition.

Problems:

- Longest Substring Without Repeating Characters

---

### 3️⃣ Prefix Sum + Hashing (Intro)

Used when:

- Dealing with subarrays and sums
- Counting or finding ranges efficiently

Key idea:
If two prefix sums are equal, the subarray between them has a special property.

Problems:

- Subarray Sum Equals K
- Contiguous Array

---

## 📚 Problems Solved

| Problem                                        | Pattern                |
| ---------------------------------------------- | ---------------------- |
| Two Sum                                        | Hashing                |
| Two Sum II                                     | Two Pointers           |
| Best Time to Buy and Sell Stock                | Greedy / One Pass      |
| Container With Most Water                      | Two Pointers           |
| Longest Substring Without Repeating Characters | Sliding Window         |
| Subarray Sum Equals K                          | Prefix Sum + Hash Map  |
| Contiguous Array                               | Prefix Sum + Hash Map  |
| 3Sum                                           | Sorting + Two Pointers |

---

## 🧩 Key Takeaways

- Always analyze constraints before coding
- Arrays often hide classic patterns
- Prefix Sum converts range problems into math problems
- Two Pointers works best with sorted arrays

---

## ⏱️ Complexity Awareness

- Prefer O(n) over O(n²)
- Use extra space when it simplifies logic
- Trade-offs are acceptable if explained clearly

---

## 🚀 Next Step

Move to **Week 02 – Hashing** to deepen understanding of:

- Frequency Maps
- Sets
- Grouping problems
