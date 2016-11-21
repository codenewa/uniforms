using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniformBuilder.EF;
using UniformBuilder.MVC.Features.Uniform;
using UniformBuilder.Utility;

namespace UniformBuilder.MVC.Features
{
    public class UniformBuilderFactory: IDisposable
    {
        private UniformBuilderContext _context;
        public virtual UniformBuilderContext GetDataContext()
        {
            return _context ?? (_context = new UniformBuilderContext());
        }

        public virtual UniformStyleRepository GetUniformStyleRepository(UniformBuilderContext context)
        {
            return new UniformStyleRepository(context);
        }

        public virtual UniformRepository GetUniformRepository(UniformBuilderContext context)
        {
            return new UniformRepository(context);
        }

        public virtual JerseyBuilder CreateNewJersey(Style.UniformStyle style)
        {
             return new JerseyBuilder
            {
                Name = "",
                Description = "",
                Identifier = "",
                Id = IdGenerator.NewId(),
                UniformStyleId = style.Id,
                StyleName = style.Name
            };
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}