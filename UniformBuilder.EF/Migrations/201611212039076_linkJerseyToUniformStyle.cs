namespace UniformBuilder.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class linkJerseyToUniformStyle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jerseys", "UniformStyle_Id", c => c.Guid());
            CreateIndex("dbo.Jerseys", "UniformStyle_Id");
            AddForeignKey("dbo.Jerseys", "UniformStyle_Id", "dbo.UniformStyles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jerseys", "UniformStyle_Id", "dbo.UniformStyles");
            DropIndex("dbo.Jerseys", new[] { "UniformStyle_Id" });
            DropColumn("dbo.Jerseys", "UniformStyle_Id");
        }
    }
}
