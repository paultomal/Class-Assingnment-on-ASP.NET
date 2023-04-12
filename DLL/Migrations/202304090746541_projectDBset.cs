namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projectDBset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        Name = c.String(),
                        project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.project_Id)
                .Index(t => t.project_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Status = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "project_Id", "dbo.Projects");
            DropIndex("dbo.Members", new[] { "project_Id" });
            DropTable("dbo.Projects");
            DropTable("dbo.Members");
        }
    }
}
