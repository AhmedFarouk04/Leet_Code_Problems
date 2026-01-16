# Group Anagrams

 

---

## Idea
Words that are anagrams have the **same characters in the same frequency**.

If we convert each word into a **fixed representation**, all anagrams will produce the same key.

---

## Approach
1. Sort the characters of each word.
2. Use the sorted word as a key in a hash map.
3. Group all words that share the same key.

---

## Pattern
- Hashing
- Grouping

---

## Time & Space Complexity
- **Time:** O(n · k log k)  
- **Space:** O(n · k)

Where:
- `n` = number of words  
- `k` = length of each word

---

## Key Takeaway
Convert each word to a common form, then group using a hash map.
