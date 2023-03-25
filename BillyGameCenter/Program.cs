using BillyGameCenter;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//註冊WebImages folder
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "wwwroot/home")),
    RequestPath = "/home"
});


// app.Use(async (context, next) =>
// {
//     await context.Response.WriteAsync("Before Routing Check Start-----\n");
//     await context.Response.WriteAsync($"Before Routing Check {context.Request}\n");
//     await next();
//     await context.Response.WriteAsync("Before Routing Check End-----\n");
// });

// app.Run(async (context) =>
// {
//     await context.Response.WriteAsync("Just Run Before Authorization \n");
// });

// app.UseMiddleware<ServerRequestMiddleware>();
app.UseRouting();

app.UseAuthorization();

app.MapHealthChecks("admin/health");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();