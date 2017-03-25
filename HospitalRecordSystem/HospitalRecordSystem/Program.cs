using System;
using System.Windows.Forms;

namespace HospitalApointmentSystem.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*using (HaServiceClient ad = new HaServiceClient())
            {
                Room r1 = new Room()
                {
                    RoomNumber = 77,
                    Type = "nnn",
                    Unavaible = false
                };
                ad.InsertRoom(r1);
                var rooms = ad.GetRooms();
                foreach (var row in rooms)
                {
                    MessageBox.Show(row.Type);
                }*/
                /*Patient patient = new Patient();
                patient.FirstName = "Andr";
                patient.SecondName = "me";
                patient.LastName = "dw";
                patient.Email = "sas@ds";
                patient.Login = "admin";
                //patient.Hash = "hash";
                patient.Role = "admin";

                Phone phone = new Phone();
                phone.home = "122";
                phone.mobile = "m12";
                phone.work = "w43";

                patient.Phone = phone;

                Passport passport = new Passport();
                passport.BDay = 22;
                passport.BMonth = 3;
                passport.BYear = 1234;
                passport.DayIoP = 1333;
                passport.SeriesA = "AB";
                passport.SeriesN = 4444;
                passport.YearIoP = 12344555;

                patient.Passport = passport;

                Address address = new Address();
                address.ApartamentNumber = 54;
                address.StreetName = "My Street";

                patient.Address = address;

                HistoryBook historyBook = new HistoryBook();
                historyBook.BookNumber = 1;

                patient.HistoryBook = historyBook;
                ad.InsertPatient(patient, "admin");
            }*/
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizatiomForm());
        }
    }
}
