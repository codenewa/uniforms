using System;
using UniformBuilder.Options;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.Style
{
    public abstract class BaseStyle
    {
        public virtual Guid Id { get; set; }
        public virtual ApplicationTypeConfiguration ApplicationTypeConfiguration { get; set; }
        public virtual FontConfiguration FontConfiguration { get; set; }
        public virtual ColorConfiguration ColorConfiguration { get; set; }
        public virtual FontSizeConfiguration FontSizeConfiguration { get; set; }
        public virtual ArrangementConfiguration ArrangementConfiguration { get; set; }
    }
}
