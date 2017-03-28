namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NothingAdd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "LoginD", c => c.String());
            AlterColumn("dbo.Doctors", "HashD", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "HashD", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "LoginD", c => c.String(nullable: false));
        }
    }
}
