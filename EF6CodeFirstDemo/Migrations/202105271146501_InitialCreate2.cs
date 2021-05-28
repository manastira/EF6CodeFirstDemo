namespace EF6CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
