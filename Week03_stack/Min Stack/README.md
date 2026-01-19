# Min Stack

---

## Problem Idea
We need to design a stack that supports:

- push  
- pop  
- top  
- getMin  

All operations must work in **O(1)** time.

---

## Core Idea
A normal stack cannot get the minimum value in O(1).

So we use **two stacks**:

- Main Stack → stores all values  
- Min Stack → stores the minimum values only

---

## How It Works
- When pushing:
  - If the value is smaller than or equal to the current minimum, also push it to Min Stack.
- When popping:
  - If the popped value equals the top of Min Stack, remove it from Min Stack.

---

## Complexity
- **Time:** O(1) for all operations  
- **Space:** O(n)

---

## Key Takeaway
Keep track of the minimum using an extra stack.
