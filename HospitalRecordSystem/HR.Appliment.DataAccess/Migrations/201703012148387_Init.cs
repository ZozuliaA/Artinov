namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "DaysOfReceiving_DORId", "dbo.DaysOfReceivings");
            DropForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties");
            DropIndex("dbo.Doctors", new[] { "DaysOfReceiving_DORId" });
            DropIndex("dbo.Doctors", new[] { "Specialty_SpecialtyId" });
            AlterColumn("dbo.Doctors", "Specialty_SpecialtyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "Specialty_SpecialtyId");
            AddForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties", "SpecialtyId", cascadeDelete: true);
            DropColumn("dbo.Doctors", "DaysOfReceiving_DORId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "DaysOfReceiving_DORId", c => c.Guid());
            DropForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties");
            DropIndex("dbo.Doctors", new[] { "Specialty_SpecialtyId" });
            AlterColumn("dbo.Doctors", "Specialty_SpecialtyId", c => c.Int());
            CreateIndex("dbo.Doctors", "Specialty_SpecialtyId");
            CreateIndex("dbo.Doctors", "DaysOfReceiving_DORId");
            AddForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties", "SpecialtyId");
            AddForeignKey("dbo.Doctors", "DaysOfReceiving_DORId", "dbo.DaysOfReceivings", "DORId");
        }
    }
}
