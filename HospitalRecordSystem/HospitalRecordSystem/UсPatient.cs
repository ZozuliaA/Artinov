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
    public partial class UсPatient : UserControl
    {
        private readonly Patient _currentUser;

         
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
        }

        private void cbChoseSpesialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChoseDoctor.Enabled = true;
            mcThisMonth.Enabled = false;
            rb1000.Enabled = false;
            rb1020.Enabled = false;
            rb1040.Enabled = false;
            rb1100.Enabled = false;
            rb1200.Enabled = false;

            using (var client = new HaServiceClient())
            {
                foreach (var item in client.GetDoctors())
                {
                    cbChoseDoctor.Items.Add(item.LastName);
                }
            }
        }

        private void cbChoseDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
