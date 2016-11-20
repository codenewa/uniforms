using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class FontSizeConfiguration: AConfiguration
    {
        public virtual IList<FontSizeConfigurationOption> FontSizes { get; set; }
    }
}
