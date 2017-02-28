using System.Windows.Forms;

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
            if (tbLogin.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please enter Login and Password");
                return;
            }

            MessageBox.Show("Login Successful!");
            this.Hide();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }
    }
}
