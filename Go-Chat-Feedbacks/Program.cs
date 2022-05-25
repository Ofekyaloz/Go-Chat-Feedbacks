using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Go_Chat_Feedbacks.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Go_Chat_FeedbacksContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Go_Chat_FeedbacksContext") ?? throw new InvalidOperationException("Connection string 'Go_Chat_FeedbacksContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Feedbacks}/{action=Index}/{id?}");

app.Run();
