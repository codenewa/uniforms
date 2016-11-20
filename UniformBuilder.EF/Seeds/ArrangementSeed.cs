using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Options;
using UniformBuilder.Utility;

namespace UniformBuilder.EF.Seeds
{
    public class ArrangementSeed: ISeed
    {
        public void RunSeed(UniformBuilderContext context)
        {
            IList<Arrangement> arrangements = new List<Arrangement>();
            arrangements.Add(new Arrangement
            {
                Id = IdGenerator.NewId(),
            });
        }
    }
}
