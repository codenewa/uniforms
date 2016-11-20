using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.EF;
using UniformBuilder.Utility;
using Domain = UniformBuilder.Style;

namespace UniformBuilder.MVC.Features.UniformStyle
{
    public class UniformStylesManager : AFeatureManager
    {
        public UniformStylesManager(UniformBuilderContext context) : base(context) { }

        public IList<Domain.UniformStyle> GetAllUniformStyles()
        {
            return new List<Domain.UniformStyle>
            {
                new Domain.UniformStyle
                {
                    Id = IdGenerator.NewId(),
                    Name = "Style1",
                    Description = "Description for style 1",
                    CreateDate = DateTime.Now.AddDays(-19),
                    LastUpdateDate = DateTime.Now.AddDays(-5)
                },
                new Domain.UniformStyle
                {
                    Id = IdGenerator.NewId(),
                    Name = "Style2",
                    Description = "Description for style 2",
                    CreateDate = DateTime.Now.AddDays(-19),
                    LastUpdateDate = DateTime.Now.AddDays(-5)
                },
                new Domain.UniformStyle
                {
                    Id = IdGenerator.NewId(),
                    Name = "Style31",
                    Description = "Description for style 31",
                    CreateDate = DateTime.Now.AddDays(-19),
                    LastUpdateDate = DateTime.Now.AddDays(-5)
                },
            };
            //return DataContext.UniformStyles.ToList();
        }
    }
}