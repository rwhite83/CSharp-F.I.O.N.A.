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
            this.components = new System.ComponentModel.Container();
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
            this.labelDownloadFolder = new System.Windows.Forms.Label();
            this.buttonDownloadShow = new System.Windows.Forms.Button();
            this.buttonDownloadPicker = new System.Windows.Forms.Button();
            this.labelDownloadPath = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelConnectList = new System.Windows.Forms.Panel();
            this.labelNoShared = new System.Windows.Forms.Label();
            this.buttonConnectBack = new System.Windows.Forms.Button();
            this.textBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.labelLoginText = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.textBoxSignupEmail = new System.Windows.Forms.TextBox();
            this.textBoxSignupPassword = new System.Windows.Forms.TextBox();
            this.panelEntry = new System.Windows.Forms.Panel();
            this.labelPasswordWarning = new System.Windows.Forms.Label();
            this.labelSignupConfirm = new System.Windows.Forms.Label();
            this.textBoxSignupConfirm = new System.Windows.Forms.TextBox();
            this.labelSignupPassword = new System.Windows.Forms.Label();
            this.labelSignupEmail = new System.Windows.Forms.Label();
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
            this.labelFolderList.Text = "No folder currently set to share";
            // 
            // labelSharedFolders
            // 
            this.labelSharedFolders.AutoSize = true;
            this.labelSharedFolders.BackColor = System.Drawing.SystemColors.Control;
            this.labelSharedFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSharedFolders.Location = new System.Drawing.Point(79, 296);
            this.labelSharedFolders.Name = "labelSharedFolders";
            this.labelSharedFolders.Size = new System.Drawing.Size(378, 37);
            this.labelSharedFolders.TabIndex = 9;
            this.labelSharedFolders.Text = "Selected Folder to Share:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.DarkRed;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.OrangeRed;
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
            this.buttonBack.Location = new System.Drawing.Point(68, 64);
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
            this.panelMainMenu.Controls.Add(this.labelStatusConnectShare);
            this.panelMainMenu.Controls.Add(this.labelMoreInfo);
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
            // labelStatusConnectShare
            // 
            this.labelStatusConnectShare.AutoSize = true;
            this.labelStatusConnectShare.BackColor = System.Drawing.Color.DarkRed;
            this.labelStatusConnectShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusConnectShare.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelStatusConnectShare.Location = new System.Drawing.Point(544, 82);
            this.labelStatusConnectShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusConnectShare.Name = "labelStatusConnectShare";
            this.labelStatusConnectShare.Size = new System.Drawing.Size(642, 73);
            this.labelStatusConnectShare.TabIndex = 8;
            this.labelStatusConnectShare.Text = "Server Status: Offline";
            // 
            // labelMoreInfo
            // 
            this.labelMoreInfo.AutoSize = true;
            this.labelMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoreInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMoreInfo.Location = new System.Drawing.Point(262, 125);
            this.labelMoreInfo.Name = "labelMoreInfo";
            this.labelMoreInfo.Size = new System.Drawing.Size(75, 20);
            this.labelMoreInfo.TabIndex = 4;
            this.labelMoreInfo.Text = "more info";
            this.labelMoreInfo.Click += new System.EventHandler(this.LabelMoreInfo_Click);
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
            this.buttonLogout.Location = new System.Drawing.Point(497, 648);
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
            this.buttonShareMain.Location = new System.Drawing.Point(735, 296);
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
            this.buttonConnectMain.Location = new System.Drawing.Point(125, 296);
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
            this.panelConnect.Controls.Add(this.labelDownloadFolder);
            this.panelConnect.Controls.Add(this.buttonDownloadShow);
            this.panelConnect.Controls.Add(this.buttonDownloadPicker);
            this.panelConnect.Controls.Add(this.labelDownloadPath);
            this.panelConnect.Controls.Add(this.buttonRefresh);
            this.panelConnect.Controls.Add(this.panelConnectList);
            this.panelConnect.Controls.Add(this.buttonConnectBack);
            this.panelConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConnect.Location = new System.Drawing.Point(0, 0);
            this.panelConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(1323, 870);
            this.panelConnect.TabIndex = 4;
            // 
            // labelDownloadFolder
            // 
            this.labelDownloadFolder.AutoSize = true;
            this.labelDownloadFolder.Location = new System.Drawing.Point(99, 760);
            this.labelDownloadFolder.Name = "labelDownloadFolder";
            this.labelDownloadFolder.Size = new System.Drawing.Size(264, 25);
            this.labelDownloadFolder.TabIndex = 9;
            this.labelDownloadFolder.Text = "Selected Download Folder";
            // 
            // buttonDownloadShow
            // 
            this.buttonDownloadShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadShow.Location = new System.Drawing.Point(1107, 756);
            this.buttonDownloadShow.Name = "buttonDownloadShow";
            this.buttonDownloadShow.Size = new System.Drawing.Size(188, 94);
            this.buttonDownloadShow.TabIndex = 8;
            this.buttonDownloadShow.Text = "Show Folder (dl)";
            this.buttonDownloadShow.UseVisualStyleBackColor = true;
            this.buttonDownloadShow.Click += new System.EventHandler(this.ButtonDownloadShow_Click);
            // 
            // buttonDownloadPicker
            // 
            this.buttonDownloadPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadPicker.Location = new System.Drawing.Point(902, 756);
            this.buttonDownloadPicker.Name = "buttonDownloadPicker";
            this.buttonDownloadPicker.Size = new System.Drawing.Size(163, 94);
            this.buttonDownloadPicker.TabIndex = 7;
            this.buttonDownloadPicker.Text = "Pick Folder";
            this.buttonDownloadPicker.UseVisualStyleBackColor = true;
            this.buttonDownloadPicker.Click += new System.EventHandler(this.ButtonDownloadPicker_Click);
            // 
            // labelDownloadPath
            // 
            this.labelDownloadPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDownloadPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDownloadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.labelDownloadPath.Location = new System.Drawing.Point(68, 795);
            this.labelDownloadPath.Name = "labelDownloadPath";
            this.labelDownloadPath.Size = new System.Drawing.Size(691, 39);
            this.labelDownloadPath.TabIndex = 6;
            this.labelDownloadPath.Text = "Download folder not yet selected";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(49, 19);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(207, 106);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "refresh (get listing)";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // panelConnectList
            // 
            this.panelConnectList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelConnectList.Controls.Add(this.labelNoShared);
            this.panelConnectList.Location = new System.Drawing.Point(19, 140);
            this.panelConnectList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConnectList.Name = "panelConnectList";
            this.panelConnectList.Size = new System.Drawing.Size(1287, 586);
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
            this.buttonConnectBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectBack.Location = new System.Drawing.Point(282, 19);
            this.buttonConnectBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnectBack.Name = "buttonConnectBack";
            this.buttonConnectBack.Size = new System.Drawing.Size(912, 112);
            this.buttonConnectBack.TabIndex = 4;
            this.buttonConnectBack.Text = "Go Back";
            this.buttonConnectBack.UseVisualStyleBackColor = true;
            this.buttonConnectBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxLoginEmail
            // 
            this.textBoxLoginEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginEmail.Location = new System.Drawing.Point(116, 277);
            this.textBoxLoginEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginEmail.Name = "textBoxLoginEmail";
            this.textBoxLoginEmail.Size = new System.Drawing.Size(668, 38);
            this.textBoxLoginEmail.TabIndex = 2;
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
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(925, 296);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(221, 134);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoginPassword.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(116, 422);
            this.textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(668, 38);
            this.textBoxLoginPassword.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(116, 181);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(131, 51);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Email";
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
            // buttonSignup
            // 
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.Location = new System.Drawing.Point(723, 736);
            this.buttonSignup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(342, 68);
            this.buttonSignup.TabIndex = 6;
            this.buttonSignup.Text = "Create Account";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // textBoxSignupEmail
            // 
            this.textBoxSignupEmail.Location = new System.Drawing.Point(266, 717);
            this.textBoxSignupEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSignupEmail.Name = "textBoxSignupEmail";
            this.textBoxSignupEmail.Size = new System.Drawing.Size(371, 31);
            this.textBoxSignupEmail.TabIndex = 7;
            // 
            // textBoxSignupPassword
            // 
            this.textBoxSignupPassword.Location = new System.Drawing.Point(266, 756);
            this.textBoxSignupPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSignupPassword.Name = "textBoxSignupPassword";
            this.textBoxSignupPassword.PasswordChar = '*';
            this.textBoxSignupPassword.Size = new System.Drawing.Size(371, 31);
            this.textBoxSignupPassword.TabIndex = 8;
            // 
            // panelEntry
            // 
            this.panelEntry.Controls.Add(this.labelPasswordWarning);
            this.panelEntry.Controls.Add(this.labelSignupConfirm);
            this.panelEntry.Controls.Add(this.textBoxSignupConfirm);
            this.panelEntry.Controls.Add(this.labelSignupPassword);
            this.panelEntry.Controls.Add(this.labelSignupEmail);
            this.panelEntry.Controls.Add(this.textBoxSignupPassword);
            this.panelEntry.Controls.Add(this.textBoxSignupEmail);
            this.panelEntry.Controls.Add(this.buttonSignup);
            this.panelEntry.Controls.Add(this.labelPassword);
            this.panelEntry.Controls.Add(this.labelUsername);
            this.panelEntry.Controls.Add(this.textBoxLoginPassword);
            this.panelEntry.Controls.Add(this.buttonLogin);
            this.panelEntry.Controls.Add(this.labelLoginText);
            this.panelEntry.Controls.Add(this.textBoxLoginEmail);
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntry.Location = new System.Drawing.Point(0, 0);
            this.panelEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(1323, 870);
            this.panelEntry.TabIndex = 0;
            // 
            // labelPasswordWarning
            // 
            this.labelPasswordWarning.AutoSize = true;
            this.labelPasswordWarning.Location = new System.Drawing.Point(316, 585);
            this.labelPasswordWarning.Name = "labelPasswordWarning";
            this.labelPasswordWarning.Size = new System.Drawing.Size(659, 25);
            this.labelPasswordWarning.TabIndex = 13;
            this.labelPasswordWarning.Text = "***Warning: passwords transparent to administrators in current build";
            // 
            // labelSignupConfirm
            // 
            this.labelSignupConfirm.AutoSize = true;
            this.labelSignupConfirm.Location = new System.Drawing.Point(142, 795);
            this.labelSignupConfirm.Name = "labelSignupConfirm";
            this.labelSignupConfirm.Size = new System.Drawing.Size(82, 25);
            this.labelSignupConfirm.TabIndex = 12;
            this.labelSignupConfirm.Text = "confirm";
            // 
            // textBoxSignupConfirm
            // 
            this.textBoxSignupConfirm.Location = new System.Drawing.Point(266, 795);
            this.textBoxSignupConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSignupConfirm.Name = "textBoxSignupConfirm";
            this.textBoxSignupConfirm.PasswordChar = '*';
            this.textBoxSignupConfirm.Size = new System.Drawing.Size(371, 31);
            this.textBoxSignupConfirm.TabIndex = 11;
            // 
            // labelSignupPassword
            // 
            this.labelSignupPassword.AutoSize = true;
            this.labelSignupPassword.Location = new System.Drawing.Point(142, 756);
            this.labelSignupPassword.Name = "labelSignupPassword";
            this.labelSignupPassword.Size = new System.Drawing.Size(104, 25);
            this.labelSignupPassword.TabIndex = 10;
            this.labelSignupPassword.Text = "password";
            // 
            // labelSignupEmail
            // 
            this.labelSignupEmail.AutoSize = true;
            this.labelSignupEmail.Location = new System.Drawing.Point(183, 720);
            this.labelSignupEmail.Name = "labelSignupEmail";
            this.labelSignupEmail.Size = new System.Drawing.Size(63, 25);
            this.labelSignupEmail.TabIndex = 9;
            this.labelSignupEmail.Text = "email";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 870);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.panelEntry);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelShare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Application";
            this.Text = "Form1";
            this.panelShare.ResumeLayout(false);
            this.panelShare.PerformLayout();
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxLoginEmail;
        private System.Windows.Forms.Label labelLoginText;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.TextBox textBoxSignupEmail;
        private System.Windows.Forms.TextBox textBoxSignupPassword;
        private System.Windows.Forms.Panel panelEntry;
        private System.Windows.Forms.Label labelFolderList;
        private System.Windows.Forms.Label labelSharedFolders;
        private System.Windows.Forms.Label labelMoreInfo;
        private System.Windows.Forms.Label labelStatusConnectShare;
        private System.Windows.Forms.Label labelSignupPassword;
        private System.Windows.Forms.Label labelSignupEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelSignupConfirm;
        private System.Windows.Forms.TextBox textBoxSignupConfirm;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDownloadShow;
        private System.Windows.Forms.Button buttonDownloadPicker;
        private System.Windows.Forms.Label labelDownloadPath;
        private System.Windows.Forms.Label labelDownloadFolder;
        private System.Windows.Forms.Label labelPasswordWarning;
    }
}

