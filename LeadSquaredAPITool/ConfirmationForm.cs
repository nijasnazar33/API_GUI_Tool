using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeadSquaredAPITool
{

    public partial class ConfirmationForm : Form
    {
        private string secretKey;
        private string emailID;

        public ConfirmationForm(string secretKey, string emailID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.secretKey = secretKey;
            this.emailID = emailID;
        }

        private void btnRenewAccessKeyYes_Click(object sender, EventArgs e)
        {
            string[] APIResponse = new string[2];
            Cursor.Current = Cursors.WaitCursor;
            APIResponse = APIAccess.RenewAccessKey(this.secretKey, this.emailID);
            Cursor.Current = Cursors.Default;
            if (APIResponse[0] == "error")
            {
                NotifyForm frm = new NotifyForm(APIResponse[1], "Message", 50);
                frm.Show();
            }
            else
            {
                NotifyForm frm = new NotifyForm("Requested successfully. Please check your inbox", "Message", 50);
                frm.Show();
            }

        }

        private void btnRenewAccessKeyNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
