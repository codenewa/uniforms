using System;

namespace UniformBuilder.Style.Configuration
{
    public abstract class AConfiguration
    {
        public Guid Id { get; set; }
        public bool IsConfigurable { get; set; }
    }
}
