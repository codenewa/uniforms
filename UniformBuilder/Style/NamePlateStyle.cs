using System;
using UniformBuilder.Options;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.Style
{
    public class NamePlateStyle
    {
        public virtual Guid Id { get; set; }
        public virtual NamePlateTypeConfiguration Configuration { get; set; }
        public virtual ColorConfiguration ColorConfiguration { get; set; }
    }
}
