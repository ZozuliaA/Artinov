using System;
using System.Drawing;
using System.Windows.Forms;
using HADatabaseEntity;
using HospitalApointmentSystem.Client.ServiceApointment;

namespace HospitalApointmentSystem.Client
{
    public partial class EditDocPassword : Form
    {
        private readonly Guid _doctorId;
        private Doctor _doctor;
        public EditDocPassword(Guid doctorId)
        {
            InitializeComponent();
            _doctorId = doctorId;
        }

        private void EditDocPassword_Load(object sender, EventArgs e)
        {
            tbEditDocPassword.Enabled = false;
            tbEditDocPasswordRepeat.Enabled = false;
        }

        private void btEditDocPasConfirm_Click(object sender, EventArgs e)
        {
            using (var client = new HaServiceClient())
            {
                _doctor = client.GetDoctorById(_doctorId);
                string confirm = tbEditDocCurrentPassword.Text.Trim();
                var hash = client.VerefyAuthDoc(_doctor.LoginD, confirm)?.HashD;
                if (confirm.Length < 6 || confirm.Length > 30 || hash == null)
                {
                    tsslEditDocPas.ForeColor = Color.Crimson;
                    tsslEditDocPas.Text = "Invadid password";
                    return;
                }
                
                if (hash == _doctor.HashD)
                {
                    tbEditDocPassword.Enabled = true;
                    tbEditDocPasswordRepeat.Enabled = true;
                    tsslEditDocPas.ForeColor = Color.Blue;
                    tsslEditDocPas.Text = "Enter new password";
                }
                
            }
        }

        private void btEditDocPasSave_Click(object sender, EventArgs e)
        {
            if (tbEditDocPassword.Text.Trim() == tbEditDocPasswordRepeat.Text.Trim() && tbEditDocPasswordRepeat.Text.Trim().Length > 5
                && tbEditDocPasswordRepeat.Text.Trim().Length < 30)
            {
                using (var client = new HaServiceClient())
                {
                    _doctor.HashD = client.CreateHashOnServer(tbEditDocPasswordRepeat.Text.Trim());
                    client.EditDoctor(_doctor);
                    tsslEditDocPas.ForeColor = Color.Green;
                    tsslEditDocPas.Text = "Password changed";
                }
            }
            else
            {
                tsslEditDocPas.ForeColor = Color.Crimson;
                tbEditDocPassword.Clear();
                tbEditDocPasswordRepeat.Clear();
                tsslEditDocPas.Text = "Invadid new password, try again";
            }
        }

        private void tbEditDocCurrentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btEditDocPasConfirm.PerformClick();
            }
        }

        private void tbEditDocPasswordRepeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btEditDocPasSave.PerformClick();
            }
        }
    }
}
