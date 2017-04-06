using System;
using System.Drawing;
using System.Windows.Forms;
using HADatabaseEntity;
using HospitalApointmentSystem.Client.ServiceApointment;

namespace HospitalApointmentSystem.Client
{
    public partial class UcAdmin : UserControl
    {
        private readonly Patient _currentUser;

        public UcAdmin(Patient logedPatient)
        {
            InitializeComponent();
            _currentUser = logedPatient;
        }

        private void UcAdmin_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        public void RefreshForm()
        {
            FillSpecialtyListView();
            FillRoomElements();
            FillCbChoseSpesialty();
            FillRoomListView();
            FillPatientListView();
            FillDoctorListView();
        }

        private void FillSpecialtyListView()
        {
            lvSpecialty.Items.Clear();

            using (var client = new HaServiceClient())
            {
                var specialty = client.GetSpecialties();

                foreach (var item in specialty)
                {
                    //var spesialty = client.GetSpecialtyById(item.SpecialtyId);
                    ListViewItem lvItem = new ListViewItem(item.SpecialtyId.ToString());
                    lvItem.SubItems.Add(item.SpecialtyName);
                    lvSpecialty.Items.Add(lvItem);
                }
            }
        }

        private void FillDoctorListView()
        {
            lvDoctors.Items.Clear();

            using (var client = new HaServiceClient())
            {
                Doctor[] doors = client.GetDoctors();


                foreach (var item in doors)
                {
                    var spesialty = client.GetSpecialtyById(item.Specialty.SpecialtyId);
                    ListViewItem lvItem = new ListViewItem(spesialty.SpecialtyName);
                    lvItem.SubItems.Add(item.LastName); //.ToString());
                    lvItem.SubItems.Add(item.FirstName); //.ToString());
                    lvItem.SubItems.Add(item.SecondName);
                    lvItem.SubItems.Add(item.LoginD);
                    lvItem.SubItems.Add(item.DoctorId.ToString());
                    lvDoctors.Items.Add(lvItem);
                }
            }
        }

        private void FillPatientListView()
        {
            lvPatients.Items.Clear();

            using (var client = new HaServiceClient())
            {
                var patients = client.GetAllPatients();

                foreach (var item in patients)
                {
                    ListViewItem lvItem = new ListViewItem(item.FirstName);
                    lvItem.SubItems.Add(item.LastName); //.ToString());
                    lvItem.SubItems.Add(item.SecondName);
                    lvItem.SubItems.Add(item.Email);
                    lvItem.SubItems.Add(item.Login);
                    lvItem.SubItems.Add(item.Phone.home);
                    lvItem.SubItems.Add(item.Phone.mobile);
                    lvItem.SubItems.Add(item.Phone.work);
                    lvItem.SubItems.Add(item.HistoryBook.BookNumber.ToString());
                    lvItem.SubItems.Add(item.Address.StreetName.ToString());
                    lvItem.SubItems.Add(item.PatientId.ToString());
                    lvPatients.Items.Add(lvItem);
                }
            }
        }

        private void FillRoomElements()
        {
            labelRoomError.Text = "";
            tbRoomNumber.Clear();
            tbRoomType.Clear();
            rbNo.Select();
        }

        private void FillCbChoseSpesialty()
        {
            cbChoseSpesialty.Items.Clear();
            using (var client = new HaServiceClient())
            {
                foreach (var item in client.GetSpecialties())
                {
                    cbChoseSpesialty.Items.Add(item.SpecialtyName);
                }
            }
        }

        private void btAddDoc_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.FirstName = tbDocName.Text;
            doc.LastName = tbLastName.Text;
            doc.SecondName = tbSecondName.Text;
            doc.LoginD = tbDocLogin.Text;
            doc.Role = "Doctor";


            DaysOfReceiving dor = new DaysOfReceiving();
            if (clbDay.GetItemCheckState(0) == CheckState.Checked) dor.Mondey = true;
            if (clbDay.GetItemCheckState(1) == CheckState.Checked) dor.Tuesday = true;
            if (clbDay.GetItemCheckState(2) == CheckState.Checked) dor.Wednesday = true;
            if (clbDay.GetItemCheckState(3) == CheckState.Checked) dor.Thursday = true;
            if (clbDay.GetItemCheckState(4) == CheckState.Checked) dor.Friday = true;
            if (clbDay.GetItemCheckState(5) == CheckState.Checked) dor.Satarday = true;
            if (clbDay.GetItemCheckState(6) == CheckState.Checked) dor.Sunday = true;

            TimeOfReceiving time = new TimeOfReceiving();
            if (clbTime.GetItemCheckState(0) == CheckState.Checked) time.T10_00 = true;
            if (clbTime.GetItemCheckState(1) == CheckState.Checked) time.T10_20 = true;
            if (clbTime.GetItemCheckState(2) == CheckState.Checked) time.T10_40 = true;
            if (clbTime.GetItemCheckState(3) == CheckState.Checked) time.T11_00 = true;
            if (clbTime.GetItemCheckState(4) == CheckState.Checked) time.T12_00 = true;

            dor.TimeOfReceiving = time;
            doc.DaysOfReceiving = dor;

            using (var client = new HaServiceClient())
            {
                //doc.Specialty = client.GetSpecialtyByName(cbChoseSpesialty.SelectedItem.ToString());//. SelectedText);
                doc.HashD = client.CreateHashOnServer(tbDocPassword.Text);
                client.AddDoctorOnContext(doc,
                    client.GetSpecialtyByName(cbChoseSpesialty.SelectedItem.ToString()).SpecialtyId);
            }
            FillDoctorListView();
        }


        private void FillRoomListView()
        {
            lvRooms.Items.Clear();

            using (var client = new HaServiceClient())
            {
                var rooms = client.GetRooms();

                foreach (var item in rooms)
                {
                    ListViewItem lvItem = new ListViewItem(item.RoomNumber.ToString());
                    lvItem.SubItems.Add(item.Type); //.ToString());
                    lvItem.SubItems.Add(item.Unavaible.ToString());
                    lvItem.SubItems.Add(item.RoomId.ToString());
                    lvRooms.Items.Add(lvItem);
                }
            }
        }

        private void btAddRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.RoomNumber = int.Parse(tbRoomNumber.Text);
            room.Type = tbRoomType.Text;

            if (rbYes.Checked == true) room.Unavaible = true;
            else room.Unavaible = false;
            using (var client = new HaServiceClient())
            {
                client.InsertRoom(room);
            }
            tsslRoom.Text = "Room added";
            RefreshForm();
        }

        private void btRoomEdit_Click(object sender, EventArgs e)
        {
            int selectedRoomsCount = lvRooms.SelectedItems.Count;
            if (selectedRoomsCount != 0)
            {
                ListViewItem selectedRoom = lvRooms.SelectedItems[0];
                Guid selectedId = Guid.Parse(selectedRoom.SubItems[3].Text);
                EditRoom editRoomForm = new EditRoom(selectedId);
                if (editRoomForm.ShowDialog() == DialogResult.OK)
                {
                    FillRoomListView();
                }
            }
        }

        private void CrealPatentTbFields()
        {
            tbpName.Text = "";
            tbpPoB.Text = "";
            tbpSurName.Text = "";
            tbpEmail.Text = "";
            tbpLogin.Text = "";
            tbpHomePhone.Text = "";
            tbpMobilePhone.Text = "";
            tbpWorkPhone.Text = "";
            tbpBday.Text = "";
            tbpBmonth.Text = "";
            tbpByear.Text = "";
            tbpDayIoP.Text = "";
            tbpPassSereise.Text = "";
            tbpSereiseNumber.Text = "";
            tbpYearIoP.Text = "";
            tbpAn.Text = "";
            tbpStreet.Text = "";
            tbpHisBookNum.Text = "";
        }

        private void btpAddPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.FirstName = tbpName.Text;
            patient.SecondName = tbpPoB.Text;
            patient.LastName = tbpSurName.Text;
            patient.Email = tbpEmail.Text;
            patient.Login = tbpLogin.Text;
            //patient.Hash = "hash";
            patient.Role = "User";

            Phone phone = new Phone();
            phone.home = tbpHomePhone.Text;
            phone.mobile = tbpMobilePhone.Text;
            phone.work = tbpWorkPhone.Text;

            patient.Phone = phone;

            Passport passport = new Passport();
            passport.BDay = int.Parse(tbpBday.Text);
            passport.BMonth = int.Parse(tbpBmonth.Text);
            passport.BYear = int.Parse(tbpByear.Text);
            passport.DayIoP = int.Parse(tbpDayIoP.Text);
            passport.SeriesA = tbpPassSereise.Text;
            passport.SeriesN = int.Parse(tbpSereiseNumber.Text);
            passport.YearIoP = int.Parse(tbpYearIoP.Text);

            patient.Passport = passport;

            Address address = new Address();
            address.ApartamentNumber = int.Parse(tbpAn.Text);
            address.StreetName = tbpStreet.Text;

            patient.Address = address;

            HistoryBook historyBook = new HistoryBook();
            historyBook.BookNumber = int.Parse(tbpHisBookNum.Text);

            patient.HistoryBook = historyBook;

            using (var client = new HaServiceClient())
            {
                patient.Hash = client.CreateHashOnServer("111111");
                client.AddPatient(patient);
                CrealPatentTbFields();
            }

            FillPatientListView();
        }

        private void btRoomDelete_Click(object sender, EventArgs e)
        {
            int selectedRoomsCount = lvRooms.SelectedItems.Count;
            if (selectedRoomsCount != 0)
            {
                ListViewItem selectedRoom = lvRooms.SelectedItems[0];
                Guid selectedId = Guid.Parse(selectedRoom.SubItems[3].Text);
                var confirmResult = MessageBox.Show("Are you sure to delete this room?\nRoom Number " + int.Parse(selectedRoom.SubItems[0].Text), "Confirm edit!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var client = new HaServiceClient())
                    {
                        client.DeleteRoomById(selectedId);
                    }
                    tsslRoom.Text = "Room deleted";
                    FillRoomListView();
                }
                else
                {
                    //DialogResult = DialogResult.None;
                    return;
                }
                
            }
        }

        private void btpDelete_Click(object sender, EventArgs e)
        {
            int selectedPatientsCount = lvPatients.SelectedItems.Count;
            if (selectedPatientsCount != 0)
            {
                ListViewItem selectedPatient = lvPatients.SelectedItems[0];
                var ddd = selectedPatient.SubItems[10].Text;
                Guid selectedId = Guid.Parse(selectedPatient.SubItems[10].Text);
                var confirmResult = MessageBox.Show("Are you sure to delete this patient?\nPatient login " + selectedPatient.SubItems[4].Text, "Confirm edit!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var client = new HaServiceClient())
                    {
                        client.DeletePatient(selectedId);
                    }
                    FillPatientListView();
                }
                else
                {
                    //DialogResult = DialogResult.None;
                    return;
                }
            }
        }

        private void btdDelete_Click(object sender, EventArgs e)
        {
            int selectedDoctorssCount = lvDoctors.SelectedItems.Count;
            if (selectedDoctorssCount != 0)
            {
                ListViewItem selectedDoctor = lvDoctors.SelectedItems[0];
                //var ddd = selectedPatient.SubItems[10].Text;
                Guid selectedId = Guid.Parse(selectedDoctor.SubItems[5].Text);
                var confirmResult = MessageBox.Show("Are you sure to delete this Doctor?\nDoctor login " + selectedDoctor.SubItems[3].Text, "Confirm edit!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var client = new HaServiceClient())
                    {
                        client.DeleteDoctorById(selectedId);
                    }
                    FillDoctorListView();
                }
                else
                {
                    //DialogResult = DialogResult.None;
                    return;
                }
            }
        }

        private void tbRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbSname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))//)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btSpecialtyAdd_Click(object sender, EventArgs e)
        {
            if (tbSname.Text.Trim().Length == 0)
            {
                tsslSpecialty.ForeColor = Color.Crimson;
                tsslSpecialty.Text = "Invalid data";
                return;
            }
            using (var client = new HaServiceClient())
            {
                Specialty specialty = new Specialty();
                var allsp = client.GetSpecialties();
                foreach (var item in allsp)
                {
                    if (item.SpecialtyName == tbSname.Text.Trim())
                    {
                        tsslSpecialty.ForeColor = Color.Crimson;
                        tsslSpecialty.Text = "Specialty alredy exist";
                        return;
                    }
                }

                specialty.SpecialtyName = tbSname.Text.Trim();
                client.AddSpecialty(specialty);

                FillSpecialtyListView();
                FillCbChoseSpesialty();
                tsslSpecialty.ForeColor = Color.DarkGreen;
                tsslSpecialty.Text = "Specialty added";
                tbSname.Text = "";
            }
        }

        private void btSpecialtyDelete_Click(object sender, EventArgs e)
        {
            int selectedDoctorssCount = lvSpecialty.SelectedItems.Count;
            if (selectedDoctorssCount != 0)
            {
                ListViewItem selectedSpecialty = lvSpecialty.SelectedItems[0];
                int selectedId = int.Parse(selectedSpecialty.SubItems[0].Text);
                var confirmResult = MessageBox.Show("Are you sure to delete this Specialty?\nSpecialty :  " + selectedSpecialty.SubItems[1].Text, "Confirm delete!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var client = new HaServiceClient())
                    {
                        Specialty specialty = client.GetSpecialtyById(selectedId);
                        var getAllDocBySpecialty = client.GetDoctorsBySpecialy(selectedId);
                        if (getAllDocBySpecialty.Length != 0)
                        {
                            tsslSpecialty.ForeColor = Color.Crimson;
                            tsslSpecialty.Text = "Unable to delete, doctors with this sp exist";
                            return;
                        }
                        client.DeleteSpecialty(specialty);
                        FillSpecialtyListView();
                        FillCbChoseSpesialty();
                        tsslSpecialty.ForeColor = Color.Green;
                        tsslSpecialty.Text = "Specialty sucssesfuly deleted";
                    }
                    
                }
                else
                {
                    //DialogResult = DialogResult.None;
                    return;
                }
            }
        }

        private void btSpesialtyEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
