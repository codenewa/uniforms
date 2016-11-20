using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.EF;

namespace UniformBuilder.MVC.Features
{
    public abstract class AFeatureManager
    {
        protected UniformBuilderContext DataContext { get; }

        protected AFeatureManager(UniformBuilderContext context)
        {
            DataContext = context;
        }
    }
}