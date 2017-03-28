using System;
using System.Windows.Forms;
using HADatabaseEntity;
using HospitalApointmentSystem.Client.ServiceApointment;

namespace HospitalApointmentSystem.Client
{
    public partial class AuthorizatiomForm : Form
    {
        public AuthorizatiomForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, System.EventArgs e)
        {
            
            /*Patient patient = new Patient();
            patient.Role = "Doctor";
            Doctor doc = new Doctor();
            doc.Role = "Doctor";
            this.Hide();
            AppointmentForm appointmentForm = new AppointmentForm(doc);
            appointmentForm.Show();*/

            if (tbLogin.Text.Trim() != "" && tbLogin.Text.Trim().Length > 4 && tbLogin.Text.Trim().Length < 31 && tbPassword.Text.Trim() != ""
                && tbPassword.Text.Trim().Length > 4)
            {
                using (var client = new HaServiceClient())
                {
                    this.Enabled = false;
                    Patient patient = client.VerefyAuth(tbLogin.Text.Trim(), tbPassword.Text.Trim());
                    Doctor doc = client.VerefyAuthDoc(tbLogin.Text.Trim(), tbPassword.Text.Trim());
                    if (patient != null)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        AppointmentForm appointmentForm = new AppointmentForm(patient);
                        appointmentForm.Show();
                    }
                    else if(doc != null)
                    {
                        this.Hide();
                        AppointmentForm appointmentForm = new AppointmentForm(doc);
                        appointmentForm.Show();
                    }
                    else
                        MessageBox.Show("Invalid Login or Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Login or Password");
                //return;
            }
            this.Enabled = true;
        }

        private void AuthorizatiomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show(this, "Really?", "Closing...",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.Cancel) e.Cancel = true;
            }
            Application.Exit();*/
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void AuthorizatiomForm_Load(object sender, System.EventArgs e)
        {
            tbPassword.Text = "111111";
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
            }
        }
    }
}
