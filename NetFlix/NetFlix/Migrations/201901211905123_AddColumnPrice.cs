namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Series", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Series", "Price");
        }

    }
}
