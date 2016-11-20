using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Options;

namespace UniformBuilder.Uniform
{
    public class Jersey
    {
        public Guid Id { get; set; }
        public Color BodyColor { get; set; }
        public Color InsertsColor { get; set; }
        public TeamNameSelection TeamName { get; set; }
        public PlayerNameSelection PlayerName { get; set; }
        public PlayerNumberSelection PlayerNumber { get; set; }
        
    }
}
