var builder = WebApplication.CreateBuilder(args);

//adding Controllers and Views to builder.Services
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();

//now with views AND controllers added, the routing sitpulated in the Controller classes, in this example Controllers/HomeController.cs, will determine which files are fetched from the Views folder
app.MapControllers(); 

app.Run();
