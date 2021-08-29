namespace winforms_mvp_tutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_roles_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.roles", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.roles", "Role_Id", "dbo.roles");
            DropIndex("dbo.roles", new[] { "Role_Id" });
            DropTable("dbo.roles");
        }
    }
}
