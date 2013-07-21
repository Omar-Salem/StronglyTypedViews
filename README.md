StronglyTypedViews
==================

Avoid runtime error "The model item passed into the dictionary is of type ‘X’ but this dictionary requires a model item of type ‘Y‘".

The template generates truly strongly typed views to use in your controllers with zero configuration.

_Partial.cshtml
	
	@model int
	<p>@Model</p>

Generated Actions:

        using System.Web.Mvc;
        
        namespace StronglyTypedViews
        {
            public class Home : Controller
            {
                public ViewResult _Partial(int model)
                {
                    return View("~/Views/Home/_Partial.cshtml", (object)model);
                }
            }
        }

Generated Html helper extensions:

	public static void _Partial(this HtmlHelper helper, int model)
	{
		helper.RenderPartial("~/Views/Home/_Partial.cshtml", (object)model);
	}
Usage:
In controllers:

        public virtual ViewResult GetNumber()
        {
            return new StronglyTypedViews.Home()._Partial(16);
        }
        
In views:

	    @{
	        Html._Partial(100);
	    }
