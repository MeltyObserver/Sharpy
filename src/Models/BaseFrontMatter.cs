using BlazorStatic;

namespace Sharpy.Models;

public abstract class BaseFrontMatter : IFrontMatter
{
    /// <summary>
    /// Original title of the nasheed.
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// the cover image of the article
    /// </summary>
    /// <value></value>
    public string? Image { get; set; }
    /// <summary>
    /// the contributors to the article
    /// </summary>
    /// <value></value>
    public Contributor[]? Contributors { get; set; }
    public string? Description { get; set; }
    /// <inheritdoc />
    public DateTime? Published { get; set; }
    public List<string> Tags { get; set; } = [];
    public AdditionalInfo? AdditionalInfo => new() { LastMod = Published };
}

/// <summary>
/// a simple contributor class
/// </summary>
public sealed class Contributor
{
    /// <summary>
    /// name of the contributor
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Link for the contributor's social
    /// </summary>
    /// <value></value>
    public string? Link { get; set; }
    public string? Contribution { get; set; }
}
