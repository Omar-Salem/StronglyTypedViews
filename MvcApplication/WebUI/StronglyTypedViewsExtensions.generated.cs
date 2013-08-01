using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    public static partial class StronglyTypedViewsExtensions
    {
        public static void RenderPartial(this HtmlHelper helper, ViewResult viewResult)
        {
            helper.RenderPartial(viewResult.ViewName, viewResult.Model);
        }

        public static MvcHtmlString Partial(this HtmlHelper helper, ViewResult viewResult)
        {
            return helper.Partial(viewResult.ViewName, viewResult.Model);
        }
    }
}
