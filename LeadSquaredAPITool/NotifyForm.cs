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
    public partial class NotifyForm : Form
    {
        public NotifyForm(string message, string title)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;// Or wherever 

            lblMessage.Text = "\r\n" + message;
            this.Text = title;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
