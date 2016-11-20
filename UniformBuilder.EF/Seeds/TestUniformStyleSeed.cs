using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Style;
using UniformBuilder.Utility;

namespace UniformBuilder.EF.Seeds
{
    public class TestUniformStyleSeed: ISeed
    {
        public void RunSeed(UniformBuilderContext context)
        {
            var uniformStyles = new List<UniformStyle>
            {
                new UniformStyle
                {
                    Id = IdGenerator.NewId(),
                    Name = "Style1",
                    Description = "Description for style 1",
                    CreateDate = DateTime.Now.AddDays(-19),
                    LastUpdateDate = DateTime.Now.AddDays(-5)
                },
                new UniformStyle
                {
                    Id = IdGenerator.NewId(),
                    Name = "Style2",
                    Description = "Description for style 2",
                    CreateDate = DateTime.Now.AddDays(-19),
                    LastUpdateDate = DateTime.Now.AddDays(-5)
                },
                new UniformStyle
                {
                    Id = IdGenerator.NewId(),
                    Name = "Style31",
                    Description = "Description for style 31",
                    CreateDate = DateTime.Now.AddDays(-19),
                    LastUpdateDate = DateTime.Now.AddDays(-5)
                },
            };
            context.AddOrUpdate<UniformStyle>(us=>us.Id, uniformStyles);

        }
    }
}
