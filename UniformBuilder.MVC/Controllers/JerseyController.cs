using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Kendo.Mvc.Extensions;
using UniformBuilder.MVC.Features.Uniform;

namespace UniformBuilder.MVC.Controllers
{
    public class JerseyController : Controller
    {
        [HttpGet]
        [Route("GetNewJersey/{id}")]
        public ActionResult GetNewJersey(string id)
        {
            var styleId = Guid.Parse(id);
            using (var context = new UniformBuilder.EF.UniformBuilderContext())
            {
                var manager = new JerseyManager(context);
                return View(manager.CreateNewJersey(styleId));
            }
        }
    }
}