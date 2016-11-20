using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class ColorConfiguration: AConfiguration
    {
        public virtual IList<ColorConfigurationOption> Colors { get; set; }
    }
}
