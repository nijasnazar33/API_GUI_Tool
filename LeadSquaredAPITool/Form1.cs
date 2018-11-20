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
        //private static string accessKey = "u$r77b4d1498ddd01a19b201291254a1365";
        //private static string secretKey = "Mazhuvancherry@1";
        //private static string ipAddress = "14.98.2.134";
        private static string baseUrl = "https://devops-api.leadsquared.com:9002/api/tasks/async/MySQLAccess/GetTenantAccess";
        private static NameValueCollection queryString;
        ToolTip toolTip1 = new ToolTip();
        //toolTip1.SetToolTip(this., "My checkBox1");

        public Form1()
        {
            InitializeComponent();
            queryString =  new NameValueCollection();
            tbReason.Text = "Report changes";
            //Fetching current public ipV4
            tbIPAddress.Text = APIAccess.GetPublicIP();

            if (File.Exists("config_file.txt"))
            {
                StreamReader reader = new StreamReader("config_file.txt");
                using (reader)
                {
                    tbAccessKey.Text = reader.ReadLine();
                    tbSecretKey.Text = reader.ReadLine();
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
            queryString.Clear();
            queryString.Add("accessKey", tbAccessKey.Text);
            queryString.Add("secretKey", tbSecretKey.Text);
            queryString.Add("shortCodes", tbShortCode.Text);
            queryString.Add("ipAddress", tbIPAddress.Text);
            queryString.Add("reason", tbReason.Text);
            string full_url = baseUrl + ToQueryString(queryString);
//            NotifyForm frm = new NotifyForm(full_url, "Debug");
//            frm.Show();
            Cursor.Current = Cursors.WaitCursor;
            WebRequest request = HttpWebRequest.Create(full_url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Cursor.Current = Cursors.Default;
            tbURL.Text = full_url;
            tbResponse.Text = reader.ReadToEnd();
        }

        static private string ToQueryString(NameValueCollection nvc)
        {
            var array = (from key in nvc.AllKeys
                         from value in nvc.GetValues(key)
                         select string.Format("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value)))
                .ToArray();

            return "?" + string.Join("&", array);
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            StreamWriter writer = new StreamWriter("config_file.txt");
            using (writer)
            {
                writer.WriteLine(tbAccessKey.Text);
                writer.WriteLine(tbSecretKey.Text);
                //writer.WriteLine(tbIPAddress.Text);
                writer.WriteLine(tbReportLocation.Text);
            }
            Cursor.Current = Cursors.Default;
            NotifyForm frm = new NotifyForm("Saved successfully", "Message");
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
    }
}
