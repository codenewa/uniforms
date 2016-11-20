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
        public virtual Guid Id { get; set; }
        public virtual NamePlateType NamePlateType { get; set; }
        public virtual Color Color { get; set; }
    }
}
