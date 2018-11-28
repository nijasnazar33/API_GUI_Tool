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
            this.tbReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.tabCustomField = new System.Windows.Forms.TabPage();
            this.btnViewAPIURL = new System.Windows.Forms.Button();
            this.lblAPIResult = new System.Windows.Forms.Label();
            this.rtbAPIResult = new System.Windows.Forms.RichTextBox();
            this.btnCallAPI = new System.Windows.Forms.Button();
            this.tbAPIActivity = new System.Windows.Forms.TextBox();
            this.lblAPIActivity = new System.Windows.Forms.Label();
            this.tbAPIField = new System.Windows.Forms.TextBox();
            this.lblAPIField = new System.Windows.Forms.Label();
            this.lblFieldAPI = new System.Windows.Forms.Label();
            this.cbFieldAPIList = new System.Windows.Forms.ComboBox();
            this.lblAuthToken = new System.Windows.Forms.Label();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tbEmailID = new System.Windows.Forms.TextBox();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.btnRenewKey = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.tbReportLocation = new System.Windows.Forms.TextBox();
            this.lblReportLocation = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.tbSecretKey = new System.Windows.Forms.TextBox();
            this.tbAccessKey = new System.Windows.Forms.TextBox();
            this.lblAccessKey = new System.Windows.Forms.Label();
            this.btnRefreshTenants = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTenantAccess.SuspendLayout();
            this.tabCustomField.SuspendLayout();
            this.tabConfig.SuspendLayout();
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
            this.tbAuthToken.Location = new System.Drawing.Point(100, 26);
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
            this.lblTenantName.Location = new System.Drawing.Point(16, 21);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(41, 13);
            this.lblTenantName.TabIndex = 4;
            this.lblTenantName.Text = "Tenant";
            // 
            // cbTenantList
            // 
            this.cbTenantList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenantList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenantList.FormattingEnabled = true;
            this.cbTenantList.Location = new System.Drawing.Point(63, 18);
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
            this.tbURL.Size = new System.Drawing.Size(645, 20);
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
            this.tbResponse.Size = new System.Drawing.Size(645, 20);
            this.tbResponse.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTenantAccess);
            this.tabControl1.Controls.Add(this.tabCustomField);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Location = new System.Drawing.Point(9, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 294);
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
            this.tabTenantAccess.Size = new System.Drawing.Size(692, 268);
            this.tabTenantAccess.TabIndex = 0;
            this.tabTenantAccess.Text = "Tenant Access";
            this.tabTenantAccess.UseVisualStyleBackColor = true;
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(83, 48);
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(152, 20);
            this.tbReason.TabIndex = 14;
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
            // tabCustomField
            // 
            this.tabCustomField.BackColor = System.Drawing.Color.Transparent;
            this.tabCustomField.Controls.Add(this.btnViewAPIURL);
            this.tabCustomField.Controls.Add(this.lblAPIResult);
            this.tabCustomField.Controls.Add(this.rtbAPIResult);
            this.tabCustomField.Controls.Add(this.btnCallAPI);
            this.tabCustomField.Controls.Add(this.tbAPIActivity);
            this.tabCustomField.Controls.Add(this.lblAPIActivity);
            this.tabCustomField.Controls.Add(this.tbAPIField);
            this.tabCustomField.Controls.Add(this.lblAPIField);
            this.tabCustomField.Controls.Add(this.lblFieldAPI);
            this.tabCustomField.Controls.Add(this.cbFieldAPIList);
            this.tabCustomField.Controls.Add(this.tbAuthToken);
            this.tabCustomField.Controls.Add(this.lblAuthToken);
            this.tabCustomField.Location = new System.Drawing.Point(4, 22);
            this.tabCustomField.Name = "tabCustomField";
            this.tabCustomField.Size = new System.Drawing.Size(692, 268);
            this.tabCustomField.TabIndex = 2;
            this.tabCustomField.Text = "Custom Fields";
            // 
            // btnViewAPIURL
            // 
            this.btnViewAPIURL.Location = new System.Drawing.Point(199, 200);
            this.btnViewAPIURL.Name = "btnViewAPIURL";
            this.btnViewAPIURL.Size = new System.Drawing.Size(75, 23);
            this.btnViewAPIURL.TabIndex = 13;
            this.btnViewAPIURL.Text = "Copy URL";
            this.btnViewAPIURL.UseVisualStyleBackColor = true;
            this.btnViewAPIURL.Click += new System.EventHandler(this.btnViewAPIURL_Click);
            // 
            // lblAPIResult
            // 
            this.lblAPIResult.AutoSize = true;
            this.lblAPIResult.Location = new System.Drawing.Point(312, 61);
            this.lblAPIResult.Name = "lblAPIResult";
            this.lblAPIResult.Size = new System.Drawing.Size(57, 13);
            this.lblAPIResult.TabIndex = 12;
            this.lblAPIResult.Text = "API Result";
            // 
            // rtbAPIResult
            // 
            this.rtbAPIResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbAPIResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAPIResult.Location = new System.Drawing.Point(311, 78);
            this.rtbAPIResult.Name = "rtbAPIResult";
            this.rtbAPIResult.ReadOnly = true;
            this.rtbAPIResult.Size = new System.Drawing.Size(368, 175);
            this.rtbAPIResult.TabIndex = 11;
            this.rtbAPIResult.Text = "";
            // 
            // btnCallAPI
            // 
            this.btnCallAPI.Location = new System.Drawing.Point(111, 200);
            this.btnCallAPI.Name = "btnCallAPI";
            this.btnCallAPI.Size = new System.Drawing.Size(75, 23);
            this.btnCallAPI.TabIndex = 10;
            this.btnCallAPI.Text = "Call API";
            this.btnCallAPI.UseVisualStyleBackColor = true;
            this.btnCallAPI.Click += new System.EventHandler(this.btnCallAPI_Click);
            // 
            // tbAPIActivity
            // 
            this.tbAPIActivity.Location = new System.Drawing.Point(100, 161);
            this.tbAPIActivity.Name = "tbAPIActivity";
            this.tbAPIActivity.Size = new System.Drawing.Size(185, 20);
            this.tbAPIActivity.TabIndex = 9;
            // 
            // lblAPIActivity
            // 
            this.lblAPIActivity.AutoSize = true;
            this.lblAPIActivity.Location = new System.Drawing.Point(27, 168);
            this.lblAPIActivity.Name = "lblAPIActivity";
            this.lblAPIActivity.Size = new System.Drawing.Size(69, 13);
            this.lblAPIActivity.TabIndex = 8;
            this.lblAPIActivity.Text = "Activity Code";
            // 
            // tbAPIField
            // 
            this.tbAPIField.Location = new System.Drawing.Point(100, 123);
            this.tbAPIField.Name = "tbAPIField";
            this.tbAPIField.Size = new System.Drawing.Size(185, 20);
            this.tbAPIField.TabIndex = 7;
            // 
            // lblAPIField
            // 
            this.lblAPIField.AutoSize = true;
            this.lblAPIField.Location = new System.Drawing.Point(30, 130);
            this.lblAPIField.Name = "lblAPIField";
            this.lblAPIField.Size = new System.Drawing.Size(29, 13);
            this.lblAPIField.TabIndex = 6;
            this.lblAPIField.Text = "Field";
            // 
            // lblFieldAPI
            // 
            this.lblFieldAPI.AutoSize = true;
            this.lblFieldAPI.Location = new System.Drawing.Point(27, 81);
            this.lblFieldAPI.Name = "lblFieldAPI";
            this.lblFieldAPI.Size = new System.Drawing.Size(57, 13);
            this.lblFieldAPI.TabIndex = 5;
            this.lblFieldAPI.Text = "Select API";
            // 
            // cbFieldAPIList
            // 
            this.cbFieldAPIList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFieldAPIList.FormattingEnabled = true;
            this.cbFieldAPIList.Items.AddRange(new object[] {
            "Dropdown values of lead field",
            "Dropdown values of user field",
            "Custom fields of activity",
            "Dropdown values of activity field"});
            this.cbFieldAPIList.Location = new System.Drawing.Point(100, 81);
            this.cbFieldAPIList.Name = "cbFieldAPIList";
            this.cbFieldAPIList.Size = new System.Drawing.Size(185, 21);
            this.cbFieldAPIList.TabIndex = 4;
            this.cbFieldAPIList.SelectedIndexChanged += new System.EventHandler(this.cbFieldAPIList_SelectedIndexChanged);
            // 
            // lblAuthToken
            // 
            this.lblAuthToken.AutoSize = true;
            this.lblAuthToken.Location = new System.Drawing.Point(27, 29);
            this.lblAuthToken.Name = "lblAuthToken";
            this.lblAuthToken.Size = new System.Drawing.Size(63, 13);
            this.lblAuthToken.TabIndex = 3;
            this.lblAuthToken.Text = "Auth Token";
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tbEmailID);
            this.tabConfig.Controls.Add(this.lblEmailID);
            this.tabConfig.Controls.Add(this.btnRenewKey);
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
            this.tabConfig.Size = new System.Drawing.Size(692, 268);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tbEmailID
            // 
            this.tbEmailID.Location = new System.Drawing.Point(158, 78);
            this.tbEmailID.Name = "tbEmailID";
            this.tbEmailID.Size = new System.Drawing.Size(305, 20);
            this.tbEmailID.TabIndex = 11;
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.Location = new System.Drawing.Point(30, 85);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(99, 13);
            this.lblEmailID.TabIndex = 10;
            this.lblEmailID.Text = "LeadSquared Email";
            // 
            // btnRenewKey
            // 
            this.btnRenewKey.Location = new System.Drawing.Point(469, 24);
            this.btnRenewKey.Name = "btnRenewKey";
            this.btnRenewKey.Size = new System.Drawing.Size(75, 23);
            this.btnRenewKey.TabIndex = 9;
            this.btnRenewKey.Text = "Renew Key";
            this.btnRenewKey.UseVisualStyleBackColor = true;
            this.btnRenewKey.Click += new System.EventHandler(this.btnRenewKey_Click);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(158, 137);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInfo.TabIndex = 8;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // tbReportLocation
            // 
            this.tbReportLocation.Location = new System.Drawing.Point(158, 105);
            this.tbReportLocation.Name = "tbReportLocation";
            this.tbReportLocation.Size = new System.Drawing.Size(305, 20);
            this.tbReportLocation.TabIndex = 7;
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
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(158, 176);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(305, 20);
            this.tbIPAddress.TabIndex = 5;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(30, 183);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(58, 13);
            this.lblIPAddress.TabIndex = 4;
            this.lblIPAddress.Text = "IP Address";
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
            // tbSecretKey
            // 
            this.tbSecretKey.Location = new System.Drawing.Point(158, 52);
            this.tbSecretKey.Name = "tbSecretKey";
            this.tbSecretKey.Size = new System.Drawing.Size(305, 20);
            this.tbSecretKey.TabIndex = 2;
            // 
            // tbAccessKey
            // 
            this.tbAccessKey.Location = new System.Drawing.Point(158, 26);
            this.tbAccessKey.Name = "tbAccessKey";
            this.tbAccessKey.Size = new System.Drawing.Size(305, 20);
            this.tbAccessKey.TabIndex = 1;
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
            // btnRefreshTenants
            // 
            this.btnRefreshTenants.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRefreshTenants.Image = global::LeadSquaredAPITool.Properties.Resources.iconfinder_sync_126579_16x16;
            this.btnRefreshTenants.Location = new System.Drawing.Point(194, 16);
            this.btnRefreshTenants.Name = "btnRefreshTenants";
            this.btnRefreshTenants.Size = new System.Drawing.Size(27, 23);
            this.btnRefreshTenants.TabIndex = 15;
            this.btnRefreshTenants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshTenants.UseVisualStyleBackColor = true;
            this.btnRefreshTenants.Click += new System.EventHandler(this.btnRefreshTenants_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 353);
            this.Controls.Add(this.btnRefreshTenants);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbTenantList);
            this.Controls.Add(this.lblTenantName);
            this.Name = "Form1";
            this.Text = "LeadSquared API Tool (beta)";
            this.tabControl1.ResumeLayout(false);
            this.tabTenantAccess.ResumeLayout(false);
            this.tabTenantAccess.PerformLayout();
            this.tabCustomField.ResumeLayout(false);
            this.tabCustomField.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
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
        private System.Windows.Forms.Button btnRefreshTenants;
        private System.Windows.Forms.Label lblFieldAPI;
        private System.Windows.Forms.ComboBox cbFieldAPIList;
        private System.Windows.Forms.RichTextBox rtbAPIResult;
        private System.Windows.Forms.Button btnCallAPI;
        private System.Windows.Forms.TextBox tbAPIActivity;
        private System.Windows.Forms.Label lblAPIActivity;
        private System.Windows.Forms.TextBox tbAPIField;
        private System.Windows.Forms.Label lblAPIField;
        private System.Windows.Forms.Label lblAPIResult;
        private System.Windows.Forms.Button btnViewAPIURL;
        private System.Windows.Forms.Button btnRenewKey;
        private System.Windows.Forms.TextBox tbEmailID;
        private System.Windows.Forms.Label lblEmailID;
    }
}

