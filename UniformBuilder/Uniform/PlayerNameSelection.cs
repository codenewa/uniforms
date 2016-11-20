using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Options;

namespace UniformBuilder.Uniform
{
    public class PlayerNameSelection
    {
        public virtual Guid Id { get; set; }
        public virtual NamePlateSelection NamePlate { get; set; }
        public virtual string Name { get; set; }
        public virtual ApplicationType ApplicationType { get; set; }
        public virtual Color Color { get; set; }
        public virtual Font Font { get; set; }
        public virtual FontSize FontSize { get; set; }
    }
}
