﻿namespace DBCHM
{
    partial class DBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBForm));
            this.labelControl1 = new System.Windows.Forms.Label();
            this.TxtConnectName = new System.Windows.Forms.TextBox();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.labelControl3 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.labelControl4 = new System.Windows.Forms.Label();
            this.TxtUName = new System.Windows.Forms.TextBox();
            this.labelControl5 = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.labelControl6 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.cboDBType = new System.Windows.Forms.ComboBox();
            this.labDBName = new System.Windows.Forms.Label();
            this.BtnTestConnect = new System.Windows.Forms.Button();
            this.cboDBName = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtConnTimeOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noneSSLCB = new System.Windows.Forms.CheckBox();
            this.requiredSSLCB = new System.Windows.Forms.CheckBox();
            this.sslLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(85, 59);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "连接名";
            // 
            // TxtConnectName
            // 
            this.TxtConnectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConnectName.Location = new System.Drawing.Point(177, 57);
            this.TxtConnectName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtConnectName.Name = "TxtConnectName";
            this.TxtConnectName.Size = new System.Drawing.Size(213, 21);
            this.TxtConnectName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(84, 136);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "主机名或IP地址";
            // 
            // TxtHost
            // 
            this.TxtHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHost.Location = new System.Drawing.Point(176, 133);
            this.TxtHost.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(213, 21);
            this.TxtHost.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(84, 173);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "端口";
            // 
            // TxtPort
            // 
            this.TxtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPort.Location = new System.Drawing.Point(176, 170);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(213, 21);
            this.TxtPort.TabIndex = 3;
            this.TxtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(85, 239);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(100, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "用户名";
            // 
            // TxtUName
            // 
            this.TxtUName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUName.Location = new System.Drawing.Point(177, 237);
            this.TxtUName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUName.Name = "TxtUName";
            this.TxtUName.Size = new System.Drawing.Size(213, 21);
            this.TxtUName.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(85, 270);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 18);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "密码";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPwd.Location = new System.Drawing.Point(177, 268);
            this.TxtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(213, 21);
            this.TxtPwd.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(83, 98);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(134, 15);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "数据库类型";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(346, 380);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(61, 28);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "确定";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(423, 380);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(57, 28);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cboDBType
            // 
            this.cboDBType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDBType.Location = new System.Drawing.Point(176, 93);
            this.cboDBType.Margin = new System.Windows.Forms.Padding(2);
            this.cboDBType.Name = "cboDBType";
            this.cboDBType.Size = new System.Drawing.Size(214, 20);
            this.cboDBType.TabIndex = 1;
            this.cboDBType.SelectedIndexChanged += new System.EventHandler(this.cboDBType_SelectedIndexChanged);
            // 
            // labDBName
            // 
            this.labDBName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labDBName.Location = new System.Drawing.Point(84, 204);
            this.labDBName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDBName.Name = "labDBName";
            this.labDBName.Size = new System.Drawing.Size(108, 20);
            this.labDBName.TabIndex = 2;
            this.labDBName.Text = "数据库";
            // 
            // BtnTestConnect
            // 
            this.BtnTestConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTestConnect.Location = new System.Drawing.Point(32, 380);
            this.BtnTestConnect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTestConnect.Name = "BtnTestConnect";
            this.BtnTestConnect.Size = new System.Drawing.Size(70, 28);
            this.BtnTestConnect.TabIndex = 7;
            this.BtnTestConnect.Text = "连接/测试";
            this.BtnTestConnect.Click += new System.EventHandler(this.BtnTestConnect_Click);
            // 
            // cboDBName
            // 
            this.cboDBName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDBName.Location = new System.Drawing.Point(177, 204);
            this.cboDBName.Margin = new System.Windows.Forms.Padding(2);
            this.cboDBName.Name = "cboDBName";
            this.cboDBName.Size = new System.Drawing.Size(214, 20);
            this.cboDBName.TabIndex = 6;
            this.cboDBName.SelectedIndexChanged += new System.EventHandler(this.cboDBName_SelectedIndexChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(116, 386);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 12);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "lblMsg";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(399, 164);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(81, 29);
            this.btnSelectFile.TabIndex = 11;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // txtConnTimeOut
            // 
            this.txtConnTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnTimeOut.Location = new System.Drawing.Point(178, 303);
            this.txtConnTimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtConnTimeOut.Name = "txtConnTimeOut";
            this.txtConnTimeOut.Size = new System.Drawing.Size(66, 21);
            this.txtConnTimeOut.TabIndex = 13;
            this.txtConnTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConnTimeOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConnectionOut_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(86, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "连接超时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "秒";
            // 
            // noneSSLCB
            // 
            this.noneSSLCB.AutoSize = true;
            this.noneSSLCB.Checked = true;
            this.noneSSLCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noneSSLCB.Location = new System.Drawing.Point(176, 341);
            this.noneSSLCB.Name = "noneSSLCB";
            this.noneSSLCB.Size = new System.Drawing.Size(48, 16);
            this.noneSSLCB.TabIndex = 15;
            this.noneSSLCB.Text = "None";
            this.noneSSLCB.UseVisualStyleBackColor = true;
            this.noneSSLCB.Click += new System.EventHandler(this.noneSSLCB_Click);
            // 
            // requiredSSLCB
            // 
            this.requiredSSLCB.AutoSize = true;
            this.requiredSSLCB.Location = new System.Drawing.Point(230, 341);
            this.requiredSSLCB.Name = "requiredSSLCB";
            this.requiredSSLCB.Size = new System.Drawing.Size(72, 16);
            this.requiredSSLCB.TabIndex = 16;
            this.requiredSSLCB.Text = "Required";
            this.requiredSSLCB.UseVisualStyleBackColor = true;
            this.requiredSSLCB.Click += new System.EventHandler(this.requiredSSLCB_Click);
            // 
            // sslLabel
            // 
            this.sslLabel.AutoSize = true;
            this.sslLabel.Location = new System.Drawing.Point(86, 341);
            this.sslLabel.Name = "sslLabel";
            this.sslLabel.Size = new System.Drawing.Size(47, 12);
            this.sslLabel.TabIndex = 17;
            this.sslLabel.Text = "SSL连接";
            // 
            // DBForm
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(516, 443);
            this.Controls.Add(this.sslLabel);
            this.Controls.Add(this.requiredSSLCB);
            this.Controls.Add(this.noneSSLCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnTimeOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.cboDBName);
            this.Controls.Add(this.cboDBType);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnTestConnect);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.labDBName);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtUName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtHost);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtConnectName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接数据库";
            this.Load += new System.EventHandler(this.DBFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.TextBox TxtConnectName;
        private System.Windows.Forms.Label labelControl2;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.Label labelControl3;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label labelControl4;
        private System.Windows.Forms.TextBox TxtUName;
        private System.Windows.Forms.Label labelControl5;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Label labelControl6;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox cboDBType;
        private System.Windows.Forms.Label labDBName;
        private System.Windows.Forms.Button BtnTestConnect;
        private System.Windows.Forms.ComboBox cboDBName;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtConnTimeOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox noneSSLCB;
        private System.Windows.Forms.CheckBox requiredSSLCB;
        private System.Windows.Forms.Label sslLabel;
    }
}