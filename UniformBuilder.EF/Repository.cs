using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Uniform;

namespace UniformBuilder.EF
{
    public class Repository<T> where T:class
    {
        private UniformBuilderContext DataContext { get; }

        protected Repository(UniformBuilderContext uniformBuilderContext)
        {
            DataContext = uniformBuilderContext;
        }

        public T Find(Guid id) 
        {
            return DataContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            DataContext.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            DataContext.Set<T>().Remove(entity);
        }

        public IList<T> All()
        {
            return DataContext.Set<T>().ToList();
        }

        public IQueryable<T> Query()
        {
            return DataContext.Set<T>() as IQueryable<T>;
        }

        public void Save()
        {
            if(DataContext.ChangeTracker.HasChanges())
                DataContext.Save();
        }
    }
}
