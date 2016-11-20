namespace UniformBuilder.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addjerseynameAndDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jerseys", "Name", c => c.String());
            AddColumn("dbo.Jerseys", "Description", c => c.String());
            AddColumn("dbo.Jerseys", "Identifier", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jerseys", "Identifier");
            DropColumn("dbo.Jerseys", "Description");
            DropColumn("dbo.Jerseys", "Name");
        }
    }
}
