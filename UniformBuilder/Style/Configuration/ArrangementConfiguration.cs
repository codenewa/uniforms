using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class ArrangementConfiguration: AConfiguration
    {
        public virtual IList<ArrangementConfigurationOption> Arrangements { get; set; }
    }
}
