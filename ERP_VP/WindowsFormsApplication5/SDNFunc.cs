using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public class SDNFunc:CustomerFunc
    {
        public void SDNfunc() {
            customerFunc();
            CustomerData_lbl.Size = new Size(260, 35);
            CustomerData_lbl.Location = new Point(510, 160);
            CustomerData_lbl.Text = "SDN Creation";
            insert_btn.Text = "Create SDN";
            update_btn.Visible = false;
            view_btn.Visible = false;
        }
    }
}
