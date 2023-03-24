namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parties", "ListNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Parties", "PreferenceNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parties", "PreferenceNumber");
            DropColumn("dbo.Parties", "ListNumber");
        }
    }
}
