using System;
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

            DaysOfReceiving dor= new DaysOfReceiving();
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
                doc.Specialty = client.GetSpecialtyByName(cbChoseSpesialty.SelectedItem.ToString());//. SelectedText);
                client.AddDoctor(doc);
            }
        }

        private void cbDay_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
