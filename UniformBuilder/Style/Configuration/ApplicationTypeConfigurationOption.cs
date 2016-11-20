using System;
using UniformBuilder.Options;

namespace UniformBuilder.Style.Configuration
{
    public class ApplicationTypeConfigurationOption: AConfigurationOption
    {
        public virtual ApplicationType ApplicationType { get; set; }
    }
}
