var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(name: "{default}", pattern: "{Controller=CustomerOrder}/{Action=Index}/{id?}");

app.Run();
