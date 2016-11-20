using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class FontSizeConfiguration: AConfiguration
    {
        public IList<FontSizeConfigurationOption> FontSizes { get; set; }
    }
}
