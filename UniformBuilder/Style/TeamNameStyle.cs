using System.Collections.Generic;

namespace UniformBuilder.Style
{
    public class TeamNameStyleConfiguration : BaseStyle
    {
        public virtual int MaxLength { get; set; }
        public virtual bool IsOptional { get; set; }
        public virtual bool AllowLine2 { get; set; }
        public virtual int Line2MaxLength { get; set; }
        public virtual bool ProvideArrangementOptions { get; set; }

    }
}
