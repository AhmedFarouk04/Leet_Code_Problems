# Daily Temperatures



---

## Problem Idea
For each day, find how many days you must wait until a warmer temperature.
If no warmer day exists, return 0.

---

## Core Idea
Use a stack to keep days that are waiting for a warmer temperature.

The stack stores **indices**, not temperatures.

---

## How It Works
- Iterate through the array.
- When the current temperature is higher than the temperature at the top of the stack:
  - Pop the index.
  - Calculate the difference in days.
- Push the current index into the stack.

---

## Pattern
Monotonic Stack (Decreasing)

---

## Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## Key Takeaway
Each day is pushed and popped once from the stack.
