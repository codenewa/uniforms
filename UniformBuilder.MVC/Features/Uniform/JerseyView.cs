using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.Style;
using UniformBuilder.Uniform;

namespace UniformBuilder.MVC.Features.Uniform
{
    public class JerseyView
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }
        public string StyleName { get; set; }
        public Guid StyleId { get; set; }
      
    }
}