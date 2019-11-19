namespace FIONA
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
            this.panelShare = new System.Windows.Forms.Panel();
            this.labelFolderList = new System.Windows.Forms.Label();
            this.labelSharedFolders = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAddShared = new System.Windows.Forms.Button();
            this.buttonShareStart = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.panelShare.Controls.Add(this.button3);
            this.panelShare.Controls.Add(this.buttonAddShared);
            this.panelShare.Controls.Add(this.buttonShareStart);
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
            this.labelSharedFolders.Location = new System.Drawing.Point(91, 278);
            this.labelSharedFolders.Name = "labelSharedFolders";
            this.labelSharedFolders.Size = new System.Drawing.Size(394, 37);
            this.labelSharedFolders.TabIndex = 9;
            this.labelSharedFolders.Text = "Selected Folders to Share:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(23, 179);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(505, 51);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Server is currently Offline";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(424, 676);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 156);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove Shared Folders";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonAddShared
            // 
            this.buttonAddShared.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddShared.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddShared.Location = new System.Drawing.Point(44, 676);
            this.buttonAddShared.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddShared.Name = "buttonAddShared";
            this.buttonAddShared.Size = new System.Drawing.Size(331, 156);
            this.buttonAddShared.TabIndex = 5;
            this.buttonAddShared.Text = "Add Shared Folders";
            this.buttonAddShared.UseVisualStyleBackColor = true;
            this.buttonAddShared.Click += new System.EventHandler(this.ButtonAddShared_Click);
            // 
            // buttonShareStart
            // 
            this.buttonShareStart.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonShareStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShareStart.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonShareStart.Location = new System.Drawing.Point(925, 648);
            this.buttonShareStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShareStart.Name = "buttonShareStart";
            this.buttonShareStart.Size = new System.Drawing.Size(356, 198);
            this.buttonShareStart.TabIndex = 1;
            this.buttonShareStart.Text = "Start Sharing";
            this.buttonShareStart.UseVisualStyleBackColor = false;
            this.buttonShareStart.Click += new System.EventHandler(this.ButtonShareStart_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(19, 19);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(1287, 112);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Go Back / Stop Sharing";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelMainMenu
            // 
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
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.Location = new System.Drawing.Point(116, 74);
            this.labelAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(376, 51);
            this.labelAccountName.TabIndex = 3;
            this.labelAccountName.Text = "Logged in as: Kyle";
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(513, 615);
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
            this.buttonShareMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.buttonConnectMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.textBox1.Location = new System.Drawing.Point(116, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1068, 38);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 702);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(597, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(116, 331);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1068, 38);
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
            this.labelPassword.Location = new System.Drawing.Point(116, 278);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(212, 51);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1009, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 72);
            this.button2.TabIndex = 6;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(116, 445);
            this.username_txtbx.Margin = new System.Windows.Forms.Padding(4);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(371, 31);
            this.username_txtbx.TabIndex = 7;
            this.username_txtbx.Text = "username";
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(116, 501);
            this.password_txtbx.Margin = new System.Windows.Forms.Padding(4);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(371, 31);
            this.password_txtbx.TabIndex = 8;
            this.password_txtbx.Text = "password";
            // 
            // panelEntry
            // 
            this.panelEntry.Controls.Add(this.password_txtbx);
            this.panelEntry.Controls.Add(this.username_txtbx);
            this.panelEntry.Controls.Add(this.button2);
            this.panelEntry.Controls.Add(this.labelPassword);
            this.panelEntry.Controls.Add(this.labelUsername);
            this.panelEntry.Controls.Add(this.textBox2);
            this.panelEntry.Controls.Add(this.button1);
            this.panelEntry.Controls.Add(this.labelLoginText);
            this.panelEntry.Controls.Add(this.textBox1);
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntry.Location = new System.Drawing.Point(0, 0);
            this.panelEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(1323, 870);
            this.panelEntry.TabIndex = 0;
            // 
            // Form1
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
            this.Name = "Form1";
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
        private System.Windows.Forms.Button buttonShareStart;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShareMain;
        private System.Windows.Forms.Button buttonConnectMain;
        private System.Windows.Forms.Button buttonAddShared;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Button buttonConnectBack;
        private System.Windows.Forms.Panel panelConnectList;
        private System.Windows.Forms.Label labelNoShared;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLoginText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Panel panelEntry;
        private System.Windows.Forms.Label labelFolderList;
        private System.Windows.Forms.Label labelSharedFolders;
    }
}

