using Markdig;
using Sharpy.Extensions.Markdigs;

namespace Sharpy.Extensions;
public static class CustomMarkdownExtensions
{
    public static MarkdownPipelineBuilder UseBootstrapExtended(this MarkdownPipelineBuilder pipeline)
    {
        pipeline.Extensions.ReplaceOrAdd<BootstrapExtended>(new BootstrapExtended());
        return pipeline;
    }
}