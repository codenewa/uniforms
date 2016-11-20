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
        public Guid Id { get; set; }
        public NamePlateSelection NamePlate { get; set; }
        public string Name { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public Color Color { get; set; }
        public Font Font { get; set; }
        public FontSize FontSize { get; set; }
    }
}
