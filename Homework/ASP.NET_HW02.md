#### Name: Samer Khamisi

## ASP.NET HW02

**1. What is the difference between Visual Studio and Visual Studio Code?**

* Visual Studio is a suite of component-based software development tools and other technologies 
for building powerful, high-performance applications. 
* On the other hand, Visual Studio Code is detailed as "Build and debug modern web and cloud applications, 
by Microsoft". Build and debug modern web and cloud applications.

**2. What is LocalDB?**

* LocalDB is a developer oriented, on-demand managed instance of the SQL Server engine that can be turned 
on automatically when needed and turned off when not in use.

**3. What do these commands do?**

*dotnet new globaljson --sdk-version 3.1.101 --output FirstProject*
* Outputs a new json file called FirstProject, using skd ver 3.1

*dotnet new mvc --no-https --output FirstProject --framework netcoreapp3.1*
* Outputs a new mvc project called FirstProject using netcoreapp 3.1

**4. What command do you use to build an ASP.NET project from the command line? What command
do you use to run the project?**

* dotnet new to build a ASP.NET project -- Creates new dotnet project
* dotnet run -- Runs dotnet project

**5. What is the purpose of an endpoint?**

* An endpoint is used to handle incoming requests.

**6. What is a controller?**

* A controller is a built-in class, that has methods known as actions , which can be invoked to 
handle an http request.

**7. Where are actions defined?**

* Actions are defined in the controller class

**8. What is the purpose of the routing system?**

* The purpose of the routing system is to select the endpoints that will handle a HTTP request.

**9. Assume that your ASP.NET application runs in a browser with a URL like http://localhost:5000.
List the three default routes configured by the ASP.NET Core routing system.**

* The three default routes configured by ASP.NET core routing system are /, /Home, /Home/Index

**10. What does the ViewResult object instruct ASP.NET Core to do?**

* The viewResult object instructs ASP.NET core to render a view. You create the ViewResult by calling the view method
and specifying the name.

**11. How does ASP.NET Core know what View is to be called from an action method?**

* ASP.NET core knows what view to be called from an action method by following the standard naming convention, which
is to put files in the folder that matches the controller that contains the action method.

**12. What is the job of an action method?**

* The action method constructs data and passes it to the view so it can be used to create HTML content
based on the data values.

**13. What is a view model?**

* The data provided to the view is known as the view model.