using BillyGameCenter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<ServerRequestMiddleware>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Before Environment Check Start-----\n");
    await context.Response.WriteAsync($"Before Environment Check {context.Request} \n");
    await next();
    await context.Response.WriteAsync("Before Environment Check End-----\n");
});


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Before Routing Check Start-----\n");
    await context.Response.WriteAsync($"Before Routing Check {context.Request}\n");
    await next();
    await context.Response.WriteAsync("Before Routing Check End-----\n");
});
app.UseMiddleware<ServerRequestMiddleware>();

app.UseRouting();

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Just Run Before Authorization \n");
});
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();