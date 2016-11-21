using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using UniformBuilder.MVC.Features;
using UniformBuilder.MVC.Features.Uniform;

namespace UniformBuilder.MVC.Controllers
{
    public class JerseyController : Controller
    {
        [HttpGet]
        [Route("GetNewJersey/{id}")]
        public ActionResult GetNewJersey(string id)
        {
            Guid styleId = Guid.Parse(id);
            using (var factory = new UniformBuilderFactory())
            {
                var manager = new JerseyManager(factory);
                return View(manager.CreateNewJersey(styleId));
            }
        }

        [HttpPost]
        [Route("SaveNewJersey")]
        public ActionResult SaveJersey(JerseyBuilder builder)
        {
            using (var factory = new UniformBuilderFactory())
            {
                var manager = new JerseyManager(factory);
                manager.SaveJersey(builder);
                return Redirect("GetNewJersey/" + builder.UniformStyleId);
            }
        }

        public ActionResult GetJerseysForTheStyle([DataSourceRequest]DataSourceRequest request, string id)
        {
            Guid styleId = Guid.Parse(id);
            using (var factory = new UniformBuilderFactory())
            {
                var manager = new JerseyManager(factory);
                return Json(manager.GetAllJerseysForStyleId(styleId).ToDataSourceResult(request));
            }
        }
    }
}