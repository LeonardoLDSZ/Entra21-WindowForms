namespace ExemploEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up() //acontece quando o banco esta em versão mais antiga que o sistema 
        {
            CreateTable(
                "public.Categoria",
                c => new //construtor de colunas - columBuilder
                    {
                    
                        Id = c.Int(nullable: false, identity: true), //identidy deixa como primary key
                        Nome = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down() //Executa quando quer retirar as alterações, retornar versão...
        {
            DropTable("public.Categoria");
        }
    }
}
