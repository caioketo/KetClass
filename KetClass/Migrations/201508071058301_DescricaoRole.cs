namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescricaoRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoleModels", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoleModels", "Descricao");
        }
    }
}
