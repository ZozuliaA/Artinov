namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocTableAddRoleLoginHash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Role", c => c.String(nullable: false));
            AddColumn("dbo.Doctors", "LoginD", c => c.String(nullable: false));
            AddColumn("dbo.Doctors", "HashD", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "HashD");
            DropColumn("dbo.Doctors", "LoginD");
            DropColumn("dbo.Doctors", "Role");
        }
    }
}
