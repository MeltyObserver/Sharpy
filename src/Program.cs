using Sharpy.Models;
using Sharpy.Components;
using Sharpy.Extensions;

using BlazorStatic;
using Markdig;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions()
        .UseYamlFrontMatter()
        .UseCitations()
        .UseBootstrap()
        .UseBootstrapExtended()
        // .UseHeadingsFormatter()
        .Build();

builder.Services.AddBlazorStaticService((o) =>
{
    o.MarkdownPipeline = pipeline;
    o.OutputFolderPath = "../output";
    o.SuppressFileGeneration = true;
});

string appsettingsFile = builder.Environment.IsDevelopment() ? "appsettings.Development.json" : "appsettings.json";
IConfiguration config = new ConfigurationBuilder().AddJsonFile(appsettingsFile).Build();
UserSettings settings = config.GetRequiredSection("Settings").Get<UserSettings>()!;

builder.Services.AddSingleton(settings);

builder.Services.AddBlazorStaticContentService<PostFrontMatter>(opt =>
{
    opt.PageUrl = SiteSettings.Pages.Home;
    opt.ContentPath = Path.Combine("Content", "Posts");
});

builder.Services.AddBlazorStaticContentService<ProjectFrontMatter>(opt =>
{
    opt.PageUrl = SiteSettings.Pages.Projects;
    opt.ContentPath = Path.Combine("Content", SiteSettings.Pages.Projects);
});

var app = builder.Build();

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
app.UseBlazorStaticGenerator(shutdownApp: !app.Environment.IsDevelopment());
app.Run();
