using System;
using System.Linq;
using System.IO;
using System.Collections.Specialized;



namespace LeadSquaredAPITool
{
    class TestClass
    {
        static void Main2(string[] args)
        {
            /*
            NameValueCollection collection = new NameValueCollection();
            collection.Add("accessKey", "u$r77b4d1498ddd01a19b201291254a1365");
            collection.Add("secretKey", "Mazhuvancherry@1");
            collection.Add("shortCodes", "27849");
            collection.Add("ipAddress", "14.98.2.134");
            collection.Add("reason", "report_changes");
            //string url = "https://devops-api.leadsquared.com:9002/api/tasks/async/MySQLAccess/GetTenantAccess?accessKey=u%24r77b4d1498ddd01a19b201291254a1365&secretKey=Mazhuvancherry%401&shortCodes=27849&ipAddress=14.98.2.134&reason=report_changes";
            string url = "https://devops-api.leadsquared.com:9002/api/tasks/async/MySQLAccess/GetTenantAccess";
            string full_url = url + ToQueryString(collection);
            Console.WriteLine(full_url);
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseText = reader.ReadToEnd();
            Console.WriteLine(responseText);*/

            string filename = @"D:\LeadSquaredReports\_Definitions\_Processes\ReportSetSessionProcess.lgx";
            StreamReader reader = new StreamReader(filename);
            bool in_tenant_div = false;
            NameValueCollection short_code = new NameValueCollection();
            NameValueCollection rdUserName = new NameValueCollection();
            string tenant_name = "";
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
                        //temp = line.Split(' ');
                        foreach (string item in line.Split(' '))
                        {
                            if (item.IndexOf("OrgID=") > -1)
                            {
                                //Console.WriteLine();
                                short_code.Add(tenant_name, item.Split('"')[1]);
                            }
                            if (item.IndexOf("rdUserName=") > -1)
                            {
                                //Console.WriteLine();
                                rdUserName.Add(tenant_name, item.Split('"')[1]);
                            }
                        }
                        in_tenant_div = false;
                    }


                    line = reader.ReadLine();
                }
            }
            for (int i = 0; i < short_code.Count; i++)
            {
                Console.WriteLine(short_code.GetKey(i) + " " + short_code[i]);
            }

            //Console.WriteLine("hello");
            Console.WriteLine(short_code.GetKey(0));
            Console.WriteLine(short_code["ABF"]);







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
