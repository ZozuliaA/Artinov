namespace HospitalAppointment.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Guid(nullable: false, identity: true),
                        StreetName = c.String(nullable: false),
                        ApartamentNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Appoinments",
                c => new
                    {
                        AppointmentId = c.Guid(nullable: false, identity: true),
                        RecordNumber = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(),
                        Doctor_DoctorId = c.Guid(),
                        Patient_PatientId = c.Guid(),
                        Room_RoomId = c.Guid(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .ForeignKey("dbo.Rooms", t => t.Room_RoomId)
                .Index(t => t.Doctor_DoctorId)
                .Index(t => t.Patient_PatientId)
                .Index(t => t.Room_RoomId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DaysOfReceiving_DORId = c.Guid(),
                        Specialty_SpecialtyId = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorId)
                .ForeignKey("dbo.DaysOfReceivings", t => t.DaysOfReceiving_DORId)
                .ForeignKey("dbo.Specialties", t => t.Specialty_SpecialtyId)
                .Index(t => t.DaysOfReceiving_DORId)
                .Index(t => t.Specialty_SpecialtyId);
            
            CreateTable(
                "dbo.DaysOfReceivings",
                c => new
                    {
                        DORId = c.Guid(nullable: false, identity: true),
                        Mondey = c.String(),
                        Tuesday = c.String(),
                        Wednesday = c.String(),
                        Thursday = c.String(),
                        Friday = c.String(),
                        Satarday = c.String(),
                        Sunday = c.String(),
                        TimeOfReceiving_TORId = c.Guid(),
                    })
                .PrimaryKey(t => t.DORId)
                .ForeignKey("dbo.TimeOfReceivings", t => t.TimeOfReceiving_TORId)
                .Index(t => t.TimeOfReceiving_TORId);
            
            CreateTable(
                "dbo.TimeOfReceivings",
                c => new
                    {
                        TORId = c.Guid(nullable: false, identity: true),
                        T10_00 = c.Int(nullable: false),
                        T10_20 = c.Int(nullable: false),
                        T10_40 = c.Int(nullable: false),
                        T11_00 = c.Int(nullable: false),
                        T12_00 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TORId);
            
            CreateTable(
                "dbo.Specialties",
                c => new
                    {
                        SpecialtyId = c.Int(nullable: false, identity: true),
                        SpecialtyName = c.String(),
                        SpecialtyDescription = c.String(),
                    })
                .PrimaryKey(t => t.SpecialtyId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 150),
                        SecondName = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 150),
                        Email = c.String(),
                        Login = c.String(maxLength: 30),
                        Password = c.String(maxLength: 32),
                        Address_AddressId = c.Guid(),
                        HistoryBook_HistoryBookId = c.Guid(),
                        Passport_PassportId = c.Guid(),
                        Phone_PhoneId = c.Guid(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .ForeignKey("dbo.HistoryBooks", t => t.HistoryBook_HistoryBookId)
                .ForeignKey("dbo.Passports", t => t.Passport_PassportId)
                .ForeignKey("dbo.Phones", t => t.Phone_PhoneId)
                .Index(t => t.Login, unique: true)
                .Index(t => t.Address_AddressId)
                .Index(t => t.HistoryBook_HistoryBookId)
                .Index(t => t.Passport_PassportId)
                .Index(t => t.Phone_PhoneId);
            
            CreateTable(
                "dbo.HistoryBooks",
                c => new
                    {
                        HistoryBookId = c.Guid(nullable: false, identity: true),
                        BookNumber = c.Int(nullable: false),
                        Comment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HistoryBookId);
            
            CreateTable(
                "dbo.Passports",
                c => new
                    {
                        PassportId = c.Guid(nullable: false, identity: true),
                        SeriesA = c.String(),
                        SeriesN = c.Int(nullable: false),
                        BDay = c.Int(nullable: false),
                        BMonth = c.Int(nullable: false),
                        BYear = c.Int(nullable: false),
                        DayIoP = c.Int(nullable: false),
                        YearIoP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PassportId);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneId = c.Guid(nullable: false, identity: true),
                        home = c.String(),
                        work = c.String(),
                        mobile = c.String(),
                    })
                .PrimaryKey(t => t.PhoneId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Guid(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        Type = c.String(),
                        Unavaible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appoinments", "Room_RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Patients", "Phone_PhoneId", "dbo.Phones");
            DropForeignKey("dbo.Patients", "Passport_PassportId", "dbo.Passports");
            DropForeignKey("dbo.Patients", "HistoryBook_HistoryBookId", "dbo.HistoryBooks");
            DropForeignKey("dbo.Appoinments", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "Address_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Doctors", "Specialty_SpecialtyId", "dbo.Specialties");
            DropForeignKey("dbo.Doctors", "DaysOfReceiving_DORId", "dbo.DaysOfReceivings");
            DropForeignKey("dbo.DaysOfReceivings", "TimeOfReceiving_TORId", "dbo.TimeOfReceivings");
            DropForeignKey("dbo.Appoinments", "Doctor_DoctorId", "dbo.Doctors");
            DropIndex("dbo.Patients", new[] { "Phone_PhoneId" });
            DropIndex("dbo.Patients", new[] { "Passport_PassportId" });
            DropIndex("dbo.Patients", new[] { "HistoryBook_HistoryBookId" });
            DropIndex("dbo.Patients", new[] { "Address_AddressId" });
            DropIndex("dbo.Patients", new[] { "Login" });
            DropIndex("dbo.DaysOfReceivings", new[] { "TimeOfReceiving_TORId" });
            DropIndex("dbo.Doctors", new[] { "Specialty_SpecialtyId" });
            DropIndex("dbo.Doctors", new[] { "DaysOfReceiving_DORId" });
            DropIndex("dbo.Appoinments", new[] { "Room_RoomId" });
            DropIndex("dbo.Appoinments", new[] { "Patient_PatientId" });
            DropIndex("dbo.Appoinments", new[] { "Doctor_DoctorId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Phones");
            DropTable("dbo.Passports");
            DropTable("dbo.HistoryBooks");
            DropTable("dbo.Patients");
            DropTable("dbo.Specialties");
            DropTable("dbo.TimeOfReceivings");
            DropTable("dbo.DaysOfReceivings");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appoinments");
            DropTable("dbo.Addresses");
        }
    }
}
