# ASP.NET Core Razor Views Example

This project demonstrates various features of Razor Pages and the Razor view engine within an ASP.NET Core MVC application. It explores how C# code can be seamlessly integrated with HTML markup in `.cshtml` files to generate dynamic views and serve them to the client.

## Key Concepts Demonstrated

This example likely covers several aspects of working with Razor views, including but not limited to:

*   **Razor Syntax:**
    *   Using `@` symbol for C# expressions, code blocks, and directives.
    *   HTML encoding (`@Html.Raw()` vs. default encoding).
*   **Strongly-Typed Views:**
    *   Defining a model for a view using `@model YourNamespace.Models.YourModel`.
    *   Accessing model properties within the Razor view (e.g., `@Model.PropertyName`).
*   **ViewData and ViewBag:**
    *   Passing data from controllers to views using `ViewData["Key"] = value;` or `ViewBag.PropertyName = value;`.
    *   Accessing this data in the view: `@ViewData["Key"]` or `@ViewBag.PropertyName`.
*   **Layouts:**
    *   Defining a common page structure using a `_Layout.cshtml` file (typically in `Views/Shared`).
    *   Using `@RenderBody()` to inject content from specific views into the layout.
    *   Using `@RenderSection("SectionName", required: false)` for optional content sections.
*   **Partial Views:**
    *   Creating reusable view snippets using partial view files (e.g., `_MyPartialView.cshtml`).
    *   Rendering partial views using `@Html.Partial("_MyPartialView", modelForPartial)` or `<partial name="_MyPartialView" model="modelForPartial" />`.
*   **Tag Helpers:**
    *   Using built-in Tag Helpers for common HTML elements like forms, links, and input fields (e.g., `<form asp-action="Submit">`, `<a asp-controller="Home" asp-action="Index">`, `<input asp-for="PropertyName" />`).
    *   Potentially custom Tag Helpers.
*   **HTML Helpers:**
    *   Using traditional HTML Helpers like `@Html.TextBoxFor(m => m.PropertyName)`, `@Html.ActionLink("LinkText", "ActionName", "ControllerName")`.
*   **Control Structures:**
    *   Using C# control structures like `if/else`, `switch`, `for`, `foreach`, `while` within Razor views.
*   **Comments:**
    *   Razor comments: `@* This is a Razor comment *@` (not sent to client).
    *   HTML comments: `<!-- This is an HTML comment -->` (sent to client).
*   **Dependency Injection in Views:**
    *   Injecting services directly into views using `@inject YourNamespace.Services.IService MyService`.

*(The exact features demonstrated will be found by exploring the different `.cshtml` files within the `Views` folder and the corresponding `Controller` actions.)*

## Installation & Setup

1.  **Prerequisites:**
    *   Ensure you have the .NET SDK installed (likely .NET 6, .NET 7, or .NET 8, based on current ASP.NET Core practices). You can download it from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
    *   An IDE like Visual Studio, Visual Studio Code (with C# extension), or JetBrains Rider.

2.  **Clone the repository:**
    ```bash
    git clone https://github.com/JNDEV0/ViewsExampleAspNetCore.git
    cd ViewsExampleAspNetCore
    ```

3.  **Build and Run the Project:**
    *   **Using .NET CLI:**
        ```bash
        dotnet build
        dotnet run
        ```
    *   **Using an IDE:**
        Open the `.sln` or `.csproj` file in your IDE and run the project (usually by pressing F5 or a "Run" button).

    The application will typically be accessible at `http://localhost:5000` or `https://localhost:5001` (the exact port will be shown in the terminal output).

## Usage

Once the application is running:

*   Navigate to the different routes/pages defined by the `HomeController` (or other controllers) to see various Razor view features in action.
*   Examine the `.cshtml` files in the `Views` folder and the corresponding controller actions in the `Controllers` folder to understand how the dynamic content is generated and how C# interacts with HTML.
*   Pay attention to how data is passed to views and how different Razor constructs (layouts, partial views, tag helpers, etc.) are utilized.

---
This project serves as a practical guide to understanding and utilizing the power and flexibility of Razor views in ASP.NET Core for building dynamic web UIs.
