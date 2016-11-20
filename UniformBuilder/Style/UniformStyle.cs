using System;
using UniformBuilder.Options;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.Style
{
    public class UniformStyle
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual ColorConfiguration BodyColorConfiguration { get; set; }
        public virtual ColorConfiguration InsertsColorConfiguration { get; set; }
        public virtual bool IsAvailable { get; set; }
        public virtual TeamNameStyleConfiguration TeamNameStyle { get; set; }
        public virtual PlayerNumberStyle PlayerNumberStyle { get; set; }
        public virtual PlayerNameStyle PlayerNameStyle { get; set; }
        
    }
}
