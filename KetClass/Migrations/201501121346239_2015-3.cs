namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20153 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AlunoModels", "CodigoFam", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AlunoModels", "CodigoFam");
        }
    }
}
