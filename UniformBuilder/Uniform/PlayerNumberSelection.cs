using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Options;

namespace UniformBuilder.Uniform
{
    public class PlayerNumberSelection
    {
        public virtual Guid Id { get; set; }
        public virtual int Number { get; set; }
        public virtual Location Location { get; set; }
        public virtual ApplicationType ApplicationType { get; set; }
        public virtual Color Color { get; set; }
        public virtual Font Font { get; set; }
        public virtual FontSize FontSize { get; set; }
    }
}
