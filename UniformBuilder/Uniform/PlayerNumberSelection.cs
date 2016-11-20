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
        public Guid Id { get; set; }
        public int Number { get; set; }
        public Location Location { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public Color Color { get; set; }
        public Font Font { get; set; }
        public FontSize FontSize { get; set; }
    }
}
