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
        private static string accessKey = "u$r77b4d1498ddd01a19b201291254a1365";
        private static string secretKey = "Mazhuvancherry@1";
        private static string ipAddress = "14.98.2.134";
        private static string baseUrl = "https://devops-api.leadsquared.com:9002/api/tasks/async/MySQLAccess/GetTenantAccess";
        private static NameValueCollection queryString;

        public Form1()
        {
            InitializeComponent();
            nmTenantData = ReadFile.ReadReportSetSessionFile();
            queryString =  new NameValueCollection();
            for (int i=0; i<nmTenantData[0].Count; i++)
            {
                cbTenantList.Items.Add(nmTenantData[0].GetKey(i).ToString());
            }

        }

        private void cbTenantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbShortCode.Text = nmTenantData[0][cbTenantList.Text].ToString();
            tbAuthToken.Text = nmTenantData[1][cbTenantList.Text].ToString();
        }

        private void btnGetAccess_Click(object sender, EventArgs e)
        {
            queryString.Add("accessKey", accessKey);
            queryString.Add("secretKey", secretKey);
            queryString.Add("shortCodes", tbShortCode.Text);
            queryString.Add("ipAddress", ipAddress);
            queryString.Add("reason", "report_changes");
            string full_url = baseUrl + ToQueryString(queryString);
            WebRequest request = HttpWebRequest.Create(full_url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
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
    }
}
