using System.Web;
using System.Web.Optimization;

namespace Technical_Assessment
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/CSS_And_Script_File/css").Include(
                "~/Content/themes/base/jquery-ui.css",
                "~/CSS_And_Script_File/Bootstrap_Studio/css/bootstrap.min.css",
                //"~/CSS_And_Script_File/Bootstrap/Bootstrap-4.3.1/css/bootstrap.css",
                "~/CSS_And_Script_File/jQuery_DataTables/css/jquery.dataTables.css",
                "~/CSS_And_Script_File/Animation/css/Animate.css",
                "~/CSS_And_Script_File/IHover/css/ihover.css",
                "~/CSS_And_Script_File/SweetAlert/css/sweetalert2.css",
                "~/CSS_And_Script_File/Bootstrap_Studio/fonts/fontawesome-all.min.css",
                "~/CSS_And_Script_File/jQuery_DataTables/TableTools_2.2.4/css/dataTables.tableTools.css",
                "~/CSS_And_Script_File/Bootstrap_Studio/fonts/ionicons.min.css"
                ));

            bundles.Add(new ScriptBundle("~/CSS_And_Script_File/script").Include(
                //"~/CSS_And_Script_File/jQuery/js/jquery-3.4.1.js",
                "~/CSS_And_Script_File/Bootstrap_Studio/js/jquery.min.js",
                "~/CSS_And_Script_File/jQuery_Validate/js/jquery.validate.js",
                "~/CSS_And_Script_File/jQuery_Validate/js/jquery.validate.unobtrusive.js",
                "~/CSS_And_Script_File/jQuery_UI/js/jquery-ui-1.12.1.js",     // ai ta aikhane kaj kore na.
                "~/CSS_And_Script_File/Ajax/js/jquery.unobtrusive-ajax.min.js",
                "~/CSS_And_Script_File/jQuery_CountTo/js/jquery.countTo.js",
                "~/CSS_And_Script_File/jQuery_DataTables/js/jquery.dataTables.js",
                "~/CSS_And_Script_File/Popper/js/popper.js",
                "~/CSS_And_Script_File/AngularJS/js/Angular.js",
                "~/CSS_And_Script_File/SweetAlert/js/sweetalert2.all.js",
                "~/CSS_And_Script_File/SweetAlert/js/sweetalert_old.min.js",
                "~/CSS_And_Script_File/Bootstrap_Studio/js/bootstrap.min.js",
                //"~/CSS_And_Script_File/Bootstrap/Bootstrap-4.3.1/js/bootstrap.js",
                "~/CSS_And_Script_File/jQuery_DataTables/TableTools_2.2.4/js/dataTables.tableTools.js"
                ));
        }
    }
}
