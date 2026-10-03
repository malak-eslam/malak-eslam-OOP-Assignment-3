## Task 2.1 — IReadOnlyDictionary & SortedDictionary

### IReadOnlyDictionary<TKey, TValue>

`IReadOnlyDictionary` allows the caller to read key-value pairs but does not allow adding or removing items through that reference.

The main difference from `Dictionary` is that `Dictionary` allows modifications such as `Add` and `Remove`, while `IReadOnlyDictionary` is read-only.

A public method may return `IReadOnlyDictionary` instead of `Dictionary` when callers should be able to read the data but should not be able to modify the collection. This provides better encapsulation.

### SortedDictionary<TKey, TValue>

`SortedDictionary` stores key-value pairs and keeps them sorted by their keys.

Unlike `Dictionary`, which is designed for fast lookup by key, `SortedDictionary` keeps its keys in sorted order.

`Dictionary` provides average O(1) lookup by key, while `SortedDictionary` provides O(log n) lookup.

I would choose `SortedDictionary` when I need key-value data to always be available in sorted key order, such as a timetable ordered by session start time.

---------------------------------------------------------------------------

## Task 2.2 — Pick the Collection

* **S1 — Dictionary**

   Use `Dictionary` because students can be found quickly by their national ID.

* **S2 — HashSet**

   Use `HashSet` because it does not allow duplicate tags.

* **S3 — List**

   Use `List` because it keeps the grades in their insertion order and allows duplicate grades.

* **S4 — IReadOnlyDictionary**

   Use `IReadOnlyDictionary` because callers need to read the prices but should not be able to add or remove them.

* **S5 — SortedDictionary**

   Use `SortedDictionary` because the sessions are keyed by their start time and must always be in sorted order.

* **S6 — IEnumerable**

   Use `IEnumerable` because the caller only needs to iterate over the results and may stop before reading all of them.
