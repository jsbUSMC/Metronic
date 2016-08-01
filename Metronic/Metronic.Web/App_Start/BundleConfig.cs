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

            ScriptBundle libScripts = new ScriptBundle("~/Scripts/Libs");
            libScripts.Include(
                "~/Scripts/pace.js",
                "~/Scripts/rsvp.js",
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/jquery-ui-i18n.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.blockUI.js",
                "~/Scripts/jquery.cookie.js",
                "~/Scripts/jquery.json.js",
                "~/Scripts/jquery.autoNumeric.js",
                "~/Scripts/jquery.colorbox.js",
                "~/Scripts/jquery.dialogextendQ.js",
                "~/Scripts/jquery.event.drag.js",
                "~/Scripts/jquery.scrollintoview.js",
                "~/Scripts/jsrender.js",
                "~/Scripts/select2.js",
                "~/Scripts/sortable.js",
                "~/Scripts/toastr.js",
                "~/Scripts/SlickGrid/slick.core.js",
                "~/Scripts/SlickGrid/slick.grid.js",
                "~/Scripts/SlickGrid/slick.groupitemmetadataprovider.js",
                "~/Scripts/SlickGrid/Plugins/slick.autotooltips.js",
                "~/Scripts/SlickGrid/Plugins/slick.headerbuttons.js",
                "~/Scripts/SlickGrid/Plugins/slick.rowselectionmodel.js",
                "~/Scripts/SlickGrid/Plugins/slick.rowmovemanager.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/Saltarelle/mscorlib.js",
                "~/Scripts/Saltarelle/linq.js",
                "~/Scripts/Serenity/Serenity.CoreLib.js",
                "~/Scripts/Serenity/Serenity.Script.UI.js",
                "~/Scripts/Serenity/Serenity.Externals.js",
                "~/Scripts/Serenity/Serenity.Externals.Slick.js",
                "~/Scripts/jquery.cropzoom.js",
                "~/Scripts/jquery.fileupload.js",
                "~/Scripts/jquery.iframe-transport.js",
                "~/Scripts/jquery.slimscroll.js",
                "~/Scripts/mousetrap.js",
                "~/Scripts/fastclick/fastclick.js",
                "~/Content/assets/global/plugins/js.cookie.min.js",
                "~/Content/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.js"
            );

            ScriptBundle siteScripts = new ScriptBundle("~/Scripts/SiteScripts");
            siteScripts.Include(
                "~/Scripts/Site/Metronic.Script.js",
                "~/Scripts/Site/Metronic.Web.js",
                "~/Content/assets/global/scripts/app.js",
                "~/Content/assets/layouts/layout/scripts/layout.js",
                "~/Content/assets/layouts/layout/scripts/demo.js",
                "~/Content/assets/layouts/global/scripts/quick-sidebar.js"
            );

            ScriptBundle metronicSiteScripts = new ScriptBundle("~/Scripts/MetronicSiteScripts");
            metronicSiteScripts.Include(
                "~/Content/assets/global/scripts/app.js",
                "~/Content/assets/layouts/layout/scripts/layout.js",
                "~/Content/assets/layouts/layout/scripts/demo.js",
                "~/Content/assets/layouts/global/scripts/quick-sidebar.js"
            );

            bundles.Add(metronic);
            bundles.Add(libScripts);
            bundles.Add(metronicSiteScripts);

            BundleTable.EnableOptimizations = true;
        }
    }
}