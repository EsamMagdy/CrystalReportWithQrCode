namespace PCR_Report.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        Phone = c.Int(nullable: false),
                        CollectionDate = c.DateTime(nullable: false),
                        ResultDate = c.DateTime(nullable: false),
                        Report = c.Int(nullable: false),
                        HESNNo = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        TestDescription_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestDescriptions", t => t.TestDescription_Id)
                .Index(t => t.TestDescription_Id);
            
            CreateTable(
                "dbo.TestDescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sample = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "TestDescription_Id", "dbo.TestDescriptions");
            DropIndex("dbo.Patients", new[] { "TestDescription_Id" });
            DropTable("dbo.TestDescriptions");
            DropTable("dbo.Patients");
        }
    }
}
