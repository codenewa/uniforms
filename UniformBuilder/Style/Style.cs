using System.Collections.Generic;

namespace UniformBuilder.Style
{
    public class Style<T>
    {
        public virtual IList<T> Options { get; set; }
        public virtual bool IsConfigurable { get; set; }
    }
}
