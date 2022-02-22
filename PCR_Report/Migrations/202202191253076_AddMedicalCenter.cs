namespace PCR_Report.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMedicalCenter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "MedicalCenter", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "MedicalCenter");
        }
    }
}
