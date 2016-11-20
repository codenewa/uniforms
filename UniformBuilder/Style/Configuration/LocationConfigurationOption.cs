using System;
using System.Collections.Generic;
using UniformBuilder.Options;

namespace UniformBuilder.Style.Configuration
{
    public class LocationConfigurationOption : AConfigurationOption
    {
        public virtual Location Location { get; set; }
        public virtual FontSizeConfiguration LocationFontSizeConfiguration { get; set; }
    }
}
