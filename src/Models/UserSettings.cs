namespace Sharpy.Models;

public class UserSettings
{
    public required string Title { get; set; }
    public string Description { get; set; } = "Chirpy clone made in blazor";
    public string Image { get; set; } = "https://avatars.githubusercontent.com/u/164113402?v=4";
    public List<SocialMedia?>? SocialMedias { get; set; }
    public string DefaultTheme { get; set; } = "dark";
    public bool UseLocalAssets { get; set; } = false;
}

public class SocialMedia
{
    public string? Name { get; set; }
    public string? Link { get; set; }
    public string? BootstrapIconClass { get; set; }
}