using UniformBuilder.Options;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.Style
{
    public class PlayerNumberStyle: BaseStyle
    {
        public virtual bool IsOptional { get; set; }
        public virtual string Range { get; set; }
        public virtual LocationConfiguration LocationConfiguration { get; set; }
    }
}
