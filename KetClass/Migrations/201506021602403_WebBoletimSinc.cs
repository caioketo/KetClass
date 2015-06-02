namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebBoletimSinc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BoletimWebModels", "PrecisaSinc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BoletimWebModels", "PrecisaSinc");
        }
    }
}
