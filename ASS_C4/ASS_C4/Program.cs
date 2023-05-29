using Assignment.IServices;
using Assignment.Models.Data;
using Assignment.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProductsService, ProductsService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ICapacityService, CapacityService>();
builder.Services.AddTransient<ISupplierService, SupplierService>();
builder.Services.AddTransient<IUserService, UserService>();
// builder.Services.AddSingleton<IProductServices, ProductService>();
//builder.Services.AddScoped<IProductServices, ProductService>();

/*
 * AddSingleton : Neu Service duoc khoi tao , no se ton tai cho den khi vong doi cua ung dung ket thuc. Neu Cac
 * Request khac ma trien khai thi se dung lai chinh Service do. Phu hop cho ca Service co tinh toan cuc va khong thay doi.
 * AddScoped : Moi lan co HTPP Request thi se tao request mot lan va duoc giu nguyen trong qua trinh Request duoc xu ly. Loai nay
 * se duoc su dung cho cac Service voi nhung yeu cau HTTP cu the.
 * AddTransient : Tao moi Service voi moi khi Request. Voi moi yeu cau HTTP se nhan duoc mot doi tuong Service khac nhau. Phu hop cho cac
 * Service ma co the phu vu nhieu yeu cau HTTP Request.
 */

builder.Services.AddSession(c => c.IOTimeout = TimeSpan.FromSeconds(15));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    option =>
    {
        option.LoginPath = "/Home/Login";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    });

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

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.UseRouting();
app.UseSession();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
