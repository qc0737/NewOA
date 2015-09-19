using System.Web;
using System.Web.Optimization;

namespace AutekInfoPortal
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Content/jquery-easyui-1.4.3/jquery.js",
                      "~/Content/jquery-easyui-1.4.3/jquery.easyui.js",
                     "~/Content/jquery-easyui-1.4.3/locale/easyui-lang-zh_CN.js",
                     "~/Content/autek/js/jquery.blockUI.js"));


            bundles.Add(new ScriptBundle("~/bundles/homemenu").Include(
                      "~/Content/autek/js/homemenu.js"));

            bundles.Add(new StyleBundle("~/Content/jquery-easyui-1.4.3/themes/default/css").Include(
                    "~/Content/jquery-easyui-1.4.3/themes/default/easyui.css",
                    "~/Content/jquery-easyui-1.4.3/themes/icon.css"));
            bundles.Add(new StyleBundle("~/Content/autek/Style/css").Include(
            "~/Content/autek/Style/icon.css",
                    "~/Content/autek/Style/mycss.css"));
        }
    }
}