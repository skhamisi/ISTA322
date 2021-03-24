#### Name: Samer Khamisi

## ASP.NET HW03

**1. What is the most important part of an ASP.NET Core 3 application?**

* The data model

**2. What is the domain model?**

* The model is the representation of the real-world objects, processes, 
and rules that define the subject, known as the domain, of the application.
* contains the C# objects (known as domain objects) that make up the universe of the application and the methods
that manipulate them.

**3. Where are the model classes in an ASP.NET Core 3 application placed?**

* In a folder named MODELS

**4. How many action methods can a controller class define?**

* A single controller class can define multiple action methods, and the convention is to group related actions together in the
same controller.

**5. What is a tag helper?**

* An instruction for Razor that will be performed when the view is rendered.

**6. What does the asp-action attribute do?**

* An instruction to add an href attribute to the a element that contains a URL for an action method.

**7. What is the difference between HTTP GET and HTTP POST? This is an important question, and you
should understand the difference.**

* A GET request is what a browser issues normally each time
someone clicks a link. This version of the action will be responsible for displaying the initial blank form when
someone first visits /Home/RsvpForm.
* By default, forms rendered using Html.BeginForm() are submitted by the browser as a POST request. This version of 
the action will be responsible for receivingsubmitted data and deciding what to do with it.

**8. What is model binding?**

* ASP.NET Core feature whereby incoming data is parsed and the key/value pairs in the
HTTP request are used to populate properties of domain model types.

**9. Why should we validate user data? How do we validate user data?**

* Without validation, users could enter nonsense data or even submit an empty
form.
* In an ASP.NET Core application, validation rules are defined by applying attributes to model classes

**10. What, specifically, is the ModelState.IsValid property?**

* The Controller base class provides a property called ModelState that provides details of the outcome of the model binding
process.

**11. What does the asp-validation-summary do?**

* The value for the asp-validation-summary attribute is a value from an enumeration called ValidationSummary,
which specifies what types of validation errors the summary will contain

**12. Static content consists of content such as images, script files, style files, etc. In an ASP.NET Core
application, what is the name of the folder that contains static content?**

* WWWROOT folder

**13. What is Bootstrap? Who developed Bootstrap? Is Bootstrap a proprietary package? If not, what is
it?**

* Bootstrap is a free and open-source CSS framework directed at responsive, mobile-first front-end web development. 
It contains CSS- and (optionally) JavaScript-based design templates for typography, forms, buttons, navigation, and other interface 
components.
* Developed by Mark Otto and Jacob Thornton at Twitter as a framework to encourage consistency across internal tools.