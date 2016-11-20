using System;
using UniformBuilder.Options;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.Style
{
    public class NamePlateStyle
    {
        public Guid Id { get; set; }
        public NamePlateTypeConfiguration Configuration { get; set; }
        public ColorConfiguration ColorConfiguration { get; set; }
    }
}
