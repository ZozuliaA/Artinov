using System;
using System.Linq;
using System.Windows.Forms;
using HADatabaseEntity;
using HospitalApointmentSystem.Client.ServiceApointment;

namespace HospitalApointmentSystem.Client
{
    public partial class UсPatient : UserControl
    {
        private readonly Patient _currentUser;
        private Doctor _doctor;
        private int freeRoom;
         
        public UсPatient(Patient logedPatient)
        {
            InitializeComponent();
            _currentUser = logedPatient;
        }

        private void UсPatient_Load(object sender, EventArgs e)
        {
            //mcThisMonth.MinDate.
            cbChoseDoctor.Enabled = false;
            mcThisMonth.Enabled = false;
            RadioButtonsEnabledFalse();

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
            ResetRadioButtons();

            mcThisMonth.Enabled = false;
            RadioButtonsEnabledFalse();

            using (var client = new HaServiceClient())
            {
                var check = client.GetDoctorsBySpecialy(client.GetSpecialtyIdByName(cbChoseSpesialty.SelectedItem.ToString()));
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
                    //mcThisMonth.Enabled = false;
                    //RadioButtonsEnabledFalse();
                }
                cbChoseDoctor.Enabled = true;
            }
        }

        private void RadioButtonsEnabledFalse()
        {
            rb1000.Enabled = false;
            rb1020.Enabled = false;
            rb1040.Enabled = false;
            rb1100.Enabled = false;
            rb1200.Enabled = false;
        }

        private void ResetRadioButtons()
        {
            rb1000.Checked = false;
            rb1020.Checked = false;
            rb1040.Checked = false;
            rb1100.Checked = false;
            rb1200.Checked = false;
        }

        private void cbChoseDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRadioButtons();
            RadioButtonsEnabledFalse();

            using (var client = new HaServiceClient())
            {
                var item = cbChoseDoctor.SelectedItem as Doctor;

                _doctor = client.GetDoctorById(item.DoctorId); // cbChoseDoctor.SelectedItem.V  Value.ToString());
            }

            mcThisMonth.Enabled = true;

            mcThisMonth.RemoveAllBoldedDates();
            int day;
            //DateTime today = new DateTime(2017, 3, day);
            DateTime today = DateTime.Now;
            day = int.Parse(today.Day.ToString());
            DateTime endDate = today.AddMonths(1);

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
                today = today.AddDays(1);
            }
            mcThisMonth.UpdateBoldedDates();
            
        }

        private void mcThisMonth_DateSelected(object sender, DateRangeEventArgs e)
        {
            ResetRadioButtons();
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

            using (var client = new HaServiceClient())
            {
                var appoinments = client.GetAppoinments();

                foreach (var item in appoinments)
                {
                    ListViewItem lvItem = new ListViewItem(item.Date.ToShortDateString());
                    lvItem.SubItems.Add(item.Time);
                    lvItem.SubItems.Add(item.Doctor.FirstName);
                    lvItem.SubItems.Add(item.Room.RoomNumber.ToString());
                    lvPatientApp.Items.Add(lvItem);
                }
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

        private void btAddAppointment_Click(object sender, EventArgs e)
        {
            Appoinment appoinment = new Appoinment();
            appoinment.Date = mcThisMonth.SelectionRange.Start.Date;
            appoinment.Patient = _currentUser;
            appoinment.Doctor = _doctor;


            using (var client = new HaServiceClient())
            {
                var rooms = client.GetRooms();
                int avRoomNum;
                int allRoomsCount = rooms.Length;
                int roomCount=0;
                //List<string> = 
                foreach (var item in client.GetAppoinmentsByDate(mcThisMonth.SelectionRange.Start).Where(t => t.Time.Equals("10:00")))
                {
                    foreach (var room in rooms)
                    {
                        if (room.RoomNumber == item.Room.RoomNumber)
                        {
                            
                        }
                    }
                }
            }

            
            //appoinment.Room

        }
    }
}
