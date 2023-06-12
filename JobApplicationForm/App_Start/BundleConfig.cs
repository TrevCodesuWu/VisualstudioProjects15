using System.Web;
using System.Web.Optimization;

namespace JobApplicationForm
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/bootstrap.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js",

                        "~/scripts/datatables/buttons.bootstrap.js",
                        "~/scripts/datatables/buttons.colVis.js",
                        "~/scripts/datatables/buttons.flash.js",
                        "~/scripts/datatables/buttons.foundation.js",
                        "~/scripts/datatables/buttons.html5.js",
                        "~/scripts/datatables/buttons.jqueryui.js",
                        "~/scripts/datatables/buttons.print.js",

                      "~/Scripts/bootbox.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery-{version}.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/datatables/css/datatables.bootstrap.css",

                      "~/Content/datatables/swf/flashExport.swf",
                      "~/Content/datatables/css/buttons.bootstrap.css",
                      "~/Content/datatables/css/buttons.dataTables.css",
                      "~/Content/datatables/css/buttons.foundation.css",
                      "~/Content/datatables/css/buttons.jqueryui.css",

                      "~/Content/Site.css"));
        }
    }
}
