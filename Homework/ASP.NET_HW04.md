#### Name: Samer Khamisi

## ASP.NET HW04

**1. What are the .NET SDK command line tools used for? Is their use required? Why or why not?**

* Creating, managing, building, and running projects.

**2. What kind of applications do the following templates create? Run these commands and read the
documentation.**

* dotnet new console --help
	* A project for creating a command-line application that can run on .NET Core on Windows, Linux, and MacOS
* dotnet new mvc --help
	* A project template for creating ASP.NET Core application with example ASP.NET Core MVS Views and Controllers
* dotnet new web --help
	* An empty project template for creating an ASP.NET Core application

**3. What, specifically, do the following commands do?**

* dotnet new globaljson --sdk-version 3.1.101 --output MySolution/MyProject
	* Creates a MySolution/MyProject folder that contains a global.json file, which specifies that the project will use 
	.NET Core version 3.1.1.
* dotnet new web --no-https --output MySolution/MyProject --framework netcoreapp3.1
	* Creates a new web template project with no https, using the specified framework version
* dotnet new sln -o MySolution
	* Creates a new solution file and names it MySolution
* dotnet sln MySolution add MySolution/MyProject
	* Adds the solution file to the created project
	
**4. What is the purpose of the global.json file?**

* It is a good idea to add a global.json file to projects so that everyone in the development team is using the same version.

**5. What does the method app.UseStaticFiles() do?**

* Adds support for responding to HTTP requests with static content in the wwwroot folder

**6. What do the following two commands do?**

* dotnet build
	* Builds the project
* dotnet run
	* Builds and runs the project
	
**7. You can manage packages using the NuGet package manager and the command line tool
dotnet add package. What are packages and what are they used for.**

* Packages add additional features beyond those set up by the project templates, such as support for accessing databases or
for making HTTP requests

**8. What are tool packages and what are they used for?**

* Tool packages install commands that can be used from the command line to perform operations on .NET Core projects. One
common example is the Entity Framework Core tools package that installs commands that are used to manage databases in ASP.
NET Core projects.


**9. What are client side packages and what are they used for?**

* Client-side packages contain content that is delivered to the client, such as images, CSS stylesheets, JavaScript files, and static
HTML.

**10. List two ways that a developer can debug code.**

* Use the **Start Debugging** option in Visual Studio
* 