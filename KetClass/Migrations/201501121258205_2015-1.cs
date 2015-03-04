namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20151 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CursoModels", "Ano");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CursoModels", "Ano", c => c.Int(nullable: false));
        }
    }
}
