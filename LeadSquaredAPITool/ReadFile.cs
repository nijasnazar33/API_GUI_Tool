using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeadSquaredAPITool
{


    class ReadFile
    {

        static NameValueCollection short_code = new NameValueCollection();
        static NameValueCollection rdUserName = new NameValueCollection();


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
    }
}
