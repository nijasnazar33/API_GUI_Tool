using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeadSquaredAPITool
{
    public partial class Form1 : Form
    {
        private static NameValueCollection[] nmTenantData;
        private static string fieldAPIURL;
        ToolTip toolTip1 = new ToolTip();
        //toolTip1.SetToolTip(this., "My checkBox1");

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //queryString =  new NameValueCollection();
            tbReason.Text = "Report changes";
            //Fetching current public ipV4
            tbIPAddress.Text = APIAccess.GetPublicIP();
            cbFieldAPIList.Text = "Dropdown values of lead field";
            tbAPIActivity.Enabled = false;

            if (File.Exists("config_file.txt"))
            {
                StreamReader reader = new StreamReader("config_file.txt");
                using (reader)
                {
                    tbAccessKey.Text = reader.ReadLine();
                    tbSecretKey.Text = reader.ReadLine();
                    tbEmailID.Text = reader.ReadLine();
                    tbReportLocation.Text = reader.ReadLine();

                }

                nmTenantData = APIAccess.ReadReportSetSessionFile(tbReportLocation.Text);
                for (int i = 0; i < nmTenantData[0].Count; i++)
                {
                    cbTenantList.Items.Add(nmTenantData[0].GetKey(i).ToString());
                }
            }

        }

        private void cbTenantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbShortCode.Text = nmTenantData[0][cbTenantList.Text].ToString();
            tbAuthToken.Text = nmTenantData[1][cbTenantList.Text].ToString();
        }

        private void btnGetAccess_Click(object sender, EventArgs e)
        {
            string[] APIResponse = new string[2];
            Cursor.Current = Cursors.WaitCursor;
            APIResponse = APIAccess.GetTenantAccess(tbAccessKey.Text.ToString(),
                tbSecretKey.Text.ToString(),
                tbShortCode.Text.ToString(),
                tbIPAddress.Text.ToString(),
                tbReason.Text.ToString());
            Cursor.Current = Cursors.Default;
            if (APIResponse[0] == "error")
            {
                NotifyForm frm = new NotifyForm(APIResponse[1], "Message", 75);
                frm.Show();
            }
            else
            {
                tbURL.Text = APIResponse[0];
                tbResponse.Text = APIResponse[1];
            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            StreamWriter writer = new StreamWriter("config_file.txt");
            using (writer)
            {
                writer.WriteLine(tbAccessKey.Text);
                writer.WriteLine(tbSecretKey.Text);
                writer.WriteLine(tbEmailID.Text);
                writer.WriteLine(tbReportLocation.Text);
            }
            Cursor.Current = Cursors.Default;
            NotifyForm frm = new NotifyForm("Saved successfully", "Message", 60);
            frm.Show();
        }


        private void btnRefreshTenants_Click(object sender, EventArgs e)
        {
            nmTenantData = APIAccess.ReadReportSetSessionFile(tbReportLocation.Text);
            cbTenantList.Items.Clear();
            for (int i = 0; i < nmTenantData[0].Count; i++)
            {
                cbTenantList.Items.Add(nmTenantData[0].GetKey(i).ToString());
            }
        }

        private void cbFieldAPIList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFieldAPIList.Text == "Dropdown values of lead field")
            {
                tbAPIField.Enabled = true;
                tbAPIActivity.Enabled = false;
            }
            else if (cbFieldAPIList.Text == "Dropdown values of user field")
            {
                tbAPIField.Enabled = true;
                tbAPIActivity.Enabled = false;
            }
            else if (cbFieldAPIList.Text == "Custom fields of activity")
            {
                tbAPIField.Enabled = false;
                tbAPIActivity.Enabled = true;
            }
            else if (cbFieldAPIList.Text == "Dropdown values of activity field")
            {
                tbAPIField.Enabled = true;
                tbAPIActivity.Enabled = true;
            }
        }

        private void btnCallAPI_Click(object sender, EventArgs e)
        {
            if(tbAuthToken.Text == "")
            {
                NotifyForm frm = new NotifyForm("Please provide AuthToken", "Message", 50);
                frm.Show();
            }
            else
            {
                string[] APIResponse = new string[2];
                Cursor.Current = Cursors.WaitCursor;
                APIResponse = APIAccess.CallFieldAPI(tbAuthToken.Text.ToString(), cbFieldAPIList.Text.ToString(), 
                    tbAPIField.Text.ToString(), tbAPIActivity.Text.ToString());
                Cursor.Current = Cursors.Default;
                if (APIResponse[0] == "error")
                {
                    int errorPadding = 0;
                    if(APIResponse[1] == "Input missing")
                    {
                        errorPadding = 75;
                    }
                    else if(APIResponse[1] == "Some Error Occured")
                    {
                        errorPadding = 50;
                    }
                    NotifyForm frm = new NotifyForm(APIResponse[1], "Message", errorPadding);
                    frm.Show();
                }
                else
                {
                    rtbAPIResult.Text = APIResponse[1];
                    fieldAPIURL = APIResponse[0];
                }
            }
        }

        private void btnViewAPIURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fieldAPIURL);
            NotifyForm frm = new NotifyForm("Copied API call to clipboard.", "Message", 40);
            frm.Show();
        }

        private void btnRenewKey_Click(object sender, EventArgs e)
        {
            if(tbEmailID.Text == "")
            {
                NotifyForm frm = new NotifyForm("Please update registered Email address", "Message", 15);
                frm.Show();
            }
            else if(tbSecretKey.Text == "")
            {
                NotifyForm frm = new NotifyForm("Please update Secret key", "Message", 45);
                frm.Show();
            }
            else
            {
                ConfirmationForm cnf = new ConfirmationForm(tbSecretKey.Text.ToString(), tbEmailID.Text.ToString());
                cnf.Show();
                //*********Need to add confirmation box here******************//
                /*
                string[] APIResponse = new string[2];
                Cursor.Current = Cursors.WaitCursor;
                APIResponse = APIAccess.RenewAccessKey(tbSecretKey.Text.ToString(), tbEmailID.Text.ToString());
                Cursor.Current = Cursors.Default;
                if (APIResponse[0] == "error")
                {
                    NotifyForm frm = new NotifyForm(APIResponse[1], "Message", 50);
                    frm.Show();
                }
                else
                {
                    NotifyForm frm = new NotifyForm(APIResponse[1], "Message", 50);
                    frm.Show();
                }
                */

            }
        }
    }
}
