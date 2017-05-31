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
    public class GRNFunc:CustomerFunc
    {
        public void GRNfunc() {
            customerFunc();
            CustomerData_lbl.Size = new Size(280, 35);
            CustomerData_lbl.Location = new Point(495, 160);
            CustomerData_lbl.Text = "GRN Creation";
            insert_btn.Text = "Create GRN";
            update_btn.Visible = false;
            view_btn.Visible = false;

        }
    }
}
