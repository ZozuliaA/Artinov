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
    public partial class UcDoctor : UserControl
    {
        private Doctor _doctor;
        public UcDoctor(Doctor logedDoctor)
        {
            InitializeComponent();
            _doctor = logedDoctor;
        }

        private void UcDoctor_Load(object sender, EventArgs e)
        {
            RefreshUcDoc();
        }

        public void RefreshUcDoc()
        {
            FillDoctorListView();
            //Doctor doc = new Doctor();
            using (var client = new HaServiceClient())
            {
                _doctor = client.GetDoctorById(_doctor.DoctorId);
            }
            labelDocName.Text = _doctor.FirstName;
            labelWorkDays.Text = "";

            if (_doctor.DaysOfReceiving.Mondey == true) labelWorkDays.Text = "M";
            if (_doctor.DaysOfReceiving.Tuesday == true) labelWorkDays.Text += "  T";
            if (_doctor.DaysOfReceiving.Wednesday == true) labelWorkDays.Text += "  W";
            if (_doctor.DaysOfReceiving.Thursday == true) labelWorkDays.Text += "  Th";
            if (_doctor.DaysOfReceiving.Friday == true) labelWorkDays.Text += "  F";
            if (_doctor.DaysOfReceiving.Satarday == true) labelWorkDays.Text += "  St";
            if (_doctor.DaysOfReceiving.Sunday == true) labelWorkDays.Text += "  S";

            labelTimeDoc.Text = "";
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T10_00 == true) labelTimeDoc.Text = "10:00";
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T10_20 == true) labelTimeDoc.Text += "  10:20";
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T10_40 == true) labelTimeDoc.Text += "  10:40";
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T11_00 == true) labelTimeDoc.Text += "  11:00";
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T12_00 == true) labelTimeDoc.Text += "  12:00";
        }

        private void btEditDoc_Click(object sender, EventArgs e)
        {
            EditDoctor editDoctor = new EditDoctor(_doctor);
            if (editDoctor.ShowDialog() == DialogResult.OK)
            {
                RefreshUcDoc();
            }
        }

        private void FillDoctorListView()
        {
            lvDoc.Items.Clear();

            using (var client = new HaServiceClient())
            {
                var appoinments = client.GetAppoinmentsByDate(DateTime.Today).Where(id => id.Doctor.DoctorId.Equals(_doctor.DoctorId));
                if (appoinments.Count() <  1)
                {
                    return;
                }
                foreach (var item in appoinments)
                {
                    ListViewItem lvItem = new ListViewItem(item.Patient.FirstName);
                    lvItem.SubItems.Add(item.Patient.SecondName);
                    lvItem.SubItems.Add(item.Patient.LastName);
                    lvItem.SubItems.Add(item.Patient.HistoryBook.BookNumber.ToString());
                    //lvItem.SubItems.Add(item.Patient.HistoryBook.BookNumber.ToString());
                    lvItem.SubItems.Add(item.Room.RoomNumber.ToString());
                    lvItem.SubItems.Add(item.Time);
                    lvDoc.Items.Add(lvItem);
                }
            }
        }
    }
}
