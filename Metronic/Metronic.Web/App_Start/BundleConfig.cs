using System.Web.Optimization;

namespace Metronic
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle metronic = new StyleBundle("~/Content/Stylez");
            metronic.Include(
                "~/Content/font-open-sans.css",
                "~/Content/assets/global/plugins/font-awesome/css/font-awesome.css",
                "~/Content/assets/global/plugins/simple-line-icons/simple-line-icons.css",
                "~/Content/assets/global/plugins/bootstrap/css/bootstrap.css",
                "~/Content/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.css",
                "~/Content/assets/global/css/components-md.css",
                "~/Content/assets/global/css/plugins-md.css",
                "~/Content/assets/layouts/layout/css/layout.css",
                "~/Content/assets/layouts/layout/css/custom.css"
                );
        }
    }
}