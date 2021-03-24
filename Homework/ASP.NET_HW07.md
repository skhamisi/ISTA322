#### Name: Samer Khamisi

## ASP.NET HW07

**1. For the Sports Store application, what requirements does the author identify for implementation?**

* online product catalog that customers can browse by category and page
* shopping cart where users can add and remove products
* checkout where customers can enter their shipping details
* administration area that includes create, read, update, and delete (CRUD) facilities for managing the catalog

**2. What is the purpose of the Startup class in ASP.NET Core applications?**

* The Startup class is responsible for configuring the ASP.NET Core application.

**3. What is the purpose of the ConfigureServices method in the Startup class?**

* The ConfigureServices method is used to set up objects, known as services, that can be used throughout the application and 
that are accessed through a feature called dependency injection

**4. What is a request pipeline and how does it work?**

* ASP.NET Core request pipeline is used to process HTTP requests
* The ASP.NET Core request pipeline consists of a sequence of request delegates, called one after the other.
* HTTP Request --> [Middleware components] --> HTTP Response

**5. What is the View Start class and how do we use it?**

* The view start file tells Razor to use a layout file in the HTML that it generates, reducing the amount of duplication in views.

**6. What is the feature in ASP.NET Core that generates the database schema for us? What does the file
created by this feature contain?**

* Models, This folder will contain the data model and the classes that provide access to the data in the application’s database.

**7. When ASP.NET Core sees that a controller instance needs to be created, and that the controller object
required another object that iplements some interface, how does it determine which interface should be implemented?**

* To determine what implementation class should be used, ASP.NET Core consults the configuration in the Startup class, this is known as dependency injection

**8. Explain how the paging mechanism works. How does the application calculate the number of pages
required? How is this data passed to the view?**

* Allows for data to be spread among multiple pages
* Amount of pages is set by using the PageSize field
*

**9. How does the book describe dependency injection? How is dependency injection used?**

* Dependency Injection makes it easy to create loosely coupled components, which typically means that components consume functionality defined by interfaces without having any firsthand knowledge of which
implementation classes are being used.
* The Startup class is used to specify which implementation classes are used to deliver the functionality specified by the interfaces used by the application. Services can be explicitly requested through the IServiceProvider interface or by declaring constructor or method parameters.

**10. How are the routes in MapDefaultControllerRoute() method arranged? Why is this important?**

* The MapDefaultControllerRoute method avoids the risk of mistyping the URL pattern and sets up the convention-based routing.
