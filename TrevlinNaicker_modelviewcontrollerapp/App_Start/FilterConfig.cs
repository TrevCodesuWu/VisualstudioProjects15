using System.Web;
using System.Web.Mvc;

namespace TrevlinNaicker_modelviewcontrollerapp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
