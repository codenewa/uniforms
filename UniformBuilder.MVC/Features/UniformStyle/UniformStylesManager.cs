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
        public UniformStylesManager(UniformBuilderFactory factory) : base(factory) { }

        public IList<Domain.UniformStyle> GetAllUniformStyles()
        {
            var repo = new UniformStyleRepository(DataContext);
            return repo.All();
        }
    }
}