namespace DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnOther : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Gender = c.String(),
                        EmailAddress = c.String(),
                        ContactNumber = c.String(),
                        Cancelled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Client");
        }
    }
}
