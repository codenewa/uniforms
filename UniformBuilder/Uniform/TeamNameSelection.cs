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
        public Guid Id { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public Color Color { get; set; }
        public Font Font { get; set; }
        public FontSize FontSize { get; set; }
        public Arrangement Arrangement { get; set; }
    }
}
