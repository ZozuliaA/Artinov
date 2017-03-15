namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypesOfDaysAndTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DaysOfReceivings", "Mondey", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "Tuesday", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "Wednesday", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "Thursday", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "Friday", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "Satarday", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "Sunday", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T10_00", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T10_20", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T10_40", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T11_00", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T12_00", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TimeOfReceivings", "T12_00", c => c.Int(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T11_00", c => c.Int(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T10_40", c => c.Int(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T10_20", c => c.Int(nullable: false));
            AlterColumn("dbo.TimeOfReceivings", "T10_00", c => c.Int(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "Sunday", c => c.String());
            AlterColumn("dbo.DaysOfReceivings", "Satarday", c => c.String());
            AlterColumn("dbo.DaysOfReceivings", "Friday", c => c.String());
            AlterColumn("dbo.DaysOfReceivings", "Thursday", c => c.String());
            AlterColumn("dbo.DaysOfReceivings", "Wednesday", c => c.String());
            AlterColumn("dbo.DaysOfReceivings", "Tuesday", c => c.String());
            AlterColumn("dbo.DaysOfReceivings", "Mondey", c => c.String());
        }
    }
}
