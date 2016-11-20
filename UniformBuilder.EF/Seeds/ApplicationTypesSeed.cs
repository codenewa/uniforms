using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Options;
using UniformBuilder.Utility;

namespace UniformBuilder.EF.Seeds
{
    public class ApplicationTypesSeed: ISeed
    {
        public void RunSeed(UniformBuilderContext context)
        {
            IList<ApplicationType> applicationTypes = new List<ApplicationType>();
            applicationTypes.Add(new ApplicationType
            {
                Id = IdGenerator.NewId(),
                Name = "Embroidery"
            });
            applicationTypes.Add(new ApplicationType
            {
                Id = IdGenerator.NewId(),
                Name = "Tackle Twill"
            });
            applicationTypes.Add(new ApplicationType
            {
                Id = IdGenerator.NewId(),
                Name = "Sublimated"
            });
            applicationTypes.Add(new ApplicationType
            {
                Id = IdGenerator.NewId(),
                Name = "Screen Print"
            });

            context.AddOrUpdate(c=>c.Id , applicationTypes);
        }
    }
}
