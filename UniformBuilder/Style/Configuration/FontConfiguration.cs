using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class FontConfiguration: AConfiguration
    {
        public virtual IList<FontSizeConfigurationOption> Fonts { get; set; }
    }
}
