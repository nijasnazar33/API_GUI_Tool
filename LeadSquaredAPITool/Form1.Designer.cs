namespace LeadSquaredAPITool
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
            this.tbShortCode = new System.Windows.Forms.TextBox();
            this.tbAuthToken = new System.Windows.Forms.TextBox();
            this.lblShortCode = new System.Windows.Forms.Label();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.cbTenantList = new System.Windows.Forms.ComboBox();
            this.btnGetAccess = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTenantAccess = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.lblAuthToken = new System.Windows.Forms.Label();
            this.tabCustomField = new System.Windows.Forms.TabPage();
            this.lblReason = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.lblAccessKey = new System.Windows.Forms.Label();
            this.tbAccessKey = new System.Windows.Forms.TextBox();
            this.tbSecretKey = new System.Windows.Forms.TextBox();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.lblReportLocation = new System.Windows.Forms.Label();
            this.tbReportLocation = new System.Windows.Forms.TextBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTenantAccess.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabCustomField.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbShortCode
            // 
            this.tbShortCode.Location = new System.Drawing.Point(83, 19);
            this.tbShortCode.Name = "tbShortCode";
            this.tbShortCode.Size = new System.Drawing.Size(152, 20);
            this.tbShortCode.TabIndex = 0;
            // 
            // tbAuthToken
            // 
            this.tbAuthToken.Location = new System.Drawing.Point(107, 26);
            this.tbAuthToken.Name = "tbAuthToken";
            this.tbAuthToken.Size = new System.Drawing.Size(395, 20);
            this.tbAuthToken.TabIndex = 1;
            // 
            // lblShortCode
            // 
            this.lblShortCode.AutoSize = true;
            this.lblShortCode.Location = new System.Drawing.Point(18, 22);
            this.lblShortCode.Name = "lblShortCode";
            this.lblShortCode.Size = new System.Drawing.Size(60, 13);
            this.lblShortCode.TabIndex = 2;
            this.lblShortCode.Text = "Short Code";
            // 
            // lblTenantName
            // 
            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Location = new System.Drawing.Point(40, 15);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(41, 13);
            this.lblTenantName.TabIndex = 4;
            this.lblTenantName.Text = "Tenant";
            // 
            // cbTenantList
            // 
            this.cbTenantList.FormattingEnabled = true;
            this.cbTenantList.Location = new System.Drawing.Point(90, 12);
            this.cbTenantList.Name = "cbTenantList";
            this.cbTenantList.Size = new System.Drawing.Size(121, 21);
            this.cbTenantList.TabIndex = 7;
            this.cbTenantList.SelectedIndexChanged += new System.EventHandler(this.cbTenantList_SelectedIndexChanged);
            // 
            // btnGetAccess
            // 
            this.btnGetAccess.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetAccess.Location = new System.Drawing.Point(83, 86);
            this.btnGetAccess.Name = "btnGetAccess";
            this.btnGetAccess.Size = new System.Drawing.Size(75, 23);
            this.btnGetAccess.TabIndex = 8;
            this.btnGetAccess.Text = "Get Access";
            this.btnGetAccess.UseVisualStyleBackColor = true;
            this.btnGetAccess.Click += new System.EventHandler(this.btnGetAccess_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(18, 122);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 9;
            this.lblURL.Text = "URL:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(24, 140);
            this.tbURL.Name = "tbURL";
            this.tbURL.ReadOnly = true;
            this.tbURL.Size = new System.Drawing.Size(686, 20);
            this.tbURL.TabIndex = 10;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(18, 180);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 11;
            this.lblResponse.Text = "Response:";
            // 
            // tbResponse
            // 
            this.tbResponse.Location = new System.Drawing.Point(24, 198);
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.ReadOnly = true;
            this.tbResponse.Size = new System.Drawing.Size(686, 20);
            this.tbResponse.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTenantAccess);
            this.tabControl1.Controls.Add(this.tabCustomField);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Location = new System.Drawing.Point(9, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 271);
            this.tabControl1.TabIndex = 13;
            // 
            // tabTenantAccess
            // 
            this.tabTenantAccess.Controls.Add(this.tbReason);
            this.tabTenantAccess.Controls.Add(this.lblReason);
            this.tabTenantAccess.Controls.Add(this.tbResponse);
            this.tabTenantAccess.Controls.Add(this.lblResponse);
            this.tabTenantAccess.Controls.Add(this.btnGetAccess);
            this.tabTenantAccess.Controls.Add(this.tbURL);
            this.tabTenantAccess.Controls.Add(this.lblURL);
            this.tabTenantAccess.Controls.Add(this.tbShortCode);
            this.tabTenantAccess.Controls.Add(this.lblShortCode);
            this.tabTenantAccess.Location = new System.Drawing.Point(4, 22);
            this.tabTenantAccess.Name = "tabTenantAccess";
            this.tabTenantAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tabTenantAccess.Size = new System.Drawing.Size(727, 245);
            this.tabTenantAccess.TabIndex = 0;
            this.tabTenantAccess.Text = "Tenant Access";
            this.tabTenantAccess.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.btnSaveInfo);
            this.tabConfig.Controls.Add(this.tbReportLocation);
            this.tabConfig.Controls.Add(this.lblReportLocation);
            this.tabConfig.Controls.Add(this.tbIPAddress);
            this.tabConfig.Controls.Add(this.lblIPAddress);
            this.tabConfig.Controls.Add(this.lblSecretKey);
            this.tabConfig.Controls.Add(this.tbSecretKey);
            this.tabConfig.Controls.Add(this.tbAccessKey);
            this.tabConfig.Controls.Add(this.lblAccessKey);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(727, 245);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // lblAuthToken
            // 
            this.lblAuthToken.AutoSize = true;
            this.lblAuthToken.Location = new System.Drawing.Point(27, 33);
            this.lblAuthToken.Name = "lblAuthToken";
            this.lblAuthToken.Size = new System.Drawing.Size(63, 13);
            this.lblAuthToken.TabIndex = 3;
            this.lblAuthToken.Text = "Auth Token";
            // 
            // tabCustomField
            // 
            this.tabCustomField.Controls.Add(this.tbAuthToken);
            this.tabCustomField.Controls.Add(this.lblAuthToken);
            this.tabCustomField.Location = new System.Drawing.Point(4, 22);
            this.tabCustomField.Name = "tabCustomField";
            this.tabCustomField.Size = new System.Drawing.Size(727, 245);
            this.tabCustomField.TabIndex = 2;
            this.tabCustomField.Text = "Custom Fields";
            this.tabCustomField.UseVisualStyleBackColor = true;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(18, 55);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 13;
            this.lblReason.Text = "Reason";
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(83, 48);
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(152, 20);
            this.tbReason.TabIndex = 14;
            // 
            // lblAccessKey
            // 
            this.lblAccessKey.AutoSize = true;
            this.lblAccessKey.Location = new System.Drawing.Point(30, 33);
            this.lblAccessKey.Name = "lblAccessKey";
            this.lblAccessKey.Size = new System.Drawing.Size(63, 13);
            this.lblAccessKey.TabIndex = 0;
            this.lblAccessKey.Text = "Access Key";
            // 
            // tbAccessKey
            // 
            this.tbAccessKey.Location = new System.Drawing.Point(158, 26);
            this.tbAccessKey.Name = "tbAccessKey";
            this.tbAccessKey.Size = new System.Drawing.Size(305, 20);
            this.tbAccessKey.TabIndex = 1;
            // 
            // tbSecretKey
            // 
            this.tbSecretKey.Location = new System.Drawing.Point(158, 52);
            this.tbSecretKey.Name = "tbSecretKey";
            this.tbSecretKey.Size = new System.Drawing.Size(305, 20);
            this.tbSecretKey.TabIndex = 2;
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(30, 59);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(59, 13);
            this.lblSecretKey.TabIndex = 3;
            this.lblSecretKey.Text = "Secret Key";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(30, 85);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(58, 13);
            this.lblIPAddress.TabIndex = 4;
            this.lblIPAddress.Text = "IP Address";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(158, 78);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(305, 20);
            this.tbIPAddress.TabIndex = 5;
            // 
            // lblReportLocation
            // 
            this.lblReportLocation.AutoSize = true;
            this.lblReportLocation.Location = new System.Drawing.Point(30, 112);
            this.lblReportLocation.Name = "lblReportLocation";
            this.lblReportLocation.Size = new System.Drawing.Size(124, 13);
            this.lblReportLocation.TabIndex = 6;
            this.lblReportLocation.Text = "Report Process Location";
            // 
            // tbReportLocation
            // 
            this.tbReportLocation.Location = new System.Drawing.Point(158, 105);
            this.tbReportLocation.Name = "tbReportLocation";
            this.tbReportLocation.Size = new System.Drawing.Size(305, 20);
            this.tbReportLocation.TabIndex = 7;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(158, 150);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInfo.TabIndex = 8;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 381);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbTenantList);
            this.Controls.Add(this.lblTenantName);
            this.Name = "Form1";
            this.Text = "LeadSquared API Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabTenantAccess.ResumeLayout(false);
            this.tabTenantAccess.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.tabCustomField.ResumeLayout(false);
            this.tabCustomField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbShortCode;
        private System.Windows.Forms.TextBox tbAuthToken;
        private System.Windows.Forms.Label lblShortCode;
        private System.Windows.Forms.Label lblTenantName;
        private System.Windows.Forms.ComboBox cbTenantList;
        private System.Windows.Forms.Button btnGetAccess;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTenantAccess;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabCustomField;
        private System.Windows.Forms.Label lblAuthToken;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblSecretKey;
        private System.Windows.Forms.TextBox tbSecretKey;
        private System.Windows.Forms.TextBox tbAccessKey;
        private System.Windows.Forms.Label lblAccessKey;
        private System.Windows.Forms.TextBox tbReportLocation;
        private System.Windows.Forms.Label lblReportLocation;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button btnSaveInfo;
    }
}

