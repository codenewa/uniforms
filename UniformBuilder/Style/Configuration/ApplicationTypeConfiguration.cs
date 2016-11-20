using System.Collections.Generic;

namespace UniformBuilder.Style.Configuration
{
    public class ApplicationTypeConfiguration : AConfiguration
    {
        public virtual IList<ApplicationTypeConfigurationOption> Options { get; set; }
    }
}
