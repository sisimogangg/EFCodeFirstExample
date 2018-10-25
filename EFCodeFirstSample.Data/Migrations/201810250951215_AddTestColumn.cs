namespace DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "test", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "test");
        }
    }
}
