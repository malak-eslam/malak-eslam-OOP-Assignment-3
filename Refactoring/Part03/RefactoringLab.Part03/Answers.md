# Part 03 — answers

---

## BlockedUsers

- Time complexity before:
- Time (ms) before: 80 ms
- What did you change? Replaced the repeated List.Contains() search with a HashSet<int> and used HashSet.Contains().
- Time complexity after: O(1)
- Time (ms) after: 2 ms

---

## Students

- What was the problem? GetAllStudents() created 1,000,000 Student objects at once even when only a few students were needed
- What did you change? Changed GetAllStudents() to return IEnumerable<Student> and used yield return to generate students lazily one at a time
