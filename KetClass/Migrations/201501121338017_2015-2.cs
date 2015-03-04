namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20152 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AlunoModels", "Certidao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AlunoModels", "Certidao");
        }
    }
}
