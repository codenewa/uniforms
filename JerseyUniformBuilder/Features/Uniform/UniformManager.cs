using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.EF;

namespace JerseyUniformBuilder.Features.Uniform
{
    public class UniformManager: FeatureManager
    {
        public UniformManager(UniformBuilderContext context) : base(context){ }
    }
}