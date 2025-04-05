using Microsoft.AspNetCore.Rewrite;

namespace Combi.Web.Middleware
{
    public class Rewrites
    {
        public static void DoNotRedirectFilesOrApi(RewriteContext context)
        {
            var request = context.HttpContext.Request;
            var fileProvider = context.StaticFileProvider;
            if (request.Path.StartsWithSegments(new PathString("/api")) ||
                fileProvider.GetFileInfo(request.Path).Exists)
            {
                context.Result = RuleResult.SkipRemainingRules;
            }
        }
    }
}
