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
## Step 7

 Store<string> must not compile because Store<T> has the constraint where T : IHasId

 string  does not implement  IHasId  so it does not have the required  Id  property.
 Therefore string cannot be used as T in Store<T>.

------------------------------------------
The common name for this kind of class is a Generic Repository.

It provides common operations such as adding, getting, and removing objects without depending on a specific type.

------------------------------------------

