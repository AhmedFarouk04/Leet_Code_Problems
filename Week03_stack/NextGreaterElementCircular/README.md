
---

# Next Greater Element II (Circular Array)

## 🧠 Problem Idea

You are given a **circular array**.
For each element, find the **next greater element** to its right.
If it does not exist, return `-1`.

---

## 💡 Core Concept

* Use **Monotonic Stack**
* Loop through the array **twice**
* Use `i % n` to simulate the circular behavior

---

## 🔑 Key Trick

```csharp
int idx = i % n;
```

This allows us to go back to the start of the array without creating a new one.

---

## 🛠️ Approach

1. Initialize result array with `-1`
2. Use a stack to store **indices**
3. Loop from `0` to `2 * n - 1`
4. While current number is greater than stack top → update answer
5. Push index only in the first pass

---

## ⏱️ Complexity

* **Time:** O(n)
* **Space:** O(n)

Each element is pushed and popped from the stack at most once.

---

## 🧠 When to Use This Pattern

* Next Greater / Smaller problems
* Circular array
* Problems requiring comparison with future elements

---

✅ **Pattern Learned:**
**Monotonic Stack + Circular Traversal**

---


