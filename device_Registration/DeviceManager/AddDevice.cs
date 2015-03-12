using Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace device_Registration.DeviceManager
{
    public partial class AddDevice : Form
    {
        private Repo.IRepo repo;

        public AddDevice(Repo.IRepo repo)
        {
            InitializeComponent();
            this.repo = repo;

            this.AcceptButton = saveBtn;
            this.CancelButton = cancelBtn;

            this.saveBtn.Enabled = false;
            this.deviceAPI.Text = sha256_hash(DateTime.Now.ToString());
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (this.deviceName.Text == "")
            {
                MessageBox.Show("Name can't be empty.");
                return;
            }
            Device device = new Device()
            {
                Name = this.deviceName.Text,
                API = this.deviceAPI.Text,
                Active = this.deviceActive.Checked
            };

            repo.Save(device);

            this.Close();
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        private void deviceName_TextChanged(object sender, EventArgs e)
        {
            this.saveBtn.Enabled = true;
        }
    }
}
