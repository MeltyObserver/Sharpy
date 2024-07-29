a guide to replicate Sharpy

# Prep

*Requires .Net 8 at least*

```shell
$ dotnet new blazor -o SharpyTut
# or you can install the nuget
$ git submodule add https://github.com/tesar-tech/BlazorStatic.git BlazorStatic
$ dotnet add SharpyTut/SharpyTut.csproj reference BlazorStatic/src/BlazorStatic.csproj 
```

Program.cs

```cs
using BlazorStatic;
//...
builder.Services.AddBlazorStaticService();
//...
app.UseBlazorStaticGenerator();
```

```shell
# output folder shouldn't be tracked
$ echo "output" >> .gitignore
$ dotnet run --project SharpyTut
```

site's folder structure:

```
- src
    - Components/
        - Pages/
            + About.razor
            + Home.razor
            + Post.razor

        - Layouts/
            + MainLayout.razor

        - Fragments/
            + SideBar.razor
            + Footer.razor

        + App.razor
        + Routes.razor
        + Program.cs

    - wwwroot/
    + Program.cs
```
