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
            this.labelStatusConnectShare = new System.Windows.Forms.Label();
            this.labelMoreInfo = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShareMain = new System.Windows.Forms.Button();
            this.buttonConnectMain = new System.Windows.Forms.Button();
            this.panelConnect = new System.Windows.Forms.Panel();
            this.panelConnectList = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNoShared = new System.Windows.Forms.Label();
            this.buttonConnectBack = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelLoginText = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
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
            this.panelShare.Name = "panelShare";
            this.panelShare.Size = new System.Drawing.Size(882, 557);
            this.panelShare.TabIndex = 7;
            // 
            // labelFolderList
            // 
            this.labelFolderList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFolderList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFolderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolderList.Location = new System.Drawing.Point(29, 225);
            this.labelFolderList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFolderList.Name = "labelFolderList";
            this.labelFolderList.Size = new System.Drawing.Size(825, 165);
            this.labelFolderList.TabIndex = 10;
            this.labelFolderList.Text = "No folder currently set to share";
            // 
            // labelSharedFolders
            // 
            this.labelSharedFolders.AutoSize = true;
            this.labelSharedFolders.BackColor = System.Drawing.SystemColors.Control;
            this.labelSharedFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSharedFolders.Location = new System.Drawing.Point(53, 189);
            this.labelSharedFolders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSharedFolders.Name = "labelSharedFolders";
            this.labelSharedFolders.Size = new System.Drawing.Size(234, 25);
            this.labelSharedFolders.TabIndex = 9;
            this.labelSharedFolders.Text = "Selected Folder to Share:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.DarkRed;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelStatus.Location = new System.Drawing.Point(336, 70);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(397, 46);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Server Status: Offline";
            // 
            // buttonAddShared
            // 
            this.buttonAddShared.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddShared.Location = new System.Drawing.Point(83, 438);
            this.buttonAddShared.Name = "buttonAddShared";
            this.buttonAddShared.Size = new System.Drawing.Size(349, 64);
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
            this.buttonShareStartStop.Location = new System.Drawing.Point(617, 415);
            this.buttonShareStartStop.Name = "buttonShareStartStop";
            this.buttonShareStartStop.Size = new System.Drawing.Size(237, 127);
            this.buttonShareStartStop.TabIndex = 1;
            this.buttonShareStartStop.Text = "Start Sharing";
            this.buttonShareStartStop.UseVisualStyleBackColor = false;
            this.buttonShareStartStop.Click += new System.EventHandler(this.ButtonShareStartStop_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(37, 28);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(146, 72);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Go Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.labelStatusConnectShare);
            this.panelMainMenu.Controls.Add(this.labelMoreInfo);
            this.panelMainMenu.Controls.Add(this.labelAccountName);
            this.panelMainMenu.Controls.Add(this.buttonLogout);
            this.panelMainMenu.Controls.Add(this.buttonShareMain);
            this.panelMainMenu.Controls.Add(this.buttonConnectMain);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(882, 557);
            this.panelMainMenu.TabIndex = 7;
            // 
            // labelStatusConnectShare
            // 
            this.labelStatusConnectShare.AutoSize = true;
            this.labelStatusConnectShare.BackColor = System.Drawing.Color.DarkRed;
            this.labelStatusConnectShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusConnectShare.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelStatusConnectShare.Location = new System.Drawing.Point(363, 52);
            this.labelStatusConnectShare.Name = "labelStatusConnectShare";
            this.labelStatusConnectShare.Size = new System.Drawing.Size(397, 46);
            this.labelStatusConnectShare.TabIndex = 8;
            this.labelStatusConnectShare.Text = "Server Status: Offline";
            // 
            // labelMoreInfo
            // 
            this.labelMoreInfo.AutoSize = true;
            this.labelMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoreInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMoreInfo.Location = new System.Drawing.Point(175, 80);
            this.labelMoreInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoreInfo.Name = "labelMoreInfo";
            this.labelMoreInfo.Size = new System.Drawing.Size(50, 13);
            this.labelMoreInfo.TabIndex = 4;
            this.labelMoreInfo.Text = "more info";
            this.labelMoreInfo.Click += new System.EventHandler(this.LabelMoreInfo_Click);
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.Location = new System.Drawing.Point(77, 47);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(132, 31);
            this.labelAccountName.TabIndex = 3;
            this.labelAccountName.Text = "Logged in";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(331, 415);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(200, 50);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShareMain
            // 
            this.buttonShareMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShareMain.Location = new System.Drawing.Point(490, 189);
            this.buttonShareMain.Name = "buttonShareMain";
            this.buttonShareMain.Size = new System.Drawing.Size(301, 150);
            this.buttonShareMain.TabIndex = 1;
            this.buttonShareMain.Text = "Share";
            this.buttonShareMain.UseVisualStyleBackColor = true;
            this.buttonShareMain.Click += new System.EventHandler(this.buttonShareMain_Click);
            // 
            // buttonConnectMain
            // 
            this.buttonConnectMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectMain.Location = new System.Drawing.Point(83, 189);
            this.buttonConnectMain.Name = "buttonConnectMain";
            this.buttonConnectMain.Size = new System.Drawing.Size(301, 150);
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
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(882, 557);
            this.panelConnect.TabIndex = 4;
            // 
            // panelConnectList
            // 
            this.panelConnectList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelConnectList.Controls.Add(this.button2);
            this.panelConnectList.Controls.Add(this.button1);
            this.panelConnectList.Controls.Add(this.labelNoShared);
            this.panelConnectList.Location = new System.Drawing.Point(13, 90);
            this.panelConnectList.Name = "panelConnectList";
            this.panelConnectList.Size = new System.Drawing.Size(858, 455);
            this.panelConnectList.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "File List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.temp_getListing);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.temp_downloadButton);
            // 
            // labelNoShared
            // 
            this.labelNoShared.AutoSize = true;
            this.labelNoShared.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoShared.Location = new System.Drawing.Point(83, 180);
            this.labelNoShared.Name = "labelNoShared";
            this.labelNoShared.Size = new System.Drawing.Size(695, 31);
            this.labelNoShared.TabIndex = 0;
            this.labelNoShared.Text = "There are no files currently being shared by your devices";
            // 
            // buttonConnectBack
            // 
            this.buttonConnectBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectBack.Location = new System.Drawing.Point(77, 12);
            this.buttonConnectBack.Name = "buttonConnectBack";
            this.buttonConnectBack.Size = new System.Drawing.Size(719, 72);
            this.buttonConnectBack.TabIndex = 4;
            this.buttonConnectBack.Text = "Go Back";
            this.buttonConnectBack.UseVisualStyleBackColor = true;
            this.buttonConnectBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(77, 177);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(447, 26);
            this.textBoxUsername.TabIndex = 2;
            // 
            // labelLoginText
            // 
            this.labelLoginText.AutoSize = true;
            this.labelLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginText.Location = new System.Drawing.Point(349, 26);
            this.labelLoginText.Name = "labelLoginText";
            this.labelLoginText.Size = new System.Drawing.Size(148, 58);
            this.labelLoginText.TabIndex = 1;
            this.labelLoginText.Text = "Login";
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(617, 189);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(147, 86);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(77, 270);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(447, 26);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(77, 116);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(139, 31);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(77, 218);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(134, 31);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // buttonSignup
            // 
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.Location = new System.Drawing.Point(314, 466);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(228, 44);
            this.buttonSignup.TabIndex = 6;
            this.buttonSignup.Text = "Create Account";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(29, 433);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(249, 22);
            this.username_txtbx.TabIndex = 7;
            this.username_txtbx.Text = "username";
            this.username_txtbx.Visible = false;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(29, 466);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(249, 22);
            this.password_txtbx.TabIndex = 8;
            this.password_txtbx.Text = "password";
            this.password_txtbx.Visible = false;
            // 
            // panelEntry
            // 
            this.panelEntry.Controls.Add(this.password_txtbx);
            this.panelEntry.Controls.Add(this.username_txtbx);
            this.panelEntry.Controls.Add(this.buttonSignup);
            this.panelEntry.Controls.Add(this.labelPassword);
            this.panelEntry.Controls.Add(this.labelUsername);
            this.panelEntry.Controls.Add(this.textBoxPassword);
            this.panelEntry.Controls.Add(this.buttonLogin);
            this.panelEntry.Controls.Add(this.labelLoginText);
            this.panelEntry.Controls.Add(this.textBoxUsername);
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntry.Location = new System.Drawing.Point(0, 0);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(882, 557);
            this.panelEntry.TabIndex = 0;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 557);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelShare);
            this.Controls.Add(this.panelEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelLoginText;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Panel panelEntry;
        private System.Windows.Forms.Label labelFolderList;
        private System.Windows.Forms.Label labelSharedFolders;
        private System.Windows.Forms.Label labelMoreInfo;
        private System.Windows.Forms.Label labelStatusConnectShare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

