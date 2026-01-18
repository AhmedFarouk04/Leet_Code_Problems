# Week 2 – Hashing

This week focuses on using hash-based data structures to solve problems efficiently.
The main goal is to recognize when hashing is needed instead of brute force solutions.

---

## 🎯 Goals
- Understand when to use hashing
- Reduce time complexity using fast lookups
- Choose the correct hash-based structure for each problem

---

## 🧠 Core Patterns

### 1️⃣ Frequency Map
Used when:
- Counting elements
- Comparing character frequencies

Examples:
- Valid Anagram
- Group Anagrams

Key idea:

---

### 2️⃣ Set Usage
Used when:
- Only checking existence
- Detecting duplicates

Examples:
- Contains Duplicate

Key idea:

---

### 3️⃣ Index / Range Mapping
Used when:
- Tracking positions of elements
- Applying constraints on indices or values

Examples:
- Contains Duplicate II (index distance)
- Contains Duplicate III (value range + index window)

Key idea:
- Dictionary for index mapping
- SortedSet for range searching

---

## 📚 Problems Solved
- Valid Anagram
- Contains Duplicate
- Contains Duplicate II
- Contains Duplicate III
- Group Anagrams

---

## ⏱️ Complexity Awareness
- HashSet / Dictionary operations are `O(1)` on average
- Ordered structures allow range queries but cost `O(log n)`
- Extra space is acceptable to achieve better time complexity

---

## 🔑 Key Takeaway
Hashing helps transform slow nested loops into fast lookups.
Choosing the correct structure is more important than memorizing solutions.

---

## 🚀 Next Step
Move to **Week 3 – Stack & Monotonic Stack**.
