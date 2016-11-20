using System;
using UniformBuilder.Options;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.Style
{
    public abstract class BaseStyle
    {
        public Guid Id { get; set; }
        public ApplicationTypeConfiguration ApplicationTypeConfiguration { get; set; }
        public FontConfiguration FontConfiguration { get; set; }
        public ColorConfiguration ColorConfiguration { get; set; }
        public FontSizeConfiguration FontSizeConfiguration { get; set; }
        public ArrangementConfiguration ArrangementConfiguration { get; set; }
    }
}
