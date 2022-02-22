namespace PCR_Report.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestDescriptions", "SampleAr", c => c.String());
            AddColumn("dbo.TestDescriptions", "SampleEn", c => c.String());
            AddColumn("dbo.TestDescriptions", "DescriptionAr", c => c.String());
            AddColumn("dbo.TestDescriptions", "DescriptionEn", c => c.String());
            DropColumn("dbo.TestDescriptions", "Sample");
            DropColumn("dbo.TestDescriptions", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TestDescriptions", "Description", c => c.String());
            AddColumn("dbo.TestDescriptions", "Sample", c => c.String());
            DropColumn("dbo.TestDescriptions", "DescriptionEn");
            DropColumn("dbo.TestDescriptions", "DescriptionAr");
            DropColumn("dbo.TestDescriptions", "SampleEn");
            DropColumn("dbo.TestDescriptions", "SampleAr");
        }
    }
}
