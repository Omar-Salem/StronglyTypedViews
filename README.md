StronglyTypedViews
==================

Avoid runtime error "The model item passed into the dictionary is of type ‘X’ but this dictionary requires a model item of type ‘Y‘".

The template generates truly strongly typed views to use in your controllers with zero configuration.

Only C# is supported for now.

The template discovers referenced namespaces in .cshtml files, base types (int, bool, String, etc..) and user made classes will work without configuration.

If the template gives build errors due to undiscovered namespaces,either:

1-Write the fully qualified name of the model to the view(i.e: @model System.Web.UI.HtmlTextWriter)

2-Add the required namespace to the template, line 232.

	IEnumerable<string> usings = new string[]
	                    {
	                    "System",
	                    "System.Web.Mvc",
	                    "System.Collections",
	                    "System.Collections.Generic",
	                    "System.IO",
	                    "System.Text",
	                    "System.Xml"
	                    };
Input view
==================

_Partial.cshtml
	
	@model int
	<p>@Model</p>

Output files
==================

Generated actions:

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
Usage
==================
In controllers:

        public virtual ViewResult GetNumber()
        {
            return new StronglyTypedViews.Home()._Partial(16);
        }
        
In views:

	    @{
	        Html._Partial(100);
	    }
