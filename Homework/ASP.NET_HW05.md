#### Name: Samer Khamisi

## ASP.NET HW05

**1. What is the purpose of the null conditional operator? Does it apply to value types or reference types?
Why or why not?**

* The part to the right of the (?) only evaluates if the part to the left is not null. Otherwise, the code returns null.

**2. What is the null coalescing operator? What does it do?**

* Returns the value of the part on the left if the (??) if it is not a null reference. Otherwise, it returns the value of the part on the right. Use this operator to fall back on a given value.

**3. How is the null conditional operator different from a nullable type? What is the purpose of nullable
types?**

* Nullable reference types shift responsibility for null checking to the code that assigns the value to a variable.

**4. When you create an automatic property and initialize the property with a value, can the value be
changed later? Can another value be assigned to the property? Can the value be changed in the
constructor?**

* Cannot change value because it is read-only (Don't allow you to set an initial value)
* No other value can be assigned
* The value can be changed in the constructor

**5. What is an object initializer and what is it for? What is an collection initializer and what is it for?**

* An object initializer allows you to create an object and specify its property values in a single step
* A collection initializer allows the creation of a collection and its contents to be specified in a single step

**6. What does the is keyword do?**

* The is operator checks if the result of an expression is compatible with a given type, or tests an expression against a pattern.

**7. How are extension methods defined?**

* Extension methods are defined in static classes within the same namespace as the class the extension methods applies to.

**8. What is implicit typing or type inference? How do you implement it?**

* Local variables can be declared without giving an explicit type. The var keyword instructs the compiler to infer the type of the variable from the expression on the right side of the initialization statement.

**9. What is a default implementation of an interface? What is the purpose of a default implementation
of an interface?**

* Makes it possible to update interfaces without breaking the existing implementations of them.

**10. What are asynchronous methods? Why should we use them? How are they used?**

* Asynchronous methods perform work in the background and notify you when they are complete, allowing your code to take care
of other business while the background work is performed
* They are an important tool in removing bottlenecks from code and allow applications to take advantage of multiple processors and processor cores to perform work in parallel.

**11. When you use the await keyword, do you have to use the async keyword? Why or why not?**

* Async and await in C# are the code markers, which marks code positions from where the control should resume after a task completes.

**12. What is the yield keyword used for? How do you use it?**

* You use a yield return statement to return each element one at a time. 
* When a yield return statement is reached in the iterator method, expression is returned, and the current location in code is retained. Execution is restarted from that location the next time that the iterator function is called.

**13. What is the effect of using the nameof() expression?**

* The nameof expression replaces a C# symbol with the string representation of that symbol.
