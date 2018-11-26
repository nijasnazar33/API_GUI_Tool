using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LeadSquaredAPITool
{


    class APIAccess
    {

        static NameValueCollection short_code = new NameValueCollection();
        static NameValueCollection rdUserName = new NameValueCollection();
        private static NameValueCollection queryString = new NameValueCollection();
        private static string baseUrl = "https://devops-api.leadsquared.com:9002/api/tasks/async/MySQLAccess/GetTenantAccess";
        private static string leadFieldUrl = "https://reports.leadsquared.com/CommonServices/GetDropdownValuesForField.aspx";
        private static string userFieldUrl = "https://reports.leadsquared.com/CommonServices/GetUserFieldDropdownValues.aspx";
        private static string activityUrl = "https://reports.leadsquared.com/CommonServices/GetCustomActivityFieldName.aspx";
        private static string activityFieldUrl = "https://reports.leadsquared.com/CommonServices/GetDropdownValuesOfActivityField.aspx";
        private static string renewKeyUrl = "https://devops-api.leadsquared.com:9002/api/User/CreateAccessKeySecretKey";


        static public NameValueCollection[] ReadReportSetSessionFile(string reportLoction)
        {
            string filename = reportLoction+"\\ReportSetSessionProcess.lgx";
            bool in_tenant_div = false;
            string tenant_name = "";
            NameValueCollection[] func_out = new NameValueCollection[2];

            StreamReader reader = new StreamReader(filename);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (in_tenant_div == false && line.IndexOf("<Task ID=\"") > -1)
                    {
                        tenant_name = line.Split('"')[1];
                        in_tenant_div = true;
                    }
                    else if (in_tenant_div == true && line.IndexOf("<SessionParams") > -1)
                    {
                        foreach (string item in line.Split(' '))
                        {
                            if (item.IndexOf("OrgID=") > -1)
                            {
                                short_code.Add(tenant_name, item.Split('"')[1]);
                            }
                            if (item.IndexOf("rdUserName=") > -1)
                            {
                                rdUserName.Add(tenant_name, item.Split('"')[1]);
                            }
                        }
                        in_tenant_div = false;
                    }
                    line = reader.ReadLine();
                }
            }
            func_out[0] = short_code;
            func_out[1] = rdUserName;
            return func_out;
        }

        static public string[] GetTenantAccess(string accessKey, string secretKey,
            string shortCode, string ipAddress, string reason)
        {
            string[] APIResponse = new string[2];
            if (accessKey == "" || secretKey == "" || shortCode == "" || ipAddress == "" || reason == "")
            {
                APIResponse[0] = "error";
                APIResponse[1] = "Input Missing";
            }
            else
            {
                queryString.Clear();
                queryString.Add("accessKey", accessKey);
                queryString.Add("secretKey", secretKey);
                queryString.Add("shortCodes", shortCode);
                queryString.Add("ipAddress", ipAddress);
                queryString.Add("reason", reason);
                string full_url = baseUrl + ToQueryString(queryString);
                WebRequest request = HttpWebRequest.Create(full_url);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                APIResponse[0] = full_url;
                APIResponse[1] = reader.ReadToEnd();
            }
            return APIResponse;
        }

        static private string ToQueryString(NameValueCollection nvc)
        {
            var array = (from key in nvc.AllKeys
                         from value in nvc.GetValues(key)
                         select string.Format("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value)))
                .ToArray();

            return "?" + string.Join("&", array);
        }


        static public string GetPublicIP()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }

        static public string[] CallFieldAPI(string authToken, string apiMode, string leadField, string activityCode)
        {
            string[] APIResponse = new string[2];
            queryString.Clear();
            queryString.Add("AuthToken", authToken);
            string full_url = "";

            if (apiMode == "Dropdown values of lead field")
            {
                if (leadField == "")
                {
                    APIResponse[0] = "error";
                    APIResponse[1] = "Input missing";
                }
                else
                {
                    queryString.Add("type", "xml");
                    queryString.Add("SchemaName", leadField);
                    full_url = leadFieldUrl + ToQueryString(queryString);
                }
            }
            else if (apiMode == "Dropdown values of user field")
            {
                if (leadField == "")
                {
                    APIResponse[0] = "error";
                    APIResponse[1] = "Input missing";
                }
                else
                {
                    queryString.Add("type", "xml");
                    queryString.Add("SchemaName", leadField);
                    full_url = userFieldUrl + ToQueryString(queryString);
                }
            }
            else if (apiMode == "Custom fields of activity")
            {
                if (activityCode == "")
                {
                    APIResponse[0] = "error";
                    APIResponse[1] = "Input missing";
                }
                else
                {
                    queryString.Add("ActivityEvent", activityCode);
                    full_url = activityUrl + ToQueryString(queryString);
                }
            }
            else if (apiMode == "Dropdown values of activity field")
            {
                if (activityCode == "" || leadField == "")
                {
                    APIResponse[0] = "error";
                    APIResponse[1] = "Input missing";
                }
                else
                {
                    queryString.Add("FieldName", leadField);
                    queryString.Add("Code", activityCode);
                    full_url = activityFieldUrl + ToQueryString(queryString);
                }
            }

            if (APIResponse[0] != "error")
            {
                try
                {
                    WebRequest request = HttpWebRequest.Create(full_url);
                    WebResponse response = request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    APIResponse[0] = full_url;
                    string formattedXML = FormatXml(reader.ReadToEnd());
                    APIResponse[1] = formattedXML;
                }
                catch (Exception e)
                {
                    APIResponse[0] = "error";
                    APIResponse[1] = "Some Error Occured";

                }
            }


            return APIResponse;
        }

        static public string[] RenewAccessKey(string secretKey, string emailID)
        {
            string[] APIResponse = new string[2];
            queryString.Clear();
            queryString.Add("emailId", emailID);
            queryString.Add("secretKey", secretKey);
            string full_url = renewKeyUrl + ToQueryString(queryString);
            try
            {
                WebRequest request = HttpWebRequest.Create(full_url);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                APIResponse[0] = full_url;
                APIResponse[1] = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                APIResponse[0] = "error";
                APIResponse[1] = "Some Error Occured";
            }

            return APIResponse;
        }

        static private string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return xml;
            }
        }
    }
}
