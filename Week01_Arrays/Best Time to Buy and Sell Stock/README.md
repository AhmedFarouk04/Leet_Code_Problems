# Best Time to Buy and Sell Stock

 

## Pattern
- One Pass
- Kadane-like Thinking

## Key Idea
- Traverse the array once
- Keep track of the minimum price so far
- For each day, calculate the profit:
  - current price - minimum price
- Update the maximum profit

## Time Complexity
- O(n)

## Space Complexity
- O(1)

## Notes
- You must buy before you sell
- If no profit is possible, return 0
