namespace winforms_mvp_tutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_profiles_table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.roles", "Role_Id", "dbo.roles");
            DropForeignKey("dbo.users", "RoleId", "dbo.roles");
            DropIndex("dbo.roles", new[] { "Role_Id" });
            DropIndex("dbo.users", new[] { "RoleId" });
            CreateTable(
                "dbo.profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfileName = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.users", "ProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.users", "ProfileId");
            AddForeignKey("dbo.users", "ProfileId", "dbo.profiles", "Id", cascadeDelete: true);
            DropColumn("dbo.users", "RoleId");
            DropTable("dbo.roles");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.users", "RoleId", c => c.Int(nullable: false));
            DropForeignKey("dbo.users", "ProfileId", "dbo.profiles");
            DropIndex("dbo.users", new[] { "ProfileId" });
            DropColumn("dbo.users", "ProfileId");
            DropTable("dbo.profiles");
            CreateIndex("dbo.users", "RoleId");
            CreateIndex("dbo.roles", "Role_Id");
            AddForeignKey("dbo.users", "RoleId", "dbo.roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.roles", "Role_Id", "dbo.roles", "Id");
        }
    }
}
