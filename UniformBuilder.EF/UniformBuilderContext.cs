using System.Data.Entity;
using UniformBuilder.Uniform;
using UniformBuilder.Options;
using UniformBuilder.Style;
using UniformBuilder.Style.Configuration;

namespace UniformBuilder.EF
{
    public class UniformBuilderContext: DbContext
    {
        public UniformBuilderContext(): base("name=UniformBuilder"){}
        #region Options
        public IDbSet<Sport> Sports { get; set; }
        public IDbSet<ApplicationType> ApplicationTypes { get; set; }
        public IDbSet<Arrangement> TeamNameArrangements { get; set; }
        public IDbSet<Color> AvailableColors { get; set; }
        public IDbSet<Font> AvailabelFonts { get; set; }
        public IDbSet<FontSize> AvailableFontSizes { get; set; }
        public IDbSet<Location> PlayerNumberLocations { get; set; }
        public IDbSet<NamePlateType> NamePlateTypes { get; set; }

        #endregion

        #region Configurations
        public IDbSet<ApplicationTypeConfiguration> ApplicationTypeConfigurations { get; set; }
        public IDbSet<ArrangementConfiguration> ArrangementConfigurations { get; set; }
        public IDbSet<ColorConfiguration> ColorConfigurations { get; set; }
        public IDbSet<FontConfiguration> FontConfigurations { get; set; }
        public IDbSet<FontSizeConfiguration> FontSizeConfigurations { get; set; }
        public IDbSet<LocationConfiguration> LocationConfigurations { get; set; }
        public IDbSet<NamePlateTypeConfiguration> NamePlateTypeConfigurations { get; set; }
        public IDbSet<ArrangementConfigurationOption> ArrangementConfigurationOptions { get; set; }
        public IDbSet<ColorConfigurationOption> ColorConfigurationOptions { get; set; }
        public IDbSet<FontConfigurationOption> FontConfigurationOptions { get; set; }
        public IDbSet<FontSizeConfigurationOption> FontSizeConfigurationOptions { get; set; }
        public IDbSet<LocationConfigurationOption> LocationConfigurationOptions { get; set; }
        public IDbSet<ApplicationTypeConfigurationOption> ApplicationTypeConfigurationOptions { get; set; }
        public IDbSet<NamePlateTypeConfigurationOption> NamePlateTypeConfigurationOptions { get; set; }
        #endregion

        #region StyleConfigurations
        public IDbSet<UniformStyle> UniformStyles { get; set; }
        public IDbSet<TeamNameStyleConfiguration> TeamNameStyles { get; set; }
        public IDbSet<PlayerNumberStyle> PlayerNumberStyles { get; set; }
        public IDbSet<PlayerNameStyle> PlayerNameStyles { get; set; }
        #endregion


        #region Jersey Context
        public IDbSet<Uniform.Jersey> Jersies { get; set; }
        #endregion
    }
}
