namespace FIONA
{
    partial class Application
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
            this.panelShare = new System.Windows.Forms.Panel();
            this.labelFolderList = new System.Windows.Forms.Label();
            this.labelSharedFolders = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonAddShared = new System.Windows.Forms.Button();
            this.buttonShareStartStop = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShareMain = new System.Windows.Forms.Button();
            this.buttonConnectMain = new System.Windows.Forms.Button();
            this.panelConnect = new System.Windows.Forms.Panel();
            this.panelConnectList = new System.Windows.Forms.Panel();
            this.labelNoShared = new System.Windows.Forms.Label();
            this.buttonConnectBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLoginText = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.username_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.panelEntry = new System.Windows.Forms.Panel();
            this.panelShare.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelConnect.SuspendLayout();
            this.panelConnectList.SuspendLayout();
            this.panelEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShare
            // 
            this.panelShare.BackColor = System.Drawing.SystemColors.Control;
            this.panelShare.Controls.Add(this.labelFolderList);
            this.panelShare.Controls.Add(this.labelSharedFolders);
            this.panelShare.Controls.Add(this.labelStatus);
            this.panelShare.Controls.Add(this.buttonAddShared);
            this.panelShare.Controls.Add(this.buttonShareStartStop);
            this.panelShare.Controls.Add(this.buttonBack);
            this.panelShare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShare.Location = new System.Drawing.Point(0, 0);
            this.panelShare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelShare.Name = "panelShare";
            this.panelShare.Size = new System.Drawing.Size(1323, 870);
            this.panelShare.TabIndex = 7;
            // 
            // labelFolderList
            // 
            this.labelFolderList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFolderList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFolderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolderList.Location = new System.Drawing.Point(44, 352);
            this.labelFolderList.Name = "labelFolderList";
            this.labelFolderList.Size = new System.Drawing.Size(1237, 258);
            this.labelFolderList.TabIndex = 10;
            this.labelFolderList.Text = "No folders currently set to share";
            // 
            // labelSharedFolders
            // 
            this.labelSharedFolders.AutoSize = true;
            this.labelSharedFolders.BackColor = System.Drawing.SystemColors.Control;
            this.labelSharedFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSharedFolders.Location = new System.Drawing.Point(79, 296);
            this.labelSharedFolders.Name = "labelSharedFolders";
            this.labelSharedFolders.Size = new System.Drawing.Size(394, 37);
            this.labelSharedFolders.TabIndex = 9;
            this.labelSharedFolders.Text = "Selected Folders to Share:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(504, 109);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(642, 73);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Server Status: Offline";
            // 
            // buttonAddShared
            // 
            this.buttonAddShared.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddShared.Location = new System.Drawing.Point(124, 685);
            this.buttonAddShared.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddShared.Name = "buttonAddShared";
            this.buttonAddShared.Size = new System.Drawing.Size(523, 100);
            this.buttonAddShared.TabIndex = 5;
            this.buttonAddShared.Text = "Select Share Folder";
            this.buttonAddShared.UseVisualStyleBackColor = true;
            this.buttonAddShared.Click += new System.EventHandler(this.ButtonAddShared_Click);
            // 
            // buttonShareStartStop
            // 
            this.buttonShareStartStop.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonShareStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShareStartStop.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonShareStartStop.Location = new System.Drawing.Point(925, 648);
            this.buttonShareStartStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShareStartStop.Name = "buttonShareStartStop";
            this.buttonShareStartStop.Size = new System.Drawing.Size(356, 198);
            this.buttonShareStartStop.TabIndex = 1;
            this.buttonShareStartStop.Text = "Start Sharing";
            this.buttonShareStartStop.UseVisualStyleBackColor = false;
            this.buttonShareStartStop.Click += new System.EventHandler(this.ButtonShareStartStop_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(55, 43);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(219, 112);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Go Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.label1);
            this.panelMainMenu.Controls.Add(this.labelAccountName);
            this.panelMainMenu.Controls.Add(this.buttonLogout);
            this.panelMainMenu.Controls.Add(this.buttonShareMain);
            this.panelMainMenu.Controls.Add(this.buttonConnectMain);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1323, 870);
            this.panelMainMenu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(262, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "more info";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.Location = new System.Drawing.Point(116, 74);
            this.labelAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(211, 51);
            this.labelAccountName.TabIndex = 3;
            this.labelAccountName.Text = "Logged in";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(497, 615);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(300, 78);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShareMain
            // 
            this.buttonShareMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShareMain.Location = new System.Drawing.Point(735, 244);
            this.buttonShareMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShareMain.Name = "buttonShareMain";
            this.buttonShareMain.Size = new System.Drawing.Size(451, 235);
            this.buttonShareMain.TabIndex = 1;
            this.buttonShareMain.Text = "Share";
            this.buttonShareMain.UseVisualStyleBackColor = true;
            this.buttonShareMain.Click += new System.EventHandler(this.buttonShareMain_Click);
            // 
            // buttonConnectMain
            // 
            this.buttonConnectMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectMain.Location = new System.Drawing.Point(124, 239);
            this.buttonConnectMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnectMain.Name = "buttonConnectMain";
            this.buttonConnectMain.Size = new System.Drawing.Size(451, 235);
            this.buttonConnectMain.TabIndex = 0;
            this.buttonConnectMain.Text = "Connect";
            this.buttonConnectMain.UseVisualStyleBackColor = true;
            this.buttonConnectMain.Click += new System.EventHandler(this.buttonConnectMain_Click);
            // 
            // panelConnect
            // 
            this.panelConnect.Controls.Add(this.panelConnectList);
            this.panelConnect.Controls.Add(this.buttonConnectBack);
            this.panelConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConnect.Location = new System.Drawing.Point(0, 0);
            this.panelConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(1323, 870);
            this.panelConnect.TabIndex = 4;
            // 
            // panelConnectList
            // 
            this.panelConnectList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelConnectList.Controls.Add(this.labelNoShared);
            this.panelConnectList.Location = new System.Drawing.Point(19, 140);
            this.panelConnectList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConnectList.Name = "panelConnectList";
            this.panelConnectList.Size = new System.Drawing.Size(1287, 711);
            this.panelConnectList.TabIndex = 0;
            // 
            // labelNoShared
            // 
            this.labelNoShared.AutoSize = true;
            this.labelNoShared.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoShared.Location = new System.Drawing.Point(124, 282);
            this.labelNoShared.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoShared.Name = "labelNoShared";
            this.labelNoShared.Size = new System.Drawing.Size(1103, 51);
            this.labelNoShared.TabIndex = 0;
            this.labelNoShared.Text = "There are no files currently being shared by your devices";
            // 
            // buttonConnectBack
            // 
            this.buttonConnectBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectBack.Location = new System.Drawing.Point(19, 19);
            this.buttonConnectBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnectBack.Name = "buttonConnectBack";
            this.buttonConnectBack.Size = new System.Drawing.Size(1287, 112);
            this.buttonConnectBack.TabIndex = 4;
            this.buttonConnectBack.Text = "Go Back";
            this.buttonConnectBack.UseVisualStyleBackColor = true;
            this.buttonConnectBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 277);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(668, 38);
            this.textBox1.TabIndex = 2;
            // 
            // labelLoginText
            // 
            this.labelLoginText.AutoSize = true;
            this.labelLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginText.Location = new System.Drawing.Point(523, 40);
            this.labelLoginText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginText.Name = "labelLoginText";
            this.labelLoginText.Size = new System.Drawing.Size(232, 91);
            this.labelLoginText.TabIndex = 1;
            this.labelLoginText.Text = "Login";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(925, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 134);
            this.button2.TabIndex = 0;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(116, 422);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(668, 38);
            this.textBox2.TabIndex = 3;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(116, 181);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(221, 51);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(116, 341);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(212, 51);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 728);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(44, 676);
            this.username_txtbx.Margin = new System.Windows.Forms.Padding(4);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(371, 31);
            this.username_txtbx.TabIndex = 7;
            this.username_txtbx.Text = "username";
            this.username_txtbx.Visible = false;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(44, 728);
            this.password_txtbx.Margin = new System.Windows.Forms.Padding(4);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(371, 31);
            this.password_txtbx.TabIndex = 8;
            this.password_txtbx.Text = "password";
            this.password_txtbx.Visible = false;
            // 
            // panelEntry
            // 
            this.panelEntry.Controls.Add(this.password_txtbx);
            this.panelEntry.Controls.Add(this.username_txtbx);
            this.panelEntry.Controls.Add(this.button1);
            this.panelEntry.Controls.Add(this.labelPassword);
            this.panelEntry.Controls.Add(this.labelUsername);
            this.panelEntry.Controls.Add(this.textBox2);
            this.panelEntry.Controls.Add(this.button2);
            this.panelEntry.Controls.Add(this.labelLoginText);
            this.panelEntry.Controls.Add(this.textBox1);
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntry.Location = new System.Drawing.Point(0, 0);
            this.panelEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(1323, 870);
            this.panelEntry.TabIndex = 0;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 870);
            this.Controls.Add(this.panelShare);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.panelEntry);
            this.Controls.Add(this.panelMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Application";
            this.Text = "Form1";
            this.panelShare.ResumeLayout(false);
            this.panelShare.PerformLayout();
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.panelConnect.ResumeLayout(false);
            this.panelConnectList.ResumeLayout(false);
            this.panelConnectList.PerformLayout();
            this.panelEntry.ResumeLayout(false);
            this.panelEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelShare;
        private System.Windows.Forms.Button buttonShareStartStop;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShareMain;
        private System.Windows.Forms.Button buttonConnectMain;
        private System.Windows.Forms.Button buttonAddShared;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Button buttonConnectBack;
        private System.Windows.Forms.Panel panelConnectList;
        private System.Windows.Forms.Label labelNoShared;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLoginText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Panel panelEntry;
        private System.Windows.Forms.Label labelFolderList;
        private System.Windows.Forms.Label labelSharedFolders;
        private System.Windows.Forms.Label label1;
    }
}

