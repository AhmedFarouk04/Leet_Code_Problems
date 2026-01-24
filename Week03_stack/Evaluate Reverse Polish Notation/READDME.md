---

# Evaluate Reverse Polish Notation

## LeetCode

**#150 – Evaluate Reverse Polish Notation**

---

## 🧠 Problem Idea

You are given an expression written in **Reverse Polish Notation (Postfix)**.
Evaluate the expression and return the final result.

---

## 💡 Key Concept

* Numbers are processed first
* Operators come after their operands
* **Stack** is the natural data structure for this problem

---

## 🛠️ Approach

1. Create a stack
2. Loop through each token
3. If token is a number → push to stack
4. If token is an operator:

   * Pop two numbers
   * Apply the operation
   * Push the result back
5. Final answer is on top of the stack

---

## ⏱️ Complexity

* **Time:** O(n)
* **Space:** O(n)

---

## 🧠 When to Use This Pattern

* Expression evaluation
* Postfix / Prefix notation
* Problems involving operators and operands in order

---

✅ **Pattern Learned:** Stack for expression evaluation

---

