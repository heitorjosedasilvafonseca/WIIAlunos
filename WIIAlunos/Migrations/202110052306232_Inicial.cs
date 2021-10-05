namespace WIIAlunos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        AlunoId = c.Long(nullable: false, identity: true),
                        Matricula = c.Long(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.AlunoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alunoes");
        }
    }
}
