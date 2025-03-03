using NameCraft.Models;
using NameCraft.Services;

var builder = WebApplication.CreateBuilder(args);

// Загрузка словарей
var wordBank = new WordBank();
wordBank.LoadWords(builder.Environment);

// Регистрация сервисов
builder.Services.AddSingleton(wordBank);
builder.Services.AddScoped<NicknameGenerator>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
