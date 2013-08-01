 

namespace System.Web.Mvc
{
    public static class MVCStronglyTypedViews
    {
 
        public static Areas Areas = new Areas();
      
        public static StronglyTypedViews.Account Account = new StronglyTypedViews.Account();
      
        public static StronglyTypedViews.Shared Shared = new StronglyTypedViews.Shared();
    }

 
    public class Areas
    {
        public  AdministrationClass Administration = new AdministrationClass();
    }

     public class AdministrationClass
    {
        public StronglyTypedViews.Areas.Administration.Management Management = new StronglyTypedViews.Areas.Administration.Management();
    }   
           
}


 
