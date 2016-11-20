using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformBuilder.EF.Seeds
{
    interface ISeed
    {
        void RunSeed(UniformBuilderContext context);
    }
}
