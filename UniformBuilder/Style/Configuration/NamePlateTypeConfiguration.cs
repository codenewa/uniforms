using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class NamePlateTypeConfiguration: AConfiguration
    {
        public virtual IList<NamePlateTypeConfigurationOption> NamePlateTypes { get; set; }
    }
}
