namespace StateExamVariants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExNumber = c.Int(nullable: false),
                        Level = c.String(maxLength: 100),
                        Task = c.String(),
                        Solution = c.String(),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Level, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Exercises", new[] { "Level" });
            DropTable("dbo.Exercises");
        }
    }
}
