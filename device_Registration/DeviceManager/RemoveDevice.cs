using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repo;

namespace device_Registration.DeviceManager
{
    public partial class RemoveDevice : Form
    {
        private Repo.IRepo repo;

        public RemoveDevice(Repo.IRepo repo)
        {
            InitializeComponent();

            this.repo = repo;

            this.deviceList.DataSource = repo.Find();
            this.deviceList.DisplayMember = "Name";
            this.deviceList.ValueMember = "Name";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            repo.Remove(this.deviceList.Text);
            this.Close();
        }
    }
}
