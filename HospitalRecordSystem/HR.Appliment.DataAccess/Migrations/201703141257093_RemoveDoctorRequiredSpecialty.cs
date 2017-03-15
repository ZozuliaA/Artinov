namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDoctorRequiredSpecialty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties");
            DropIndex("dbo.Doctors", new[] { "Specialty_SpecialtyId" });
            AlterColumn("dbo.Doctors", "Specialty_SpecialtyId", c => c.Int());
            CreateIndex("dbo.Doctors", "Specialty_SpecialtyId");
            AddForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties", "SpecialtyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties");
            DropIndex("dbo.Doctors", new[] { "Specialty_SpecialtyId" });
            AlterColumn("dbo.Doctors", "Specialty_SpecialtyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "Specialty_SpecialtyId");
            AddForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties", "SpecialtyId", cascadeDelete: true);
        }
    }
}
