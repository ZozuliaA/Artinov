namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnFromHaContext : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appoinments", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Appoinments", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appoinments", "Room_RoomId", "dbo.Rooms");
            DropIndex("dbo.Appoinments", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.Appoinments", new[] { "Patient_PatientId" });
            DropIndex("dbo.Appoinments", new[] { "Room_RoomId" });
            AlterColumn("dbo.Appoinments", "Doctor_DoctorId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Appoinments", "Patient_PatientId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Appoinments", "Room_RoomId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Appoinments", "Doctor_DoctorId");
            CreateIndex("dbo.Appoinments", "Patient_PatientId");
            CreateIndex("dbo.Appoinments", "Room_RoomId");
            AddForeignKey("dbo.Appoinments", "Doctor_DoctorId", "dbo.Doctors", "DoctorId", cascadeDelete: true);
            AddForeignKey("dbo.Appoinments", "Patient_PatientId", "dbo.Patients", "PatientId", cascadeDelete: true);
            AddForeignKey("dbo.Appoinments", "Room_RoomId", "dbo.Rooms", "RoomId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appoinments", "Room_RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Appoinments", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appoinments", "Doctor_DoctorId", "dbo.Doctors");
            DropIndex("dbo.Appoinments", new[] { "Room_RoomId" });
            DropIndex("dbo.Appoinments", new[] { "Patient_PatientId" });
            DropIndex("dbo.Appoinments", new[] { "Doctor_DoctorId" });
            AlterColumn("dbo.Appoinments", "Room_RoomId", c => c.Guid());
            AlterColumn("dbo.Appoinments", "Patient_PatientId", c => c.Guid());
            AlterColumn("dbo.Appoinments", "Doctor_DoctorId", c => c.Guid());
            CreateIndex("dbo.Appoinments", "Room_RoomId");
            CreateIndex("dbo.Appoinments", "Patient_PatientId");
            CreateIndex("dbo.Appoinments", "Doctor_DoctorId");
            AddForeignKey("dbo.Appoinments", "Room_RoomId", "dbo.Rooms", "RoomId");
            AddForeignKey("dbo.Appoinments", "Patient_PatientId", "dbo.Patients", "PatientId");
            AddForeignKey("dbo.Appoinments", "Doctor_DoctorId", "dbo.Doctors", "DoctorId");
        }
    }
}
