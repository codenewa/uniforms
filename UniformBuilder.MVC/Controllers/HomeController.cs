using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using UniformBuilder.MVC.Features.UniformStyle;

namespace UniformBuilder.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetAllStyles([DataSourceRequest]DataSourceRequest request)
        {
            using (var context = new UniformBuilder.EF.UniformBuilderContext())
            {
                var manager = new UniformStylesManager(context);
                return Json(manager.GetAllUniformStyles().ToDataSourceResult(request));
            }
        }
    }
}