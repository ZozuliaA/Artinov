using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HADatabaseEntity;
using HospitalApointmentSystem.Client.ServiceApointment;

namespace HospitalApointmentSystem.Client
{
    public partial class UсPatient : UserControl
    {
        private readonly Patient _currentUser;
        private Doctor _doctor;
         
        public UсPatient(Patient logedPatient)
        {
            InitializeComponent();
            _currentUser = logedPatient;
        }

        private void UсPatient_Load(object sender, EventArgs e)
        {
            cbChoseDoctor.Enabled = false;
            mcThisMonth.Enabled = false;
            rb1000.Enabled = false;
            rb1020.Enabled = false;
            rb1040.Enabled = false;
            rb1100.Enabled = false;
            rb1200.Enabled = false;
            using (var client = new HaServiceClient())
            {
                foreach (var item in client.GetSpecialties())
                {
                    cbChoseSpesialty.Items.Add(item.SpecialtyName);
                }
            }
        }

        private void cbChoseSpesialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            mcThisMonth.Enabled = false;
            rb1000.Enabled = false;
            rb1020.Enabled = false;
            rb1040.Enabled = false;
            rb1100.Enabled = false;
            rb1200.Enabled = false;

            using (var client = new HaServiceClient())
            {
                var check =
                    client.GetDoctorsBySpecialy(client.GetSpecialtyIdByName(cbChoseSpesialty.SelectedItem.ToString()));
                if (check.Length > 0) 
                {
                    cbChoseDoctor.DataSource =
                        client.GetDoctorsBySpecialy(client.GetSpecialtyIdByName(cbChoseSpesialty.SelectedItem.ToString()));
                    cbChoseDoctor.DisplayMember = "FirstName";
                    cbChoseDoctor.ValueMember = "DoctorId";
                }
                else
                {
                    cbChoseDoctor.Enabled = false;
                    mcThisMonth.Enabled = false;
                    rb1000.Enabled = false;
                    rb1020.Enabled = false;
                    rb1040.Enabled = false;
                    rb1100.Enabled = false;
                    rb1200.Enabled = false;
                }
                cbChoseDoctor.Enabled = true;

            }
        }

        private void cbChoseDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            rb1000.Enabled = false;
            rb1020.Enabled = false;
            rb1040.Enabled = false;
            rb1100.Enabled = false;
            rb1200.Enabled = false;

            //Doctor d;
            using (var client = new HaServiceClient())
            {
                var item = cbChoseDoctor.SelectedItem as Doctor;

                _doctor = client.GetDoctorById(item.DoctorId); // cbChoseDoctor.SelectedItem.V  Value.ToString());
            }

            mcThisMonth.Enabled = true;

            mcThisMonth.RemoveAllBoldedDates();
            int day = 16;
            DateTime today = new DateTime(2017, 3, day);
            DateTime endDate = new DateTime(2017, 3, 31);

            while (today <= endDate)
            {
                if (today.DayOfWeek == DayOfWeek.Monday && _doctor.DaysOfReceiving.Mondey == true)
                {
                    mcThisMonth.AddBoldedDate(today);
                }
                if (today.DayOfWeek == DayOfWeek.Tuesday && _doctor.DaysOfReceiving.Tuesday == true)
                {
                    mcThisMonth.AddBoldedDate(today);
                }
                if (today.DayOfWeek == DayOfWeek.Wednesday && _doctor.DaysOfReceiving.Wednesday == true)
                {
                    mcThisMonth.AddBoldedDate(today);
                }
                if (today.DayOfWeek == DayOfWeek.Friday && _doctor.DaysOfReceiving.Friday == true)
                {
                    mcThisMonth.AddBoldedDate(today);
                }
                if (today.DayOfWeek == DayOfWeek.Saturday && _doctor.DaysOfReceiving.Satarday == true)
                {
                    mcThisMonth.AddBoldedDate(today);
                }
                if (today.DayOfWeek == DayOfWeek.Sunday && _doctor.DaysOfReceiving.Sunday == true)
                {
                    mcThisMonth.AddBoldedDate(today);
                }
                ++day;
                if (day == 32)
                {
                    break;
                }
                today = new DateTime(2017, 3, day);
            }
            mcThisMonth.UpdateBoldedDates();
            
        }

        private void mcThisMonth_DateSelected(object sender, DateRangeEventArgs e)
        {
            //_doctor.DaysOfReceiving.TimeOfReceiving.T10_00;
            rb1000.Enabled = true;
            rb1020.Enabled = true;
            rb1040.Enabled = true;
            rb1100.Enabled = true;
            rb1200.Enabled = true;
            tbSelectedData.Text = mcThisMonth.SelectionRange.Start.ToShortDateString();
            using (var client = new HaServiceClient())
            {
                foreach (var item in client.GetAppoinmentsByDate(mcThisMonth.SelectionRange.Start))
                {
                    if (item.Time == "10:00") rb1000.Enabled = false;
                    if (item.Time == "10:20") rb1020.Enabled = false;
                    if (item.Time == "10:40") rb1040.Enabled = false;
                    if (item.Time == "11:00") rb1100.Enabled = false;
                    if (item.Time == "12:00") rb1200.Enabled = false;
                    
                    //cbChoseSpesialty.Items.Add(item.SpecialtyName);
                }
            }
        }
    }
}
