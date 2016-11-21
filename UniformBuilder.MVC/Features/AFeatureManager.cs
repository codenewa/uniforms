using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.EF;

namespace UniformBuilder.MVC.Features
{
    public abstract class AFeatureManager
    {
        protected UniformBuilderFactory Factory { get; }
        protected UniformBuilderContext DataContext { get; }

        protected AFeatureManager(UniformBuilderFactory factory)
        {
            Factory = factory;
            DataContext = Factory.GetDataContext();
        }
    }
}