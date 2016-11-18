using System.Web.Optimization;

namespace PlaningPokerRnd
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                    "~/Scripts/angular.min.js",
                    "~/Scripts/angular-route.min.js",
                    "~/Scripts/angular-validator.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/Materialize/materialize.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/Materialize").Include(
                 "~/Content/Materialize/materialize.css"));
        }
    }
}
