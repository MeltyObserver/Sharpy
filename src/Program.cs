using Sharpy;
using BlazorStatic;
using Sharpy.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddBlazorStaticService((o) =>
{
    o.SuppressFileGeneration = true;
});

string appsettingsFile = builder.Environment.IsDevelopment() ? "appsettings.Development.json" : "appsettings.json";
IConfiguration config = new ConfigurationBuilder().AddJsonFile(appsettingsFile).Build();
AppSettings settings = config.GetRequiredSection("Settings").Get<AppSettings>()!;

builder.Services.AddSingleton(settings);

var app = builder.Build();

app.UseBlazorStaticGenerator();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
