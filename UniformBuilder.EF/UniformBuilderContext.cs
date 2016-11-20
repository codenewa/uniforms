using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using UniformBuilder.Uniform;
using UniformBuilder.Options;
using UniformBuilder.Style;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.EF
{
    public class UniformBuilderContext: DbContext
    {

        public UniformBuilderContext() : base("name=UniformBuilder")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        #region Options
        public virtual IDbSet<Sport> Sports { get; set; }
        public virtual IDbSet<ApplicationType> ApplicationTypes { get; set; }
        public virtual IDbSet<Arrangement> TeamNameArrangements { get; set; }
        public virtual IDbSet<Color> AvailableColors { get; set; }
        public virtual IDbSet<Font> AvailabelFonts { get; set; }
        public virtual IDbSet<FontSize> AvailableFontSizes { get; set; }
        public virtual IDbSet<Location> PlayerNumberLocations { get; set; }
        public virtual IDbSet<NamePlateType> NamePlateTypes { get; set; }

        #endregion

        #region Configurations
        public virtual IDbSet<ApplicationTypeConfiguration> ApplicationTypeConfigurations { get; set; }
        public virtual IDbSet<ArrangementConfiguration> ArrangementConfigurations { get; set; }
        public virtual IDbSet<ColorConfiguration> ColorConfigurations { get; set; }
        public virtual IDbSet<FontConfiguration> FontConfigurations { get; set; }
        public virtual IDbSet<FontSizeConfiguration> FontSizeConfigurations { get; set; }
        public virtual IDbSet<LocationConfiguration> LocationConfigurations { get; set; }
        public virtual IDbSet<NamePlateTypeConfiguration> NamePlateTypeConfigurations { get; set; }
        public virtual IDbSet<ArrangementConfigurationOption> ArrangementConfigurationOptions { get; set; }
        public virtual IDbSet<ColorConfigurationOption> ColorConfigurationOptions { get; set; }
        public virtual IDbSet<FontConfigurationOption> FontConfigurationOptions { get; set; }
        public virtual IDbSet<FontSizeConfigurationOption> FontSizeConfigurationOptions { get; set; }
        public virtual IDbSet<LocationConfigurationOption> LocationConfigurationOptions { get; set; }
        public virtual IDbSet<ApplicationTypeConfigurationOption> ApplicationTypeConfigurationOptions { get; set; }
        public virtual IDbSet<NamePlateTypeConfigurationOption> NamePlateTypeConfigurationOptions { get; set; }
        #endregion

        #region StyleConfigurations
        public virtual IDbSet<UniformStyle> UniformStyles { get; set; }
        public virtual IDbSet<TeamNameStyleConfiguration> TeamNameStyles { get; set; }
        public virtual IDbSet<PlayerNumberStyle> PlayerNumberStyles { get; set; }
        public virtual IDbSet<PlayerNameStyle> PlayerNameStyles { get; set; }
        #endregion


        #region Jersey Context
        public virtual IDbSet<Jersey> Jerseys { get; set; }
        #endregion

        public virtual void AddOrUpdate<TE>(Expression<Func<TE, object>> identifierExpression,
            IList<TE> list) where TE : class
        {
            Set<TE>().AddOrUpdate(identifierExpression, list.ToArray());
        }

        public virtual void Save()
        {
            this.SaveChanges();
        }

    }
}
