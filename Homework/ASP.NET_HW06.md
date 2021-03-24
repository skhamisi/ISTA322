#### Name: Samer Khamisi

## ASP.NET HW06

**1. What is unit testing as defined by the book?**

* A form of testing in which individual components are isolated from the rest of the application so their behavior can be thoroughly validated.

**2. What is the convention for creating unit tests in ASP.NET Core applications?**

* Depends on the user for how much to implement, but it is  recommended that you do not leave it out

**3. Name three unit test project tools used for ASP.NET Core applications.**

* xUnit - This template creates a project configured for the XUnit framework.
* NUnit - This template creates a project configured for the NUnit framework.
* MSTest - This template creates a project configured for the MS Test framework, which is produced by Microsoft.

**4. What is the convention for naming unit tests in ASP.NET Core applications?**

* Conventionally, the name of the test methods describes what the test does, and the name of the class describes what is being tested.

**5. What is the convention for naming the test classes in AP.NET Core? What is the convention for
naming the methods in the test classes?**

* The convention is to name the unit test project <ApplicationName>.Tests.

**6. What is the purpose of the Fact attribute in Xunit? What is the purpose of the Theory
attribute in Xunit?**

* xUnit uses the [Fact] attribute to denote a parameter less unit test, which tests invariants in your code.
* The [Theory] attribute denotes a parameterized test that is true for a subset of data.

**7. Describe the different elements of the AAA testing pattern.**

* Arrange refers to setting up the conditions for the test
* Act refers to performing the test
* Assert refers to verifying that the result was the one that was expected.

**8. Describe the use of the methods in the Assert class. Describe the purpose, parameters, and return
value of the Assert.Equals() method.**

* The methods of the Assert class are static and are used to perform different kinds of comparison between the expected and actual results.
* The Assert.Equals() method asserts that the result is equal to the expected outcome. There are overloaded
versions of this method for comparing different types and for comparing collections.
There is also a version of this method that accepts an additional argument of an object that
implements the IEqualityComparer<T> interface for comparing objects.

**9. What is the key to isolating a component for testing?**

* The key to isolating components is to use C# interfaces.

**10. What is a mocking package? What does it do?**

* A mocking package makes it easy to create fake or mock objects for tests

**11. What is the difference between the Setup() and the SetupGet() methods of Moq?**

* Setup() can be used for mocking a method or a property. 
* SetupGet() is specifically for mocking the getter of a property.
