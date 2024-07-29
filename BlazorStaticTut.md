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
$ echo "output/" >> .gitignore
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
        - css/
        - js/

    + Program.cs
```

### bootstrap

delete the bundled bootstrap `wwwroot/bootstrap` (usually slightly old version) and add this in `App.razor`

```html
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous" suppress-error="BL9992"></script>

<!-- https://getbootstrap.com/docs/5.3/customize/color-modes/#javascript -->
<script src="js/color-modes.js" suppress-error="BL9992"></script>
```
