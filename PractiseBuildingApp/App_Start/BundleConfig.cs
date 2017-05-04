using System.Web;
using System.Web.Optimization;

namespace PractiseBuildingApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/Template").Include(
                      "~/Scripts/easing.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/ddlevelsmenu.js",
                      "~/Scripts/flexslider.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/respond.js"));

                          bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Template/style/bootstrap.css",
                      "~/Content/Template/style/font-awesome.css",
                      "~/Content/Template/style/font-awesome-ie7.css",
                      "~/Content/Template/style/ddlevelsmenu-base.css.css",
                      "~/Content/Template/style/ddlevelsmenu-topbar.css",
                      "~/Content/Template/style/style.css",
                      "~/Content/Template/style/blue.css",
                      "~/Content/Template/style/bootstrap-responsive.css",
                      "~/Content/Template/style/flexslider.css",
                      "~/Content/Template/style/prettyPhoto.css",
                      "~/Content/Site.less"));
          
        }
    }
}
