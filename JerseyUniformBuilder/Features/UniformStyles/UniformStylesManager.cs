using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.EF;
using UniformBuilder.Style;

namespace JerseyUniformBuilder.Features.UniformStyles
{
    public class UniformStylesManager : FeatureManager
    {
        public UniformStylesManager(UniformBuilderContext context) : base(context) { }

        public IList<UniformStyle> GetAllUniformStyles()
        {
            return DataContext.UniformStyles.ToList();
        }

    }
}