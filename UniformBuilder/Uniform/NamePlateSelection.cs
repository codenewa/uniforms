using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Options;

namespace UniformBuilder.Uniform
{
    public class NamePlateSelection
    {
        public Guid Id { get; set; }
        public NamePlateType NamePlateType { get; set; }
        public Color Color { get; set; }
    }
}
