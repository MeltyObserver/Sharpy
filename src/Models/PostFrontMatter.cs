namespace Sharpy.Models;

public class PostFrontMatter : BaseFrontMatter
{
    public string? Author { get; set; }
    public bool IsPinned { get; set; }
}