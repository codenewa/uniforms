using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using Kendo.Mvc.Extensions;
using UniformBuilder.EF;
using UniformBuilder.Uniform;
using UniformBuilder.Utility;

namespace UniformBuilder.MVC.Features.Uniform
{
    public class JerseyManager : AFeatureManager
    {
        public JerseyManager(UniformBuilderFactory factory) : base(factory)
        {
        }

        public JerseyBuilder CreateNewJersey(Guid uniformStyleId)
        {
            UniformStyleRepository repos = Factory.GetUniformStyleRepository(DataContext);
            var style = repos.Find(uniformStyleId);

            return Factory.CreateNewJersey(style);
        }

        public void SaveJersey(JerseyBuilder jerseyBuilder)
        {
            Jersey jersey = new Jersey().Create(jerseyBuilder.Name, jerseyBuilder.Description,
                jerseyBuilder.Identifier, null, null, null, null, null, null, jerseyBuilder.UniformStyleId);
            UniformRepository repo = Factory.GetUniformRepository(DataContext);
            repo.Add(jersey);
            repo.Save();
        }

        public IList<JerseyView> GetAllJerseysForStyleId(Guid styleId)
        {
            UniformStyleRepository repos = Factory.GetUniformStyleRepository(DataContext);
            var style = repos.Find(styleId);

            var repo = Factory.GetUniformRepository(DataContext);
            return repo.Query().Where(jersey => jersey.UniformStyleId == styleId)
                .Select(jersey => new JerseyView
                {
                    Id = jersey.Id,
                    Name = jersey.Name,
                    Description = jersey.Description,
                    Identifier = jersey.Identifier,
                    StyleName = style.Name,
                    StyleId = style.Id
                }).ToList();
        }
    }
}