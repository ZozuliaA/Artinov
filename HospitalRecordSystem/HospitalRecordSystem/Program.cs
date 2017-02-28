using System;
using System.Windows.Forms;
using HADatabaseEntity;
using HospitalAppointment.DataAccess;

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
            /*using (var ctx = new HaContext())
            {
                Room room = new Room() { RoomNumber = 1 , Type = "noType", Unavaible = false};

                ctx.Rooms.Add(room);
                ctx.SaveChanges();
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizatiomForm());
         }
    }
}
