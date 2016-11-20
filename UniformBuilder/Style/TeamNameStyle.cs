using System.Collections.Generic;

namespace UniformBuilder.Style
{
    public class TeamNameStyleConfiguration : BaseStyle
    {
        public int MaxLength { get; set; }
        public bool IsOptional { get; set; }
        public bool AllowLine2 { get; set; }
        public int Line2MaxLength { get; set; }
        public bool ProvideArrangementOptions { get; set; }

    }
}
