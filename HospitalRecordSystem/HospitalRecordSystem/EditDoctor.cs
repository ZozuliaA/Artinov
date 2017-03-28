using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HADatabaseEntity;

namespace HospitalApointmentSystem.Client
{
    public partial class EditDoctor : Form
    {
        private readonly Doctor _doctor;
        public EditDoctor(Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
        }

        private void EditDoctor_Load(object sender, EventArgs e)
        {
            tbEditDocName.Text = _doctor.FirstName;
            tbEditDocLastName.Text = _doctor.LastName;
            tbEditDocSecName.Text = _doctor.SecondName;
            if (_doctor.DaysOfReceiving.Mondey == true)  clbDay.SetItemChecked(0, true);   else clbDay.SetItemChecked(0, false);
            if (_doctor.DaysOfReceiving.Tuesday == true)  clbDay.SetItemChecked(1, true);   else clbDay.SetItemChecked(1, false);
            if (_doctor.DaysOfReceiving.Wednesday == true)  clbDay.SetItemChecked(2, true);   else clbDay.SetItemChecked(2, false);
            if (_doctor.DaysOfReceiving.Thursday == true)  clbDay.SetItemChecked(3, true);   else clbDay.SetItemChecked(3, false);
            if (_doctor.DaysOfReceiving.Friday == true)  clbDay.SetItemChecked(4, true);   else clbDay.SetItemChecked(4, false);
            if (_doctor.DaysOfReceiving.Satarday == true)  clbDay.SetItemChecked(5, true);   else clbDay.SetItemChecked(5, false);
            if (_doctor.DaysOfReceiving.Sunday == true)  clbDay.SetItemChecked(6, true);   else clbDay.SetItemChecked(6, false);

            if (_doctor.DaysOfReceiving.TimeOfReceiving.T10_00 == true)  clbTime.SetItemChecked(0, true);   else clbTime.SetItemChecked(0, false);
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T10_20 == true)  clbTime.SetItemChecked(1, true);   else clbTime.SetItemChecked(1, false);
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T10_40 == true)  clbTime.SetItemChecked(2, true);   else clbTime.SetItemChecked(2, false);
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T11_00 == true)  clbTime.SetItemChecked(3, true);   else clbTime.SetItemChecked(3, false);
            if (_doctor.DaysOfReceiving.TimeOfReceiving.T12_00 == true)  clbTime.SetItemChecked(4, true);   else clbTime.SetItemChecked(4, false);

        }
    }
}
