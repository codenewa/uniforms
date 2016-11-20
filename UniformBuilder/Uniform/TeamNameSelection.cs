using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Options;

namespace UniformBuilder.Uniform
{
    public class TeamNameSelection
    {
        public virtual Guid Id { get; set; }
        public virtual string Name1 { get; set; }
        public virtual string Name2 { get; set; }
        public virtual ApplicationType ApplicationType { get; set; }
        public virtual Color Color { get; set; }
        public virtual Font Font { get; set; }
        public virtual FontSize FontSize { get; set; }
        public virtual Arrangement Arrangement { get; set; }
    }
}
