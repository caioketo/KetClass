namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PermissaoModels", "Codigo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PermissaoModels", "Codigo");
        }
    }
}
