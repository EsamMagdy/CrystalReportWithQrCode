namespace PCR_Report.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMedicalCenter1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Patients", "TestDescription_Id", "dbo.TestDescriptions");
            DropIndex("dbo.Patients", new[] { "TestDescription_Id" });
            RenameColumn(table: "dbo.Patients", name: "TestDescription_Id", newName: "TestDescriptionId");
            AlterColumn("dbo.Patients", "TestDescriptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Patients", "TestDescriptionId");
            AddForeignKey("dbo.Patients", "TestDescriptionId", "dbo.TestDescriptions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "TestDescriptionId", "dbo.TestDescriptions");
            DropIndex("dbo.Patients", new[] { "TestDescriptionId" });
            AlterColumn("dbo.Patients", "TestDescriptionId", c => c.Int());
            RenameColumn(table: "dbo.Patients", name: "TestDescriptionId", newName: "TestDescription_Id");
            CreateIndex("dbo.Patients", "TestDescription_Id");
            AddForeignKey("dbo.Patients", "TestDescription_Id", "dbo.TestDescriptions", "Id");
        }
    }
}
