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
            this.lblAuthToken = new System.Windows.Forms.Label();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.cbTenantList = new System.Windows.Forms.ComboBox();
            this.btnGetAccess = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbShortCode
            // 
            this.tbShortCode.Location = new System.Drawing.Point(90, 69);
            this.tbShortCode.Name = "tbShortCode";
            this.tbShortCode.Size = new System.Drawing.Size(100, 20);
            this.tbShortCode.TabIndex = 0;
            // 
            // tbAuthToken
            // 
            this.tbAuthToken.Location = new System.Drawing.Point(90, 101);
            this.tbAuthToken.Name = "tbAuthToken";
            this.tbAuthToken.Size = new System.Drawing.Size(395, 20);
            this.tbAuthToken.TabIndex = 1;
            // 
            // lblShortCode
            // 
            this.lblShortCode.AutoSize = true;
            this.lblShortCode.Location = new System.Drawing.Point(21, 72);
            this.lblShortCode.Name = "lblShortCode";
            this.lblShortCode.Size = new System.Drawing.Size(60, 13);
            this.lblShortCode.TabIndex = 2;
            this.lblShortCode.Text = "Short Code";
            // 
            // lblAuthToken
            // 
            this.lblAuthToken.AutoSize = true;
            this.lblAuthToken.Location = new System.Drawing.Point(21, 101);
            this.lblAuthToken.Name = "lblAuthToken";
            this.lblAuthToken.Size = new System.Drawing.Size(63, 13);
            this.lblAuthToken.TabIndex = 3;
            this.lblAuthToken.Text = "Auth Token";
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
            this.btnGetAccess.Location = new System.Drawing.Point(65, 149);
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
            this.lblURL.Location = new System.Drawing.Point(24, 187);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 9;
            this.lblURL.Text = "URL:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(24, 214);
            this.tbURL.Name = "tbURL";
            this.tbURL.ReadOnly = true;
            this.tbURL.Size = new System.Drawing.Size(689, 20);
            this.tbURL.TabIndex = 10;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(24, 250);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 11;
            this.lblResponse.Text = "Response:";
            // 
            // tbResponse
            // 
            this.tbResponse.Location = new System.Drawing.Point(27, 276);
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.ReadOnly = true;
            this.tbResponse.Size = new System.Drawing.Size(686, 20);
            this.tbResponse.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 381);
            this.Controls.Add(this.tbResponse);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnGetAccess);
            this.Controls.Add(this.cbTenantList);
            this.Controls.Add(this.lblTenantName);
            this.Controls.Add(this.lblAuthToken);
            this.Controls.Add(this.lblShortCode);
            this.Controls.Add(this.tbAuthToken);
            this.Controls.Add(this.tbShortCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbShortCode;
        private System.Windows.Forms.TextBox tbAuthToken;
        private System.Windows.Forms.Label lblShortCode;
        private System.Windows.Forms.Label lblAuthToken;
        private System.Windows.Forms.Label lblTenantName;
        private System.Windows.Forms.ComboBox cbTenantList;
        private System.Windows.Forms.Button btnGetAccess;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox tbResponse;
    }
}

