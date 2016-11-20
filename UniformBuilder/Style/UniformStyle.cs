using System;
using UniformBuilder.Options;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.Style
{
    public class UniformStyle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Sport Sport { get; set; }
        public ColorConfiguration BodyColorConfiguration { get; set; }
        public ColorConfiguration InsertsColorConfiguration { get; set; }
        public bool IsAvailable { get; set; }
        public TeamNameStyleConfiguration TeamNameStyle { get; set; }
        public PlayerNumberStyle PlayerNumberStyle { get; set; }
        public PlayerNameStyle PlayerNameStyle { get; set; }
        
    }
}
