using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformBuilder
{
    public class User
    {
        public Guid Id { get; set; }
        public UserType Type { get; set; }
        public string Name { get; set; }
    }
}
