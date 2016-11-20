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
            return DataContext.UniformStyles.ToList();
        }
    }
}