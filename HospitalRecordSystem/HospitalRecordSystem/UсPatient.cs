using System;
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

            FillListView();
        }

        private void cbChoseSpesialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            rb1000.Refresh();
            rb1020.Refresh();
            rb1040.Refresh();
            rb1100.Refresh();
            rb1200.Refresh();

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


        public void RefreshForm()
        {
            FillListView();
        }

        private void FillListView()
        {
            lvPatientApp.Items.Clear();

            //IQueryable<Appoinment> appoinments;
            using (var client = new HaServiceClient())
            {
                var appoinments = client.GetAppoinments();

                foreach (var item in appoinments)
                {
                    ListViewItem lvItem = new ListViewItem(item.Date.ToShortDateString());//(i.ToString());
                    //lvItem.SubItems.Add(appoinments[i].RecordNumber.ToString());
                    //lvItem.SubItems.Add(item.Date.T());
                    lvItem.SubItems.Add(item.Time);//.ToString());
                    lvItem.SubItems.Add(item.Doctor.FirstName);
                    lvItem.SubItems.Add(item.Room.RoomNumber.ToString());
                    //+ appoinments[i].Doctor.LastName);

                    lvPatientApp.Items.Add(lvItem);
                }
                int countAppointments = appoinments.Length;

                /*for (int i = 0; i < countAppointments; i++)
                {
                    ListViewItem lvItem = new ListViewItem();//(i.ToString());
                    //lvItem.SubItems.Add(appoinments[i].RecordNumber.ToString());
                    lvItem.SubItems.Add(appoinments[i].Date.ToString());
                    lvItem.SubItems.Add(appoinments[i].Time);//.ToString());
                    lvItem.SubItems.Add(appoinments[i].Room.RoomNumber.ToString());
                    lvItem.SubItems.Add(appoinments[i].Doctor.FirstName);//+ appoinments[i].Doctor.LastName);

                    lvPatientApp.Items.Add(lvItem);
                }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (var client = new HaServiceClient())
            {
                
            }
        }

        private void btCanselApp_Click(object sender, EventArgs e)
        {
            int selectedAnimal = lvPatientApp.SelectedItems.Count;
            if (selectedAnimal != 0)
            {
                ListViewItem selectedItem = lvPatientApp.SelectedItems[0];
                Guid selectedId = Guid.Parse(selectedItem.SubItems[3].Text);
                using (var client = new HaServiceClient())
                {
                    client.DeleteAppointmentById(selectedId);
                }
                
                FillListView();
            }
        }
    }
}
