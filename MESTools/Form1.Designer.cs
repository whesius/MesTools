namespace MESTools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.buttonListServices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxServers = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonStopService = new System.Windows.Forms.Button();
            this.buttonStartService = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFilterServices = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageMSMQ = new System.Windows.Forms.TabPage();
            this.dataGridViewMSMQ = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMsmqFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMsmqServers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMsmqServer = new System.Windows.Forms.TextBox();
            this.tabPageAppPools = new System.Windows.Forms.TabPage();
            this.dataGridViewAppPools = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonAppList = new System.Windows.Forms.Button();
            this.textBoxAppFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAppServers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAppServer = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageMSMQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMSMQ)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPageAppPools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppPools)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(76, 11);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(334, 20);
            this.textBoxServer.TabIndex = 0;
            // 
            // buttonListServices
            // 
            this.buttonListServices.Location = new System.Drawing.Point(430, 36);
            this.buttonListServices.Margin = new System.Windows.Forms.Padding(5);
            this.buttonListServices.Name = "buttonListServices";
            this.buttonListServices.Size = new System.Drawing.Size(113, 26);
            this.buttonListServices.TabIndex = 1;
            this.buttonListServices.Text = "List";
            this.buttonListServices.UseVisualStyleBackColor = true;
            this.buttonListServices.Click += new System.EventHandler(this.buttonListServices_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server:";
            // 
            // comboBoxServers
            // 
            this.comboBoxServers.FormattingEnabled = true;
            this.comboBoxServers.Location = new System.Drawing.Point(430, 10);
            this.comboBoxServers.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxServers.Name = "comboBoxServers";
            this.comboBoxServers.Size = new System.Drawing.Size(370, 21);
            this.comboBoxServers.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonStopService);
            this.panel2.Controls.Add(this.buttonStartService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 386);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(1040, 77);
            this.panel2.TabIndex = 4;
            // 
            // buttonStopService
            // 
            this.buttonStopService.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStopService.Location = new System.Drawing.Point(799, 15);
            this.buttonStopService.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStopService.Name = "buttonStopService";
            this.buttonStopService.Size = new System.Drawing.Size(113, 47);
            this.buttonStopService.TabIndex = 1;
            this.buttonStopService.Text = "Stop";
            this.buttonStopService.UseVisualStyleBackColor = true;
            this.buttonStopService.Click += new System.EventHandler(this.buttonStopService_Click);
            // 
            // buttonStartService
            // 
            this.buttonStartService.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStartService.Location = new System.Drawing.Point(912, 15);
            this.buttonStartService.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStartService.Name = "buttonStartService";
            this.buttonStartService.Size = new System.Drawing.Size(113, 47);
            this.buttonStartService.TabIndex = 0;
            this.buttonStartService.Text = "Start";
            this.buttonStartService.UseVisualStyleBackColor = true;
            this.buttonStartService.Click += new System.EventHandler(this.buttonStartService_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 311);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageServices);
            this.tabControl.Controls.Add(this.tabPageMSMQ);
            this.tabControl.Controls.Add(this.tabPageAppPools);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(125, 31);
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1058, 507);
            this.tabControl.TabIndex = 6;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Controls.Add(this.panel3);
            this.tabPageServices.Controls.Add(this.panel2);
            this.tabPageServices.Location = new System.Drawing.Point(4, 35);
            this.tabPageServices.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(5);
            this.tabPageServices.Size = new System.Drawing.Size(1050, 468);
            this.tabPageServices.TabIndex = 0;
            this.tabPageServices.Text = "SERVICES";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 381);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonListServices);
            this.panel1.Controls.Add(this.textBoxFilterServices);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxServers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 70);
            this.panel1.TabIndex = 6;
            // 
            // textBoxFilterServices
            // 
            this.textBoxFilterServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterServices.Location = new System.Drawing.Point(76, 36);
            this.textBoxFilterServices.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFilterServices.Name = "textBoxFilterServices";
            this.textBoxFilterServices.Size = new System.Drawing.Size(334, 26);
            this.textBoxFilterServices.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter:";
            // 
            // tabPageMSMQ
            // 
            this.tabPageMSMQ.Controls.Add(this.dataGridViewMSMQ);
            this.tabPageMSMQ.Controls.Add(this.panel4);
            this.tabPageMSMQ.Location = new System.Drawing.Point(4, 35);
            this.tabPageMSMQ.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageMSMQ.Name = "tabPageMSMQ";
            this.tabPageMSMQ.Padding = new System.Windows.Forms.Padding(5);
            this.tabPageMSMQ.Size = new System.Drawing.Size(1050, 468);
            this.tabPageMSMQ.TabIndex = 1;
            this.tabPageMSMQ.Text = "MSMQ";
            this.tabPageMSMQ.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMSMQ
            // 
            this.dataGridViewMSMQ.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMSMQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMSMQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMSMQ.Location = new System.Drawing.Point(5, 75);
            this.dataGridViewMSMQ.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewMSMQ.Name = "dataGridViewMSMQ";
            this.dataGridViewMSMQ.Size = new System.Drawing.Size(1040, 388);
            this.dataGridViewMSMQ.TabIndex = 3;
            this.dataGridViewMSMQ.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMSMQ_CellFormatting);
            this.dataGridViewMSMQ.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewMSMQ_DataError);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBoxMsmqFilter);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBoxMsmqServers);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxMsmqServer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1040, 70);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMsmqFilter
            // 
            this.textBoxMsmqFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMsmqFilter.Location = new System.Drawing.Point(78, 35);
            this.textBoxMsmqFilter.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMsmqFilter.Name = "textBoxMsmqFilter";
            this.textBoxMsmqFilter.Size = new System.Drawing.Size(334, 26);
            this.textBoxMsmqFilter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter:";
            // 
            // comboBoxMsmqServers
            // 
            this.comboBoxMsmqServers.FormattingEnabled = true;
            this.comboBoxMsmqServers.Location = new System.Drawing.Point(432, 9);
            this.comboBoxMsmqServers.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxMsmqServers.Name = "comboBoxMsmqServers";
            this.comboBoxMsmqServers.Size = new System.Drawing.Size(370, 21);
            this.comboBoxMsmqServers.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server:";
            // 
            // textBoxMsmqServer
            // 
            this.textBoxMsmqServer.Location = new System.Drawing.Point(78, 10);
            this.textBoxMsmqServer.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMsmqServer.Name = "textBoxMsmqServer";
            this.textBoxMsmqServer.Size = new System.Drawing.Size(334, 20);
            this.textBoxMsmqServer.TabIndex = 5;
            // 
            // tabPageAppPools
            // 
            this.tabPageAppPools.Controls.Add(this.dataGridViewAppPools);
            this.tabPageAppPools.Controls.Add(this.panel5);
            this.tabPageAppPools.Location = new System.Drawing.Point(4, 35);
            this.tabPageAppPools.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAppPools.Name = "tabPageAppPools";
            this.tabPageAppPools.Padding = new System.Windows.Forms.Padding(5);
            this.tabPageAppPools.Size = new System.Drawing.Size(1050, 468);
            this.tabPageAppPools.TabIndex = 2;
            this.tabPageAppPools.Text = "Application Pools";
            this.tabPageAppPools.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAppPools
            // 
            this.dataGridViewAppPools.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAppPools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppPools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAppPools.Location = new System.Drawing.Point(5, 75);
            this.dataGridViewAppPools.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAppPools.Name = "dataGridViewAppPools";
            this.dataGridViewAppPools.Size = new System.Drawing.Size(1040, 388);
            this.dataGridViewAppPools.TabIndex = 0;
            this.dataGridViewAppPools.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAppPools_CellFormatting);
            this.dataGridViewAppPools.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewAppPools_DataError);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonAppList);
            this.panel5.Controls.Add(this.textBoxAppFilter);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.comboBoxAppServers);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.textBoxAppServer);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1040, 70);
            this.panel5.TabIndex = 1;
            // 
            // buttonAppList
            // 
            this.buttonAppList.Location = new System.Drawing.Point(426, 36);
            this.buttonAppList.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAppList.Name = "buttonAppList";
            this.buttonAppList.Size = new System.Drawing.Size(113, 26);
            this.buttonAppList.TabIndex = 12;
            this.buttonAppList.Text = "List";
            this.buttonAppList.UseVisualStyleBackColor = true;
            this.buttonAppList.Click += new System.EventHandler(this.buttonAppList_Click);
            // 
            // textBoxAppFilter
            // 
            this.textBoxAppFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppFilter.Location = new System.Drawing.Point(72, 36);
            this.textBoxAppFilter.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAppFilter.Name = "textBoxAppFilter";
            this.textBoxAppFilter.Size = new System.Drawing.Size(334, 26);
            this.textBoxAppFilter.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filter:";
            // 
            // comboBoxAppServers
            // 
            this.comboBoxAppServers.FormattingEnabled = true;
            this.comboBoxAppServers.Location = new System.Drawing.Point(426, 10);
            this.comboBoxAppServers.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxAppServers.Name = "comboBoxAppServers";
            this.comboBoxAppServers.Size = new System.Drawing.Size(370, 21);
            this.comboBoxAppServers.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Server:";
            // 
            // textBoxAppServer
            // 
            this.textBoxAppServer.Location = new System.Drawing.Point(72, 11);
            this.textBoxAppServer.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAppServer.Name = "textBoxAppServer";
            this.textBoxAppServer.Size = new System.Drawing.Size(334, 20);
            this.textBoxAppServer.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1058, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // adminSettingsToolStripMenuItem
            // 
            this.adminSettingsToolStripMenuItem.Name = "adminSettingsToolStripMenuItem";
            this.adminSettingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.adminSettingsToolStripMenuItem.Text = "Admin Settings";
            this.adminSettingsToolStripMenuItem.Click += new System.EventHandler(this.adminSettingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 556);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MES Tools";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageServices.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageMSMQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMSMQ)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageAppPools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppPools)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button buttonListServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonStopService;
        private System.Windows.Forms.Button buttonStartService;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxServers;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxFilterServices;
        private System.Windows.Forms.TabPage tabPageMSMQ;
        private System.Windows.Forms.DataGridView dataGridViewMSMQ;
        private System.Windows.Forms.TabPage tabPageAppPools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAppPools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMsmqFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMsmqServers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMsmqServer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonAppList;
        private System.Windows.Forms.TextBox textBoxAppFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAppServers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAppServer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminSettingsToolStripMenuItem;
    }
}

