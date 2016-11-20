using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniformBuilder.MVC.Features.Uniform
{
    public class JerseyBuilder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }

        public string UniformStyle { get; set; }
    }
}