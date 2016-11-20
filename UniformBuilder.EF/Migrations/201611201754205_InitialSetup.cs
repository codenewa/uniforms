namespace UniformBuilder.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationTypeConfigurationOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ApplicationType_Id = c.Guid(),
                        ApplicationTypeConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationTypes", t => t.ApplicationType_Id)
                .ForeignKey("dbo.ApplicationTypeConfigurations", t => t.ApplicationTypeConfiguration_Id)
                .Index(t => t.ApplicationType_Id)
                .Index(t => t.ApplicationTypeConfiguration_Id);
            
            CreateTable(
                "dbo.ApplicationTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApplicationTypeConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsConfigurable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArrangementConfigurationOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Arrangement_Id = c.Guid(),
                        ArrangementConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Arrangements", t => t.Arrangement_Id)
                .ForeignKey("dbo.ArrangementConfigurations", t => t.ArrangementConfiguration_Id)
                .Index(t => t.Arrangement_Id)
                .Index(t => t.ArrangementConfiguration_Id);
            
            CreateTable(
                "dbo.Arrangements",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArrangementConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsConfigurable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fonts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FontSizes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ColorConfigurationOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Color_Id = c.Guid(),
                        ColorConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.ColorConfigurations", t => t.ColorConfiguration_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.ColorConfiguration_Id);
            
            CreateTable(
                "dbo.ColorConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsConfigurable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FontConfigurationOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Font_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fonts", t => t.Font_Id)
                .Index(t => t.Font_Id);
            
            CreateTable(
                "dbo.FontConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsConfigurable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FontSizeConfigurationOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FontSize_Id = c.Guid(),
                        FontConfiguration_Id = c.Guid(),
                        FontSizeConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FontSizes", t => t.FontSize_Id)
                .ForeignKey("dbo.FontConfigurations", t => t.FontConfiguration_Id)
                .ForeignKey("dbo.FontSizeConfigurations", t => t.FontSizeConfiguration_Id)
                .Index(t => t.FontSize_Id)
                .Index(t => t.FontConfiguration_Id)
                .Index(t => t.FontSizeConfiguration_Id);
            
            CreateTable(
                "dbo.FontSizeConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsConfigurable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jerseys",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BodyColor_Id = c.Guid(),
                        InsertsColor_Id = c.Guid(),
                        PlayerName_Id = c.Guid(),
                        PlayerNumber_Id = c.Guid(),
                        TeamName_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.BodyColor_Id)
                .ForeignKey("dbo.Colors", t => t.InsertsColor_Id)
                .ForeignKey("dbo.PlayerNameSelections", t => t.PlayerName_Id)
                .ForeignKey("dbo.PlayerNumberSelections", t => t.PlayerNumber_Id)
                .ForeignKey("dbo.TeamNameSelections", t => t.TeamName_Id)
                .Index(t => t.BodyColor_Id)
                .Index(t => t.InsertsColor_Id)
                .Index(t => t.PlayerName_Id)
                .Index(t => t.PlayerNumber_Id)
                .Index(t => t.TeamName_Id);
            
            CreateTable(
                "dbo.PlayerNameSelections",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ApplicationType_Id = c.Guid(),
                        Color_Id = c.Guid(),
                        Font_Id = c.Guid(),
                        FontSize_Id = c.Guid(),
                        NamePlate_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationTypes", t => t.ApplicationType_Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.Fonts", t => t.Font_Id)
                .ForeignKey("dbo.FontSizes", t => t.FontSize_Id)
                .ForeignKey("dbo.NamePlateSelections", t => t.NamePlate_Id)
                .Index(t => t.ApplicationType_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Font_Id)
                .Index(t => t.FontSize_Id)
                .Index(t => t.NamePlate_Id);
            
            CreateTable(
                "dbo.NamePlateSelections",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Color_Id = c.Guid(),
                        NamePlateType_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.NamePlateTypes", t => t.NamePlateType_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.NamePlateType_Id);
            
            CreateTable(
                "dbo.NamePlateTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerNumberSelections",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.Int(nullable: false),
                        ApplicationType_Id = c.Guid(),
                        Color_Id = c.Guid(),
                        Font_Id = c.Guid(),
                        FontSize_Id = c.Guid(),
                        Location_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationTypes", t => t.ApplicationType_Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.Fonts", t => t.Font_Id)
                .ForeignKey("dbo.FontSizes", t => t.FontSize_Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .Index(t => t.ApplicationType_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Font_Id)
                .Index(t => t.FontSize_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamNameSelections",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name1 = c.String(),
                        Name2 = c.String(),
                        ApplicationType_Id = c.Guid(),
                        Arrangement_Id = c.Guid(),
                        Color_Id = c.Guid(),
                        Font_Id = c.Guid(),
                        FontSize_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationTypes", t => t.ApplicationType_Id)
                .ForeignKey("dbo.Arrangements", t => t.Arrangement_Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.Fonts", t => t.Font_Id)
                .ForeignKey("dbo.FontSizes", t => t.FontSize_Id)
                .Index(t => t.ApplicationType_Id)
                .Index(t => t.Arrangement_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Font_Id)
                .Index(t => t.FontSize_Id);
            
            CreateTable(
                "dbo.LocationConfigurationOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Location_Id = c.Guid(),
                        LocationFontSizeConfiguration_Id = c.Guid(),
                        LocationConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .ForeignKey("dbo.FontSizeConfigurations", t => t.LocationFontSizeConfiguration_Id)
                .ForeignKey("dbo.LocationConfigurations", t => t.LocationConfiguration_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.LocationFontSizeConfiguration_Id)
                .Index(t => t.LocationConfiguration_Id);
            
            CreateTable(
                "dbo.LocationConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsConfigurable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NamePlateTypeConfigurationOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NamePlateType_Id = c.Guid(),
                        NamePlateTypeConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NamePlateTypes", t => t.NamePlateType_Id)
                .ForeignKey("dbo.NamePlateTypeConfigurations", t => t.NamePlateTypeConfiguration_Id)
                .Index(t => t.NamePlateType_Id)
                .Index(t => t.NamePlateTypeConfiguration_Id);
            
            CreateTable(
                "dbo.NamePlateTypeConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsConfigurable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerNameStyles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsOptional = c.Boolean(nullable: false),
                        NameMaxLength = c.Int(nullable: false),
                        ConfigureNamePlate = c.Boolean(nullable: false),
                        ApplicationTypeConfiguration_Id = c.Guid(),
                        ArrangementConfiguration_Id = c.Guid(),
                        ColorConfiguration_Id = c.Guid(),
                        FontConfiguration_Id = c.Guid(),
                        FontSizeConfiguration_Id = c.Guid(),
                        NamePlateStyle_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationTypeConfigurations", t => t.ApplicationTypeConfiguration_Id)
                .ForeignKey("dbo.ArrangementConfigurations", t => t.ArrangementConfiguration_Id)
                .ForeignKey("dbo.ColorConfigurations", t => t.ColorConfiguration_Id)
                .ForeignKey("dbo.FontConfigurations", t => t.FontConfiguration_Id)
                .ForeignKey("dbo.FontSizeConfigurations", t => t.FontSizeConfiguration_Id)
                .ForeignKey("dbo.NamePlateStyles", t => t.NamePlateStyle_Id)
                .Index(t => t.ApplicationTypeConfiguration_Id)
                .Index(t => t.ArrangementConfiguration_Id)
                .Index(t => t.ColorConfiguration_Id)
                .Index(t => t.FontConfiguration_Id)
                .Index(t => t.FontSizeConfiguration_Id)
                .Index(t => t.NamePlateStyle_Id);
            
            CreateTable(
                "dbo.NamePlateStyles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ColorConfiguration_Id = c.Guid(),
                        Configuration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ColorConfigurations", t => t.ColorConfiguration_Id)
                .ForeignKey("dbo.NamePlateTypeConfigurations", t => t.Configuration_Id)
                .Index(t => t.ColorConfiguration_Id)
                .Index(t => t.Configuration_Id);
            
            CreateTable(
                "dbo.PlayerNumberStyles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsOptional = c.Boolean(nullable: false),
                        Range = c.String(),
                        ApplicationTypeConfiguration_Id = c.Guid(),
                        ArrangementConfiguration_Id = c.Guid(),
                        ColorConfiguration_Id = c.Guid(),
                        FontConfiguration_Id = c.Guid(),
                        FontSizeConfiguration_Id = c.Guid(),
                        LocationConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationTypeConfigurations", t => t.ApplicationTypeConfiguration_Id)
                .ForeignKey("dbo.ArrangementConfigurations", t => t.ArrangementConfiguration_Id)
                .ForeignKey("dbo.ColorConfigurations", t => t.ColorConfiguration_Id)
                .ForeignKey("dbo.FontConfigurations", t => t.FontConfiguration_Id)
                .ForeignKey("dbo.FontSizeConfigurations", t => t.FontSizeConfiguration_Id)
                .ForeignKey("dbo.LocationConfigurations", t => t.LocationConfiguration_Id)
                .Index(t => t.ApplicationTypeConfiguration_Id)
                .Index(t => t.ArrangementConfiguration_Id)
                .Index(t => t.ColorConfiguration_Id)
                .Index(t => t.FontConfiguration_Id)
                .Index(t => t.FontSizeConfiguration_Id)
                .Index(t => t.LocationConfiguration_Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamNameStyleConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaxLength = c.Int(nullable: false),
                        IsOptional = c.Boolean(nullable: false),
                        AllowLine2 = c.Boolean(nullable: false),
                        Line2MaxLength = c.Int(nullable: false),
                        ProvideArrangementOptions = c.Boolean(nullable: false),
                        ApplicationTypeConfiguration_Id = c.Guid(),
                        ArrangementConfiguration_Id = c.Guid(),
                        ColorConfiguration_Id = c.Guid(),
                        FontConfiguration_Id = c.Guid(),
                        FontSizeConfiguration_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationTypeConfigurations", t => t.ApplicationTypeConfiguration_Id)
                .ForeignKey("dbo.ArrangementConfigurations", t => t.ArrangementConfiguration_Id)
                .ForeignKey("dbo.ColorConfigurations", t => t.ColorConfiguration_Id)
                .ForeignKey("dbo.FontConfigurations", t => t.FontConfiguration_Id)
                .ForeignKey("dbo.FontSizeConfigurations", t => t.FontSizeConfiguration_Id)
                .Index(t => t.ApplicationTypeConfiguration_Id)
                .Index(t => t.ArrangementConfiguration_Id)
                .Index(t => t.ColorConfiguration_Id)
                .Index(t => t.FontConfiguration_Id)
                .Index(t => t.FontSizeConfiguration_Id);
            
            CreateTable(
                "dbo.UniformStyles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        BodyColorConfiguration_Id = c.Guid(),
                        InsertsColorConfiguration_Id = c.Guid(),
                        PlayerNameStyle_Id = c.Guid(),
                        PlayerNumberStyle_Id = c.Guid(),
                        Sport_Id = c.Guid(),
                        TeamNameStyle_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ColorConfigurations", t => t.BodyColorConfiguration_Id)
                .ForeignKey("dbo.ColorConfigurations", t => t.InsertsColorConfiguration_Id)
                .ForeignKey("dbo.PlayerNameStyles", t => t.PlayerNameStyle_Id)
                .ForeignKey("dbo.PlayerNumberStyles", t => t.PlayerNumberStyle_Id)
                .ForeignKey("dbo.Sports", t => t.Sport_Id)
                .ForeignKey("dbo.TeamNameStyleConfigurations", t => t.TeamNameStyle_Id)
                .Index(t => t.BodyColorConfiguration_Id)
                .Index(t => t.InsertsColorConfiguration_Id)
                .Index(t => t.PlayerNameStyle_Id)
                .Index(t => t.PlayerNumberStyle_Id)
                .Index(t => t.Sport_Id)
                .Index(t => t.TeamNameStyle_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UniformStyles", "TeamNameStyle_Id", "dbo.TeamNameStyleConfigurations");
            DropForeignKey("dbo.UniformStyles", "Sport_Id", "dbo.Sports");
            DropForeignKey("dbo.UniformStyles", "PlayerNumberStyle_Id", "dbo.PlayerNumberStyles");
            DropForeignKey("dbo.UniformStyles", "PlayerNameStyle_Id", "dbo.PlayerNameStyles");
            DropForeignKey("dbo.UniformStyles", "InsertsColorConfiguration_Id", "dbo.ColorConfigurations");
            DropForeignKey("dbo.UniformStyles", "BodyColorConfiguration_Id", "dbo.ColorConfigurations");
            DropForeignKey("dbo.TeamNameStyleConfigurations", "FontSizeConfiguration_Id", "dbo.FontSizeConfigurations");
            DropForeignKey("dbo.TeamNameStyleConfigurations", "FontConfiguration_Id", "dbo.FontConfigurations");
            DropForeignKey("dbo.TeamNameStyleConfigurations", "ColorConfiguration_Id", "dbo.ColorConfigurations");
            DropForeignKey("dbo.TeamNameStyleConfigurations", "ArrangementConfiguration_Id", "dbo.ArrangementConfigurations");
            DropForeignKey("dbo.TeamNameStyleConfigurations", "ApplicationTypeConfiguration_Id", "dbo.ApplicationTypeConfigurations");
            DropForeignKey("dbo.PlayerNumberStyles", "LocationConfiguration_Id", "dbo.LocationConfigurations");
            DropForeignKey("dbo.PlayerNumberStyles", "FontSizeConfiguration_Id", "dbo.FontSizeConfigurations");
            DropForeignKey("dbo.PlayerNumberStyles", "FontConfiguration_Id", "dbo.FontConfigurations");
            DropForeignKey("dbo.PlayerNumberStyles", "ColorConfiguration_Id", "dbo.ColorConfigurations");
            DropForeignKey("dbo.PlayerNumberStyles", "ArrangementConfiguration_Id", "dbo.ArrangementConfigurations");
            DropForeignKey("dbo.PlayerNumberStyles", "ApplicationTypeConfiguration_Id", "dbo.ApplicationTypeConfigurations");
            DropForeignKey("dbo.PlayerNameStyles", "NamePlateStyle_Id", "dbo.NamePlateStyles");
            DropForeignKey("dbo.NamePlateStyles", "Configuration_Id", "dbo.NamePlateTypeConfigurations");
            DropForeignKey("dbo.NamePlateStyles", "ColorConfiguration_Id", "dbo.ColorConfigurations");
            DropForeignKey("dbo.PlayerNameStyles", "FontSizeConfiguration_Id", "dbo.FontSizeConfigurations");
            DropForeignKey("dbo.PlayerNameStyles", "FontConfiguration_Id", "dbo.FontConfigurations");
            DropForeignKey("dbo.PlayerNameStyles", "ColorConfiguration_Id", "dbo.ColorConfigurations");
            DropForeignKey("dbo.PlayerNameStyles", "ArrangementConfiguration_Id", "dbo.ArrangementConfigurations");
            DropForeignKey("dbo.PlayerNameStyles", "ApplicationTypeConfiguration_Id", "dbo.ApplicationTypeConfigurations");
            DropForeignKey("dbo.NamePlateTypeConfigurationOptions", "NamePlateTypeConfiguration_Id", "dbo.NamePlateTypeConfigurations");
            DropForeignKey("dbo.NamePlateTypeConfigurationOptions", "NamePlateType_Id", "dbo.NamePlateTypes");
            DropForeignKey("dbo.LocationConfigurationOptions", "LocationConfiguration_Id", "dbo.LocationConfigurations");
            DropForeignKey("dbo.LocationConfigurationOptions", "LocationFontSizeConfiguration_Id", "dbo.FontSizeConfigurations");
            DropForeignKey("dbo.LocationConfigurationOptions", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Jerseys", "TeamName_Id", "dbo.TeamNameSelections");
            DropForeignKey("dbo.TeamNameSelections", "FontSize_Id", "dbo.FontSizes");
            DropForeignKey("dbo.TeamNameSelections", "Font_Id", "dbo.Fonts");
            DropForeignKey("dbo.TeamNameSelections", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.TeamNameSelections", "Arrangement_Id", "dbo.Arrangements");
            DropForeignKey("dbo.TeamNameSelections", "ApplicationType_Id", "dbo.ApplicationTypes");
            DropForeignKey("dbo.Jerseys", "PlayerNumber_Id", "dbo.PlayerNumberSelections");
            DropForeignKey("dbo.PlayerNumberSelections", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.PlayerNumberSelections", "FontSize_Id", "dbo.FontSizes");
            DropForeignKey("dbo.PlayerNumberSelections", "Font_Id", "dbo.Fonts");
            DropForeignKey("dbo.PlayerNumberSelections", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.PlayerNumberSelections", "ApplicationType_Id", "dbo.ApplicationTypes");
            DropForeignKey("dbo.Jerseys", "PlayerName_Id", "dbo.PlayerNameSelections");
            DropForeignKey("dbo.PlayerNameSelections", "NamePlate_Id", "dbo.NamePlateSelections");
            DropForeignKey("dbo.NamePlateSelections", "NamePlateType_Id", "dbo.NamePlateTypes");
            DropForeignKey("dbo.NamePlateSelections", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.PlayerNameSelections", "FontSize_Id", "dbo.FontSizes");
            DropForeignKey("dbo.PlayerNameSelections", "Font_Id", "dbo.Fonts");
            DropForeignKey("dbo.PlayerNameSelections", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.PlayerNameSelections", "ApplicationType_Id", "dbo.ApplicationTypes");
            DropForeignKey("dbo.Jerseys", "InsertsColor_Id", "dbo.Colors");
            DropForeignKey("dbo.Jerseys", "BodyColor_Id", "dbo.Colors");
            DropForeignKey("dbo.FontSizeConfigurationOptions", "FontSizeConfiguration_Id", "dbo.FontSizeConfigurations");
            DropForeignKey("dbo.FontSizeConfigurationOptions", "FontConfiguration_Id", "dbo.FontConfigurations");
            DropForeignKey("dbo.FontSizeConfigurationOptions", "FontSize_Id", "dbo.FontSizes");
            DropForeignKey("dbo.FontConfigurationOptions", "Font_Id", "dbo.Fonts");
            DropForeignKey("dbo.ColorConfigurationOptions", "ColorConfiguration_Id", "dbo.ColorConfigurations");
            DropForeignKey("dbo.ColorConfigurationOptions", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.ArrangementConfigurationOptions", "ArrangementConfiguration_Id", "dbo.ArrangementConfigurations");
            DropForeignKey("dbo.ArrangementConfigurationOptions", "Arrangement_Id", "dbo.Arrangements");
            DropForeignKey("dbo.ApplicationTypeConfigurationOptions", "ApplicationTypeConfiguration_Id", "dbo.ApplicationTypeConfigurations");
            DropForeignKey("dbo.ApplicationTypeConfigurationOptions", "ApplicationType_Id", "dbo.ApplicationTypes");
            DropIndex("dbo.UniformStyles", new[] { "TeamNameStyle_Id" });
            DropIndex("dbo.UniformStyles", new[] { "Sport_Id" });
            DropIndex("dbo.UniformStyles", new[] { "PlayerNumberStyle_Id" });
            DropIndex("dbo.UniformStyles", new[] { "PlayerNameStyle_Id" });
            DropIndex("dbo.UniformStyles", new[] { "InsertsColorConfiguration_Id" });
            DropIndex("dbo.UniformStyles", new[] { "BodyColorConfiguration_Id" });
            DropIndex("dbo.TeamNameStyleConfigurations", new[] { "FontSizeConfiguration_Id" });
            DropIndex("dbo.TeamNameStyleConfigurations", new[] { "FontConfiguration_Id" });
            DropIndex("dbo.TeamNameStyleConfigurations", new[] { "ColorConfiguration_Id" });
            DropIndex("dbo.TeamNameStyleConfigurations", new[] { "ArrangementConfiguration_Id" });
            DropIndex("dbo.TeamNameStyleConfigurations", new[] { "ApplicationTypeConfiguration_Id" });
            DropIndex("dbo.PlayerNumberStyles", new[] { "LocationConfiguration_Id" });
            DropIndex("dbo.PlayerNumberStyles", new[] { "FontSizeConfiguration_Id" });
            DropIndex("dbo.PlayerNumberStyles", new[] { "FontConfiguration_Id" });
            DropIndex("dbo.PlayerNumberStyles", new[] { "ColorConfiguration_Id" });
            DropIndex("dbo.PlayerNumberStyles", new[] { "ArrangementConfiguration_Id" });
            DropIndex("dbo.PlayerNumberStyles", new[] { "ApplicationTypeConfiguration_Id" });
            DropIndex("dbo.NamePlateStyles", new[] { "Configuration_Id" });
            DropIndex("dbo.NamePlateStyles", new[] { "ColorConfiguration_Id" });
            DropIndex("dbo.PlayerNameStyles", new[] { "NamePlateStyle_Id" });
            DropIndex("dbo.PlayerNameStyles", new[] { "FontSizeConfiguration_Id" });
            DropIndex("dbo.PlayerNameStyles", new[] { "FontConfiguration_Id" });
            DropIndex("dbo.PlayerNameStyles", new[] { "ColorConfiguration_Id" });
            DropIndex("dbo.PlayerNameStyles", new[] { "ArrangementConfiguration_Id" });
            DropIndex("dbo.PlayerNameStyles", new[] { "ApplicationTypeConfiguration_Id" });
            DropIndex("dbo.NamePlateTypeConfigurationOptions", new[] { "NamePlateTypeConfiguration_Id" });
            DropIndex("dbo.NamePlateTypeConfigurationOptions", new[] { "NamePlateType_Id" });
            DropIndex("dbo.LocationConfigurationOptions", new[] { "LocationConfiguration_Id" });
            DropIndex("dbo.LocationConfigurationOptions", new[] { "LocationFontSizeConfiguration_Id" });
            DropIndex("dbo.LocationConfigurationOptions", new[] { "Location_Id" });
            DropIndex("dbo.TeamNameSelections", new[] { "FontSize_Id" });
            DropIndex("dbo.TeamNameSelections", new[] { "Font_Id" });
            DropIndex("dbo.TeamNameSelections", new[] { "Color_Id" });
            DropIndex("dbo.TeamNameSelections", new[] { "Arrangement_Id" });
            DropIndex("dbo.TeamNameSelections", new[] { "ApplicationType_Id" });
            DropIndex("dbo.PlayerNumberSelections", new[] { "Location_Id" });
            DropIndex("dbo.PlayerNumberSelections", new[] { "FontSize_Id" });
            DropIndex("dbo.PlayerNumberSelections", new[] { "Font_Id" });
            DropIndex("dbo.PlayerNumberSelections", new[] { "Color_Id" });
            DropIndex("dbo.PlayerNumberSelections", new[] { "ApplicationType_Id" });
            DropIndex("dbo.NamePlateSelections", new[] { "NamePlateType_Id" });
            DropIndex("dbo.NamePlateSelections", new[] { "Color_Id" });
            DropIndex("dbo.PlayerNameSelections", new[] { "NamePlate_Id" });
            DropIndex("dbo.PlayerNameSelections", new[] { "FontSize_Id" });
            DropIndex("dbo.PlayerNameSelections", new[] { "Font_Id" });
            DropIndex("dbo.PlayerNameSelections", new[] { "Color_Id" });
            DropIndex("dbo.PlayerNameSelections", new[] { "ApplicationType_Id" });
            DropIndex("dbo.Jerseys", new[] { "TeamName_Id" });
            DropIndex("dbo.Jerseys", new[] { "PlayerNumber_Id" });
            DropIndex("dbo.Jerseys", new[] { "PlayerName_Id" });
            DropIndex("dbo.Jerseys", new[] { "InsertsColor_Id" });
            DropIndex("dbo.Jerseys", new[] { "BodyColor_Id" });
            DropIndex("dbo.FontSizeConfigurationOptions", new[] { "FontSizeConfiguration_Id" });
            DropIndex("dbo.FontSizeConfigurationOptions", new[] { "FontConfiguration_Id" });
            DropIndex("dbo.FontSizeConfigurationOptions", new[] { "FontSize_Id" });
            DropIndex("dbo.FontConfigurationOptions", new[] { "Font_Id" });
            DropIndex("dbo.ColorConfigurationOptions", new[] { "ColorConfiguration_Id" });
            DropIndex("dbo.ColorConfigurationOptions", new[] { "Color_Id" });
            DropIndex("dbo.ArrangementConfigurationOptions", new[] { "ArrangementConfiguration_Id" });
            DropIndex("dbo.ArrangementConfigurationOptions", new[] { "Arrangement_Id" });
            DropIndex("dbo.ApplicationTypeConfigurationOptions", new[] { "ApplicationTypeConfiguration_Id" });
            DropIndex("dbo.ApplicationTypeConfigurationOptions", new[] { "ApplicationType_Id" });
            DropTable("dbo.UniformStyles");
            DropTable("dbo.TeamNameStyleConfigurations");
            DropTable("dbo.Sports");
            DropTable("dbo.PlayerNumberStyles");
            DropTable("dbo.NamePlateStyles");
            DropTable("dbo.PlayerNameStyles");
            DropTable("dbo.NamePlateTypeConfigurations");
            DropTable("dbo.NamePlateTypeConfigurationOptions");
            DropTable("dbo.LocationConfigurations");
            DropTable("dbo.LocationConfigurationOptions");
            DropTable("dbo.TeamNameSelections");
            DropTable("dbo.Locations");
            DropTable("dbo.PlayerNumberSelections");
            DropTable("dbo.NamePlateTypes");
            DropTable("dbo.NamePlateSelections");
            DropTable("dbo.PlayerNameSelections");
            DropTable("dbo.Jerseys");
            DropTable("dbo.FontSizeConfigurations");
            DropTable("dbo.FontSizeConfigurationOptions");
            DropTable("dbo.FontConfigurations");
            DropTable("dbo.FontConfigurationOptions");
            DropTable("dbo.ColorConfigurations");
            DropTable("dbo.ColorConfigurationOptions");
            DropTable("dbo.FontSizes");
            DropTable("dbo.Colors");
            DropTable("dbo.Fonts");
            DropTable("dbo.ArrangementConfigurations");
            DropTable("dbo.Arrangements");
            DropTable("dbo.ArrangementConfigurationOptions");
            DropTable("dbo.ApplicationTypeConfigurations");
            DropTable("dbo.ApplicationTypes");
            DropTable("dbo.ApplicationTypeConfigurationOptions");
        }
    }
}
