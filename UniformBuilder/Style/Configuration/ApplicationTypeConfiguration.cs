using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class ApplicationTypeConfiguration : AConfiguration
    {
        public IList<ApplicationTypeConfigurationOption> Options { get; set; }
    }
}
