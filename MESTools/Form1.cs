using MESTools.src;
using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Messaging;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MESTools
{
    public partial class Form1 : Form
    {
        public ServiceController[] ServiceControllers { get; private set; }

        public Form1()
        {
            InitializeComponent();

            string[] list = {"", "TST: UABE0MDV13.UABEPRD.COM", "ACC: UABE0MAC04.UABEPRD.COM", "ACC: UABE0MAC06.UABEPRD.COM", "ACC: UABE0MAC10.UABEPRD.COM", "PRD: UABE0MAP07.UABEPRD.COM", "PRD: UABE0MAP08.UABEPRD.COM", "PRD: UABE0MAP12.UABEPRD.COM" };
            this.comboBoxServers.DataSource = list.ToArray();
            this.comboBoxServers.SelectedIndexChanged += ComboBoxServers_SelectedIndexChanged;

            this.comboBoxMsmqServers.DataSource = list.ToArray();
            this.comboBoxMsmqServers.SelectedIndexChanged += comboBoxMsmqServers_SelectedIndexChanged;

            this.comboBoxAppServers.DataSource = list.ToArray();
            this.comboBoxAppServers.SelectedIndexChanged += comboBoxAppServers_SelectedIndexChanged;
        }
           

        private void ComboBoxServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxServers.SelectedIndex > 0)
            {
                this.textBoxServer.Text = $"{this.comboBoxServers.SelectedItem}".Substring(5);
            }
            else
            {
                this.textBoxServer.Text = null;
            }
        }

        private void buttonListServices_Click(object sender, EventArgs e)
        {
            ListServiceControllers();
        }

        private void ListServiceControllers()
        {
            ImpersonationUtil.Impersonate();

            if (textBoxServer.Text.Any())
            {
                var searchFor = this.textBoxFilterServices.Text?.ToUpper();
                string[] separator = { " OR " };

                var searchItems = searchFor.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                if (searchItems.Any())
                {
                    var result = GetServiceControllers(textBoxServer.Text, searchItems);
                    this.dataGridView1.DataSource = result
                        .Distinct()
                        .OrderBy(v => v.DisplayName)
                        .ToArray();
                }
                else
                {
                    this.dataGridView1.DataSource = GetServiceControllers(textBoxServer.Text);
                }

                for(int index = 0; index < this.dataGridView1.ColumnCount; index++)
                {
                    this.dataGridView1.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }                            
            }
        }

        private string AdminUser => $@"{Properties.Settings.Default.AdminDomain}\{Properties.Settings.Default.AdminUser}";

        private string AdminPassword = Properties.Settings.Default.AdminPassword;

        private void ListAppPools()
        {
            var connectionOptions = new ConnectionOptions
            {
                Username = AdminUser,
                Password = AdminPassword,
                Authentication = AuthenticationLevel.PacketPrivacy,
                Impersonation = ImpersonationLevel.Impersonate
            };

            var scope = new ManagementScope($@"\\{textBoxAppServer.Text}\root\MicrosoftIISv2", connectionOptions);
            scope.Connect();


            var server = textBoxAppServer.Text;

            ObjectQuery oQueryIISApplicationPoolSetting = null;
            if (string.IsNullOrWhiteSpace(this.textBoxAppFilter.Text))
            {
                // Query IIS WMI property IISApplicationPoolSetting
                oQueryIISApplicationPoolSetting = new ObjectQuery("SELECT * FROM IISApplicationPoolSetting");
            }
            else
            {
                oQueryIISApplicationPoolSetting = new ObjectQuery($"SELECT * FROM IISApplicationPoolSetting Where Name like '%{this.textBoxAppFilter.Text}%'");
            }

            // Search and collect details thru WMI methods
            ManagementObjectSearcher moSearcherIISApplicationPoolSetting =
                new ManagementObjectSearcher(scope, oQueryIISApplicationPoolSetting);
            ManagementObjectCollection collectionIISApplicationPoolSetting =
                            moSearcherIISApplicationPoolSetting.Get();

            var appPools = new List<appPool>();
            // Loop thru every object
           

            foreach (ManagementObject mo in collectionIISApplicationPoolSetting)
            {              

                var appPool = new appPool()
                {
                    Name = Convert.ToString(mo["Name"])
                };

                var AppPoolState = Convert.ToString(mo["AppPoolState"]);

                switch (Convert.ToInt32(AppPoolState))
                {
                    case 1:
                        appPool.State = "Starting";
                        break;
                    case 2:
                        appPool.State = "Started";
                        break;
                    case 3:
                        appPool.State = "Stopping";
                        break;
                    case 4:
                        appPool.State = "Stopped";
                        break;                  
                }
                appPools.Add(appPool);               
            }

            this.dataGridViewAppPools.DataSource = appPools
                .OrderBy(v => v.Name)
                .ToArray();

            for (int index = 0; index < this.dataGridViewAppPools.ColumnCount; index++)
            {
                this.dataGridViewAppPools.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
               

        private ServiceController[] GetServiceControllers(string serverName, string[] searchText = null)
        {
            if(searchText?.Any() == true)
            {
                this.ServiceControllers = ServiceController
                .GetServices(serverName)
                .Where(v => searchText.Any(w => v.DisplayName.ToUpper().IndexOf(w, 0) > -1))
                 .OrderBy(v => v.DisplayName)
                .ToArray();
            }
            else
            {
                this.ServiceControllers = ServiceController
                .GetServices(serverName)
                .OrderBy(v => v.DisplayName)
                .ToArray();
            }
           

            return this.ServiceControllers;
        }

        private void buttonStartService_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                var serviceController = row.DataBoundItem as ServiceController;

                if (serviceController.Status == ServiceControllerStatus.Stopped)
                {
                    serviceController.Start();
                    serviceController.WaitForStatus(ServiceControllerStatus.Running);
                    serviceController.Refresh();
                }
            }

            this.dataGridView1.Refresh();
        }

        private void buttonStopService_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                var serviceController = row.DataBoundItem as ServiceController;

                if (serviceController.Status == ServiceControllerStatus.Running)
                {
                    serviceController.Stop();
                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                    serviceController.Refresh();
                }
            }

            this.dataGridView1.Refresh();
        }
   
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = this.dataGridView1.Columns[e.ColumnIndex];
            var row = this.dataGridView1.Rows[e.RowIndex];

            var serviceController = row.DataBoundItem as ServiceController;
            if(column.DataPropertyName == nameof(serviceController.Status))
            {
                var cell = row.Cells[e.ColumnIndex];

                if(serviceController.Status == ServiceControllerStatus.Running)
                {
                    cell.Style.BackColor = Color.Green;                   
                }
                else
                {
                    cell.Style.BackColor = Color.Empty;
                }
            }            
        }

        private void ListMSMQ()
        {
            ImpersonationUtil.Impersonate();

            var connectionOptions = new ConnectionOptions
            {
                Username = AdminUser,
                Password = AdminPassword,
                Authentication = AuthenticationLevel.PacketPrivacy,
                Impersonation = ImpersonationLevel.Impersonate
            };

            var path = $@"\\{this.textBoxMsmqServer.Text}\root\CIMv2";
            var scope = new ManagementScope(path, connectionOptions);
            scope.Connect();

            string queryString =
              String.Format("SELECT * FROM Win32_PerfFormattedData_msmq_MSMQQueue");

            if (this.textBoxMsmqFilter.Text.Any())
            {
                var filterByName = $@"{textBoxMsmqFilter.Text}";

                queryString = $"SELECT * FROM Win32_PerfFormattedData_msmq_MSMQQueue WHERE Name like '%{filterByName}%'";
            }

            var query = new ObjectQuery(queryString);

            var searcher = new ManagementObjectSearcher(scope, query);

            var queues = searcher.Get();

            var servername = this.textBoxMsmqServer.Text.Substring(0, this.textBoxMsmqServer.Text.IndexOf('.'));

            var list = new List<msmq>();
            foreach (var queue in queues)
            {
                // 'FormatName: Direct = os:uabe0map07.uabeprd.com\prd.ql.irsmes.bodgenerator_trigger'
                var msmq = new msmq();
                msmq.QueueName = $"{queue.GetPropertyValue("Name")}";
                msmq.MessagesInQueue = Convert.ToInt32(queue.GetPropertyValue("MessagesInQueue"));
                msmq.MessagesinJournalQueue = Convert.ToInt32(queue.GetPropertyValue("MessagesinJournalQueue"));
                msmq.BytesinQueue = $"{queue.GetPropertyValue("BytesinQueue")}";
                msmq.BytesinJournalQueue = $"{queue.GetPropertyValue("BytesinJournalQueue")}";

                if (msmq.QueueName.IndexOf("private", 0, StringComparison.OrdinalIgnoreCase) < 0
                    && msmq.QueueName.StartsWith(servername, StringComparison.OrdinalIgnoreCase))
                {
                    var messageQ = new MessageQueue($"FormatName:Direct=os:{msmq.QueueName}");
                    var myFilter = new MessagePropertyFilter();
                    myFilter.ClearAll();
                    myFilter.ArrivedTime = true;
                    messageQ.MessageReadPropertyFilter = myFilter;

                    var allMessages = messageQ.GetAllMessages();
                    msmq.OldestArrivedTime = allMessages.OrderBy(v => v.ArrivedTime).Select(v => v.ArrivedTime).FirstOrDefault();
                    msmq.NewestArrivedTime = allMessages.OrderBy(v => v.ArrivedTime).Select(v => v.ArrivedTime).LastOrDefault();

                    var thresHold = DateTime.Now.AddMinutes(-1);

                    msmq.MessagesInQueueLongerThan1Minutes = allMessages.Where(v => v.ArrivedTime < thresHold).Count();
                }

                list.Add(msmq);
            }

            this.dataGridViewMSMQ.DataSource = list.OrderBy(v => v.QueueName).ToArray();

            for (int index = 0; index < this.dataGridViewMSMQ.ColumnCount; index++)
            {
                this.dataGridViewMSMQ.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
        }

        private void dataGridViewMSMQ_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = this.dataGridViewMSMQ.Columns[e.ColumnIndex];
            var row = this.dataGridViewMSMQ.Rows[e.RowIndex];

            var msms = row.DataBoundItem as msmq;
            if (column.DataPropertyName == nameof(msms.MessagesInQueue))
            {
                var cell = row.Cells[e.ColumnIndex];

                if (msms.MessagesInQueue > 0)
                {
                    cell.Style.BackColor = Color.Green;
                }
                else
                {
                    cell.Style.BackColor = Color.Empty;
                }
            }
        }

        private void dataGridViewAppPools_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = this.dataGridViewAppPools.Columns[e.ColumnIndex];
            var row = this.dataGridViewAppPools.Rows[e.RowIndex];

            var appPool = row.DataBoundItem as appPool;
            if (column.DataPropertyName == nameof(appPool.State))
            {
                var cell = row.Cells[e.ColumnIndex];

                if (appPool.State == "Started" || appPool.State == "Starting")
                {
                    cell.Style.BackColor = Color.Green;
                }
                else
                {
                    cell.Style.BackColor = Color.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListMSMQ();
        }

        private void comboBoxMsmqServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxMsmqServers.SelectedIndex > 0)
            {
                this.textBoxMsmqServer.Text = $"{this.comboBoxMsmqServers.SelectedItem}".Substring(5);
            }
            else
            {
                this.textBoxMsmqServer.Text = null;
            }
        }

        private void comboBoxAppServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAppServers.SelectedIndex > 0) {
                this.textBoxAppServer.Text = $"{this.comboBoxAppServers.SelectedItem}".Substring(5);
            }
            else {
                this.textBoxAppServer.Text = null;
            }
        }

        private void buttonAppList_Click(object sender, EventArgs e)
        {
            ListAppPools();
        }

        private void adminSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AdminSettings();
            form.ShowDialog();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dataGridViewMSMQ_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dataGridViewAppPools_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
