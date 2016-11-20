using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Style;
using UniformBuilder.Uniform;

namespace UniformBuilder.EF
{
    public class UniformRepository: Repository<Jersey>
    {
        public UniformRepository(UniformBuilderContext uniformBuilderContext) : base(uniformBuilderContext)
        {
        }
    }
}
