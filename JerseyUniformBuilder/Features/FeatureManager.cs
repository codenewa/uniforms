using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.EF;

namespace JerseyUniformBuilder.Features
{
    public abstract class FeatureManager
    {
        protected UniformBuilderContext DataContext { get; }

        protected FeatureManager(UniformBuilderContext context)
        {
            DataContext = context;
        }
    }
}