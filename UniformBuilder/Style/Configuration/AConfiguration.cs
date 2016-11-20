using System;

namespace UniformBuilder.Style.Configuration
{
    public abstract class AConfiguration
    {
        public virtual Guid Id { get; set; }
        public virtual bool IsConfigurable { get; set; }
    }
}
