using Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace device_Registration.DeviceManager
{
    public partial class ChangeDevice : Form
    {
        IRepo repo;
        public ChangeDevice(IRepo repo)
        {
            InitializeComponent();
            this.repo = repo;

            this.AcceptButton = changeBtn;

            this.deviceList.DataSource = repo.Find();
            this.deviceList.DisplayMember = "Name";
            this.deviceList.ValueMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            repo.Update(this.deviceList.Text);
            this.Close();
        }
    }
}
