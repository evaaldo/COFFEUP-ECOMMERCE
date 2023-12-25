using Ecommerce.Context.BancosContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BancosContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoProdutos")));
builder.Services.AddDbContext<BancosContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoUsuarios")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Produtos}/{action=Index}/{id?}");

app.Run();
