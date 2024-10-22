var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/about", () => "About Page");
app.MapGet("/contact", () => "Contact Page");
app.MapGet("/product/{id}", (int id) => $"Product ID: {id}");

app.Run();
