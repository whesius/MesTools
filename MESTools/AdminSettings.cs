using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESTools
{
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void AdminSettings_Shown(object sender, EventArgs e)
        {
            this.textBoxAdminDomain.Text = Properties.Settings.Default.AdminDomain;
            this.textBoxAdminUser.Text = Properties.Settings.Default.AdminUser;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdminDomain = this.textBoxAdminDomain.Text;
            Properties.Settings.Default.AdminUser = this.textBoxAdminUser.Text;
            Properties.Settings.Default.AdminPassword = this.textBoxAdminPassword.Text;

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
