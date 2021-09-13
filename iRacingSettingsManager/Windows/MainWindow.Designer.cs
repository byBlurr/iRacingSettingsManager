
namespace iRacingSettingsManager.Windows
{
    partial class MainWindow
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
            this.NewGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigNameBox = new System.Windows.Forms.TextBox();
            this.ConfigsData = new System.Windows.Forms.DataGridView();
            this.ConfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.OptionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.UpdatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpButton = new System.Windows.Forms.Button();
            this.NewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigsData)).BeginInit();
            this.OptionsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGroupBox
            // 
            this.NewGroupBox.Controls.Add(this.label2);
            this.NewGroupBox.Controls.Add(this.SaveConfigButton);
            this.NewGroupBox.Controls.Add(this.label1);
            this.NewGroupBox.Controls.Add(this.ConfigNameBox);
            this.NewGroupBox.Location = new System.Drawing.Point(6, 270);
            this.NewGroupBox.Name = "NewGroupBox";
            this.NewGroupBox.Size = new System.Drawing.Size(443, 98);
            this.NewGroupBox.TabIndex = 1;
            this.NewGroupBox.TabStop = false;
            this.NewGroupBox.Text = "Save Current Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saves your currently active settings.";
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.Location = new System.Drawing.Point(362, 69);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(75, 23);
            this.SaveConfigButton.TabIndex = 3;
            this.SaveConfigButton.Text = "Save";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Config Name:";
            // 
            // ConfigNameBox
            // 
            this.ConfigNameBox.Location = new System.Drawing.Point(152, 23);
            this.ConfigNameBox.Name = "ConfigNameBox";
            this.ConfigNameBox.Size = new System.Drawing.Size(285, 23);
            this.ConfigNameBox.TabIndex = 0;
            // 
            // ConfigsData
            // 
            this.ConfigsData.AllowUserToAddRows = false;
            this.ConfigsData.AllowUserToDeleteRows = false;
            this.ConfigsData.AllowUserToResizeColumns = false;
            this.ConfigsData.AllowUserToResizeRows = false;
            this.ConfigsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConfigsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConfigName,
            this.ConfigFile});
            this.ConfigsData.Location = new System.Drawing.Point(12, 43);
            this.ConfigsData.MultiSelect = false;
            this.ConfigsData.Name = "ConfigsData";
            this.ConfigsData.ReadOnly = true;
            this.ConfigsData.RowTemplate.Height = 25;
            this.ConfigsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConfigsData.Size = new System.Drawing.Size(344, 221);
            this.ConfigsData.TabIndex = 2;
            // 
            // ConfigName
            // 
            this.ConfigName.HeaderText = "Name";
            this.ConfigName.MinimumWidth = 300;
            this.ConfigName.Name = "ConfigName";
            this.ConfigName.ReadOnly = true;
            this.ConfigName.Width = 300;
            // 
            // ConfigFile
            // 
            this.ConfigFile.HeaderText = "Path";
            this.ConfigFile.MinimumWidth = 250;
            this.ConfigFile.Name = "ConfigFile";
            this.ConfigFile.ReadOnly = true;
            this.ConfigFile.Visible = false;
            this.ConfigFile.Width = 250;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(362, 43);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(87, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load Config";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(362, 72);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Config";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(362, 101);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(87, 23);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit Config";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // OptionsMenuStrip
            // 
            this.OptionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdatesMenuItem});
            this.OptionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OptionsMenuStrip.Name = "OptionsMenuStrip";
            this.OptionsMenuStrip.Size = new System.Drawing.Size(460, 24);
            this.OptionsMenuStrip.TabIndex = 6;
            this.OptionsMenuStrip.Text = "Options";
            this.OptionsMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OptionsMenuStrip_ItemClicked);
            // 
            // UpdatesMenuItem
            // 
            this.UpdatesMenuItem.Name = "UpdatesMenuItem";
            this.UpdatesMenuItem.Size = new System.Drawing.Size(116, 20);
            this.UpdatesMenuItem.Text = "Check for Updates";
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(362, 241);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(87, 23);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ConfigsData);
            this.Controls.Add(this.NewGroupBox);
            this.Controls.Add(this.OptionsMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OptionsMenuStrip;
            this.Name = "MainWindow";
            this.Text = "iRacing Settings Manager";
            this.NewGroupBox.ResumeLayout(false);
            this.NewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigsData)).EndInit();
            this.OptionsMenuStrip.ResumeLayout(false);
            this.OptionsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox NewGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveConfigButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfigNameBox;
        private System.Windows.Forms.DataGridView ConfigsData;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfigFile;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.MenuStrip OptionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdatesMenuItem;
        private System.Windows.Forms.Button HelpButton;
    }
}