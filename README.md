StronglyTypedViews
==================

Avoid runtime error "The model item passed into the dictionary is of type ‘X’ but this dictionary requires a model item of type ‘Y‘".

e.g instead of:

	public ViewResult GetProduct(int id)
	{
	    return View("GetProduct", id);
	}
with StronglyTypedViews you can write

        public ViewResult GetProduct(int id)
        {
            return MVCStronglyTypedViews.Areas.Administration.Management.GetProduct(id);
        }

The template generates truly strongly typed views to use in your controllers with zero configuration.

Only C# is supported for now.

The template discovers referenced namespaces in .cshtml files, base types (int, bool, String, etc..) and user made classes will work without configuration.

If the template gives build errors due to undiscovered namespaces,either:

-Write the fully qualified name of the model to the view(i.e: @model System.Text.StringBuilder)

or

-Add the required namespace to the template, line 492.

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
Input
==================
-Areas
 -Administration
  -Views
   -Management
    -GetProduct.cshtml
	
	@model int
	<p>@Model</p>
	
How to use
==================
In controllers:

        public ViewResult GetProduct(int id)
        {
            return MVCStronglyTypedViews.Areas.Administration.Management.GetProduct(id);
        }
        
In views:

	    @{
			Html.RenderPartial(MVCStronglyTypedViews.Areas.Administration.Management.GetProduct(90)); 
	     }
