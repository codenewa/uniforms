using System;
using System.Web.Helpers;
using UniformBuilder.EF;
using UniformBuilder.Utility;

namespace UniformBuilder.MVC.Features.Uniform
{
    public class JerseyManager: AFeatureManager
    {
        public JerseyManager(UniformBuilderContext context) : base(context)
        {
        }

        public JerseyBuilder CreateNewJersey(Guid uniformStyleId)
        {
            UniformStyleRepository repos = new UniformStyleRepository(DataContext);
            var style = repos.Find(uniformStyleId);

            return new JerseyBuilder
            {
                Name = "Some jersey",
                Description = "Description",
                Identifier = "Identifier",
                Id = IdGenerator.NewId(),
                UniformStyle = Json.Encode(style)
            };
        }
    }
}