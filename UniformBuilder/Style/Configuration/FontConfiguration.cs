using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class FontConfiguration: AConfiguration
    {
        public IList<FontSizeConfigurationOption> Fonts { get; set; }
    }
}
