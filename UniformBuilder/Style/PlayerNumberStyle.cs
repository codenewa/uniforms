using UniformBuilder.Options;

namespace UniformBuilder.Style
{
    public class PlayerNumberStyle: BaseStyle
    {
        public bool IsOptional { get; set; }
        public string Range { get; set; }
        public Style<Location> LocationOptions { get; set; }
    }
}
