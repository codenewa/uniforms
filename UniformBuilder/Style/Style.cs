using System.Collections.Generic;

namespace UniformBuilder.Style
{
    public class Style<T>
    {
        public IList<T> Options { get; set; }
        public bool IsConfigurable { get; set; }
    }
}
