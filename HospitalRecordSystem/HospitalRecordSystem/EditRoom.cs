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
using HospitalApointmentSystem.Client.ServiceApointment;

namespace HospitalApointmentSystem.Client
{
    public partial class EditRoom : Form
    {
        private readonly Guid _roomId;
        private Room _room;

        public EditRoom(Guid selectedId)
        {
            InitializeComponent();
            _roomId = selectedId;
        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            
            using (var client = new HaServiceClient())
            {
                _room = client.GetRoomById(_roomId);
            }
            tbNewRoomNumber.Text = _room.RoomNumber.ToString();
            tbNewRoomType.Text = _room.Type;
            if (_room.Unavaible == false) rbNo.Select(); else rbYes.Select();
        }

        private void btEditRoom_Click(object sender, EventArgs e)
        {
            if (tbNewRoomNumber.Text.Trim().Length == 0)
            {
                labelEditError.ForeColor = Color.Crimson;
                labelEditError.Text = "Enter valid data";
                DialogResult = DialogResult.None;
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to edit this room?\nNew Number " + tbNewRoomNumber.Text,"Confirm edit!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                
                using (var client = new HaServiceClient())
                {
                    var checkSameRoom = client.GetRooms();
                    foreach (var item in checkSameRoom)
                    {
                        if (item.RoomNumber == int.Parse(tbNewRoomNumber.Text))
                        {
                            labelEditError.ForeColor = Color.Crimson;
                            labelEditError.Text = "Room Already Exist";
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                    _room.RoomNumber = int.Parse(tbNewRoomNumber.Text);
                    _room.Type = tbNewRoomType.Text;
                    if (rbYes.Checked == true) _room.Unavaible = true; else _room.Unavaible = false;
                    client.EditRoom(_room);
                }

            }
            else
            {
                DialogResult = DialogResult.None;
                //return;
            }
            
        }

        private void tbNewRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
