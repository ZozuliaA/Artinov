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

namespace HospitalApointmentSystem.Client
{
    public partial class UcDoctor : UserControl
    {
        private readonly Doctor _doctor;
        public UcDoctor(Doctor logedDoctor)
        {
            InitializeComponent();
            _doctor = logedDoctor;
        }

        private void UcDoctor_Load(object sender, EventArgs e)
        {
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
            editDoctor.Show();
        }
    }
}
