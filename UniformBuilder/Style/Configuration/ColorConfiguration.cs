using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class ColorConfiguration: AConfiguration
    {
        public IList<ColorConfigurationOption> Colors { get; set; }
    }
}
