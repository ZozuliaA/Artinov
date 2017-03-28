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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm(Patient logedUser)
        {
            InitializeComponent();

            if (logedUser.Role == "User")
            {
                var control = new UсPatient(logedUser);
                splitContainerAppointment.Panel1.Controls.Add(control);
            }
            
            if (logedUser.Role == "Admin")
            {
                var control = new UcAdmin(logedUser);
                splitContainerAppointment.Panel1.Controls.Add(control);
            }
        }

        public AppointmentForm(Doctor logedDoctor)
        {
            InitializeComponent();
            if (logedDoctor.Role == "Doctor")
            {
                var control = new UcDoctor(logedDoctor);
                splitContainerAppointment.Panel1.Controls.Add(control);
            }
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void btLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizatiomForm auForm = new AuthorizatiomForm();
            auForm.Show();
        }
    }
}
