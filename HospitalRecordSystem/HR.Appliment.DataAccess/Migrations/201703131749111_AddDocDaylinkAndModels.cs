namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDocDaylinkAndModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DaysOfReceivings", "TimeOfReceiving_TORId", "dbo.TimeOfReceivings");
            DropIndex("dbo.DaysOfReceivings", new[] { "TimeOfReceiving_TORId" });
            AddColumn("dbo.Doctors", "DaysOfReceiving_DORId", c => c.Guid(nullable: false));
            AlterColumn("dbo.DaysOfReceivings", "TimeOfReceiving_TORId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Doctors", "DaysOfReceiving_DORId");
            CreateIndex("dbo.DaysOfReceivings", "TimeOfReceiving_TORId");
            AddForeignKey("dbo.Doctors", "DaysOfReceiving_DORId", "dbo.DaysOfReceivings", "DORId", cascadeDelete: true);
            AddForeignKey("dbo.DaysOfReceivings", "TimeOfReceiving_TORId", "dbo.TimeOfReceivings", "TORId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DaysOfReceivings", "TimeOfReceiving_TORId", "dbo.TimeOfReceivings");
            DropForeignKey("dbo.Doctors", "DaysOfReceiving_DORId", "dbo.DaysOfReceivings");
            DropIndex("dbo.DaysOfReceivings", new[] { "TimeOfReceiving_TORId" });
            DropIndex("dbo.Doctors", new[] { "DaysOfReceiving_DORId" });
            AlterColumn("dbo.DaysOfReceivings", "TimeOfReceiving_TORId", c => c.Guid());
            DropColumn("dbo.Doctors", "DaysOfReceiving_DORId");
            CreateIndex("dbo.DaysOfReceivings", "TimeOfReceiving_TORId");
            AddForeignKey("dbo.DaysOfReceivings", "TimeOfReceiving_TORId", "dbo.TimeOfReceivings", "TORId");
        }
    }
}
