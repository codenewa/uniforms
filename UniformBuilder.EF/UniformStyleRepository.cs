using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Style;

namespace UniformBuilder.EF
{
    public class UniformStyleRepository: Repository<UniformStyle>
    {
        public UniformStyleRepository(UniformBuilderContext uniformBuilderContext) : base(uniformBuilderContext)
        {
        }
    }
}
