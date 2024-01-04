using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ionasca_Tabita_Lab2_3_.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Ionasca_Tabita_Lab2_3_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ionasca_Tabita_Lab2_3_Context") ?? throw new InvalidOperationException("Connection string 'Ionasca_Tabita_Lab2_3_Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
