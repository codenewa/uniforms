using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class LocationConfiguration: AConfiguration
    {
        public virtual IList<LocationConfigurationOption> Locations { get; set; }
    }
}
