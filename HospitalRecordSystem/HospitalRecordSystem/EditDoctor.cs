using System;
using System.Windows.Forms;
using HADatabaseEntity;
using HospitalApointmentSystem.Client.ServiceApointment;

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

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            Doctor editDoctor = _doctor;
            editDoctor.FirstName = tbEditDocName.Text.Trim();
            editDoctor.LastName = tbEditDocLastName.Text.Trim();
            editDoctor.SecondName = tbEditDocSecName.Text.Trim();
            DaysOfReceiving dor = new DaysOfReceiving();
            TimeOfReceiving time = new TimeOfReceiving();
            dor = editDoctor.DaysOfReceiving;
            int timeCount = 0;
            int dayCount = 0;
            if (clbDay.GetItemCheckState(0) == CheckState.Checked) { dor.Mondey = true; dayCount++;    } else clbDay.SetItemChecked(0, false);
            if (clbDay.GetItemCheckState(1) == CheckState.Checked) { dor.Tuesday = true; dayCount++;   } else clbDay.SetItemChecked(1, false);
            if (clbDay.GetItemCheckState(2) == CheckState.Checked) { dor.Wednesday = true; dayCount++; } else clbDay.SetItemChecked(2, false);
            if (clbDay.GetItemCheckState(3) == CheckState.Checked) { dor.Thursday = true; dayCount++;  } else clbDay.SetItemChecked(3, false);
            if (clbDay.GetItemCheckState(4) == CheckState.Checked) { dor.Friday = true; dayCount++;    } else clbDay.SetItemChecked(4, false);
            if (clbDay.GetItemCheckState(5) == CheckState.Checked) { dor.Satarday = true; dayCount++;  } else clbDay.SetItemChecked(5, false);
            if (clbDay.GetItemCheckState(6) == CheckState.Checked) { dor.Sunday = true; dayCount++;    } else clbDay.SetItemChecked(6, false);

            time = editDoctor.DaysOfReceiving.TimeOfReceiving;
            if (clbTime.GetItemCheckState(0) == CheckState.Checked) { time.T10_00 = true; timeCount++; } else clbTime.SetItemChecked(0, false);
            if (clbTime.GetItemCheckState(1) == CheckState.Checked) { time.T10_20 = true; timeCount++; } else clbTime.SetItemChecked(1, false);
            if (clbTime.GetItemCheckState(2) == CheckState.Checked) { time.T10_40 = true; timeCount++; } else clbTime.SetItemChecked(2, false);
            if (clbTime.GetItemCheckState(3) == CheckState.Checked) { time.T11_00 = true; timeCount++; } else clbTime.SetItemChecked(3, false);
            if (clbTime.GetItemCheckState(4) == CheckState.Checked) { time.T12_00 = true; timeCount++; } else clbTime.SetItemChecked(4, false);

            if (editDoctor.FirstName.Length <= 3 || editDoctor.FirstName.Length > 30 || editDoctor.LastName.Length <= 3 || editDoctor.LastName.Length > 30 
                || editDoctor.SecondName.Length <= 3 || editDoctor.SecondName.Length > 30 || timeCount == 0 || dayCount == 0)
            {
                MessageBox.Show("Invalid Data");
            }
            else
            {
                using (var client = new HaServiceClient())
                {
                    client.EditDoctor(editDoctor);
                    client.EditDays(dor);
                    client.EditTime(time);
                }
                
            }
            
        }

        private void tbEditDocName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))//)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbEditDocLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))//)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbEditDocSecName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))//)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btEditDocChangePas_Click(object sender, EventArgs e)
        {
            EditDocPassword editRoomForm = new EditDocPassword(_doctor.DoctorId);
            if (editRoomForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
