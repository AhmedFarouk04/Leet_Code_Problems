Largest Rectangle in Histogram

Goal:
Find the largest rectangle area inside a histogram.

Idea:

Use a monotonic increasing stack

Stack stores indices, not heights

When a smaller height appears → we finalize areas

Key Insight:
When a bar is popped:

It is the smallest height in its rectangle

Left boundary = new stack top

Right boundary = current index

Why Stack?
Because each bar is pushed and popped once only

Time Complexity:

O(n)

Space Complexity:

O(n)