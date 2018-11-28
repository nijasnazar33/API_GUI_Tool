namespace LeadSquaredAPITool
{
    partial class ConfirmationForm
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
            this.lblAccessKeyConfirmation = new System.Windows.Forms.Label();
            this.btnRenewAccessKeyYes = new System.Windows.Forms.Button();
            this.btnRenewAccessKeyNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccessKeyConfirmation
            // 
            this.lblAccessKeyConfirmation.AutoSize = true;
            this.lblAccessKeyConfirmation.Location = new System.Drawing.Point(37, 23);
            this.lblAccessKeyConfirmation.Name = "lblAccessKeyConfirmation";
            this.lblAccessKeyConfirmation.Size = new System.Drawing.Size(221, 13);
            this.lblAccessKeyConfirmation.TabIndex = 0;
            this.lblAccessKeyConfirmation.Text = "Are you sure you want to renew Access Key?";
            // 
            // btnRenewAccessKeyYes
            // 
            this.btnRenewAccessKeyYes.Location = new System.Drawing.Point(53, 52);
            this.btnRenewAccessKeyYes.Name = "btnRenewAccessKeyYes";
            this.btnRenewAccessKeyYes.Size = new System.Drawing.Size(75, 23);
            this.btnRenewAccessKeyYes.TabIndex = 1;
            this.btnRenewAccessKeyYes.Text = "Yes";
            this.btnRenewAccessKeyYes.UseVisualStyleBackColor = true;
            this.btnRenewAccessKeyYes.Click += new System.EventHandler(this.btnRenewAccessKeyYes_Click);
            // 
            // btnRenewAccessKeyNo
            // 
            this.btnRenewAccessKeyNo.Location = new System.Drawing.Point(156, 52);
            this.btnRenewAccessKeyNo.Name = "btnRenewAccessKeyNo";
            this.btnRenewAccessKeyNo.Size = new System.Drawing.Size(75, 23);
            this.btnRenewAccessKeyNo.TabIndex = 2;
            this.btnRenewAccessKeyNo.Text = "No";
            this.btnRenewAccessKeyNo.UseVisualStyleBackColor = true;
            this.btnRenewAccessKeyNo.Click += new System.EventHandler(this.btnRenewAccessKeyNo_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 101);
            this.Controls.Add(this.btnRenewAccessKeyNo);
            this.Controls.Add(this.btnRenewAccessKeyYes);
            this.Controls.Add(this.lblAccessKeyConfirmation);
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccessKeyConfirmation;
        private System.Windows.Forms.Button btnRenewAccessKeyYes;
        private System.Windows.Forms.Button btnRenewAccessKeyNo;
    }
}