namespace DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTestColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Client", "test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Client", "test", c => c.Int(nullable: false));
        }
    }
}
