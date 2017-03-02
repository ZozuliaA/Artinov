namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New_fields_for_passwords : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Salt", c => c.String());
            AddColumn("dbo.Patients", "Hash", c => c.String());
            AlterColumn("dbo.Passports", "SeriesA", c => c.String(nullable: false));
            DropColumn("dbo.Patients", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "Password", c => c.String(maxLength: 32));
            AlterColumn("dbo.Passports", "SeriesA", c => c.String());
            DropColumn("dbo.Patients", "Hash");
            DropColumn("dbo.Patients", "Salt");
        }
    }
}
