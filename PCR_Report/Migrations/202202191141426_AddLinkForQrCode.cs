namespace PCR_Report.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinkForQrCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "LinkForQrCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "LinkForQrCode");
        }
    }
}
