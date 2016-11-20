using System;
using System.Linq;
using System.Reflection;
using UniformBuilder.EF.Seeds;

namespace UniformBuilder.EF.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<UniformBuilder.EF.UniformBuilderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniformBuilderContext context)
        {
            var seeds = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetInterfaces().Contains(typeof(ISeed))
                        select Activator.CreateInstance(t) as ISeed;

            foreach (var seed in seeds)
            {
                seed.RunSeed(context);
            }
            context.Save();
        }
    }
}
