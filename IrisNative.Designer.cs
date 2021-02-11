namespace IrisNative
{
    partial class IrisNative
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
            this.grpConnect = new System.Windows.Forms.GroupBox();
            this.grpUpload = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerDir = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.grpConnect.SuspendLayout();
            this.grpUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnect
            // 
            this.grpConnect.Controls.Add(this.btnConnect);
            this.grpConnect.Controls.Add(this.txtPassword);
            this.grpConnect.Controls.Add(this.label2);
            this.grpConnect.Controls.Add(this.txtUsername);
            this.grpConnect.Controls.Add(this.label1);
            this.grpConnect.Controls.Add(this.txtNamespace);
            this.grpConnect.Controls.Add(this.lblNamespace);
            this.grpConnect.Controls.Add(this.txtPort);
            this.grpConnect.Controls.Add(this.lblPort);
            this.grpConnect.Controls.Add(this.lblServer);
            this.grpConnect.Controls.Add(this.txtServer);
            this.grpConnect.Location = new System.Drawing.Point(45, 81);
            this.grpConnect.Name = "grpConnect";
            this.grpConnect.Size = new System.Drawing.Size(375, 751);
            this.grpConnect.TabIndex = 0;
            this.grpConnect.TabStop = false;
            this.grpConnect.Text = "Connection Details";
            // 
            // grpUpload
            // 
            this.grpUpload.Controls.Add(this.btnUpload);
            this.grpUpload.Controls.Add(this.txtServerDir);
            this.grpUpload.Controls.Add(this.label4);
            this.grpUpload.Controls.Add(this.button1);
            this.grpUpload.Controls.Add(this.txtFilename);
            this.grpUpload.Controls.Add(this.label3);
            this.grpUpload.Enabled = false;
            this.grpUpload.Location = new System.Drawing.Point(494, 81);
            this.grpUpload.Name = "grpUpload";
            this.grpUpload.Size = new System.Drawing.Size(602, 751);
            this.grpUpload.TabIndex = 1;
            this.grpUpload.TabStop = false;
            this.grpUpload.Text = "File Upload";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(45, 879);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1301, 113);
            this.txtLog.TabIndex = 2;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(47, 93);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(234, 38);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "127.0.0.1";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(41, 67);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(139, 32);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(48, 161);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(75, 32);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(47, 196);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(234, 38);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "51002";
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(48, 287);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(174, 32);
            this.lblNamespace.TabIndex = 4;
            this.lblNamespace.Text = "Namespace:";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(47, 322);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(234, 38);
            this.txtNamespace.TabIndex = 5;
            this.txtNamespace.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username;";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(47, 440);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 38);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "_SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(47, 549);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 38);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "SYS";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(47, 648);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(243, 62);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "File:";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(49, 106);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(415, 38);
            this.txtFilename.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Server Directory";
            // 
            // txtServerDir
            // 
            this.txtServerDir.Location = new System.Drawing.Point(49, 238);
            this.txtServerDir.Name = "txtServerDir";
            this.txtServerDir.Size = new System.Drawing.Size(465, 38);
            this.txtServerDir.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(69, 375);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(276, 46);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // IrisNative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 1047);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpUpload);
            this.Controls.Add(this.grpConnect);
            this.Name = "IrisNative";
            this.Text = "Form1";
            this.grpConnect.ResumeLayout(false);
            this.grpConnect.PerformLayout();
            this.grpUpload.ResumeLayout(false);
            this.grpUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox grpUpload;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtServerDir;
        private System.Windows.Forms.Label label4;
    }
}

