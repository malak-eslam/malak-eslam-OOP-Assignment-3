What is the same between the two stores, and what is different?

Same:
- Both stores use a List to store their items.
- Both have Add, GetById, GetAll, and Remove methods.
- Both search by Id.

Different:
- StudentStore stores Student objects.
- CourseStore stores Course objects.
- Student has Id and Name.
- Course has Id, Title, and Price.

------------------------------------------
Step 3
Compiler Error

 T  does not contain a definition for  Id  and no accessible extension method  Id  accepting a first argument of type  T  could be found.

Why?

The compiler does not know that T has an Id property T can be any type  so we cannot use item.Id unless we tell the compiler that T has an Id.

------------------------------------------
