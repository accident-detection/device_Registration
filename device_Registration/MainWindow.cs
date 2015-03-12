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
using Repo.Implementations;
using device_Registration.DeviceManager;

namespace device_Registration
{
    public partial class MainWindow : Form
    {
        IRepo repo = new StaticRepo();

        public MainWindow()
        {
            InitializeComponent();
            loadData();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDevice device = new AddDevice(repo);

            device.Show();
        }

        private void removeDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveDevice remove = new RemoveDevice(repo);

            remove.Show();
        }

        private void updateStatusOfADeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangeDevice change = new ChangeDevice();

            //change.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.Show();
        }

        private void loadData()
        {
            DataTable dataTable = repo.Find();

            this.data.DataSource = dataTable;
            this.data.Columns["API"].Width = 400;
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
