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
    public class VendorFunc:CustomerFunc
    {
        public void vendorFunc() {
            customerFunc();
            CustomerData_lbl.Size = new Size(220, 35);
            CustomerData_lbl.Location = new Point(520, 160);
            CustomerData_lbl.Text = "Vendor Data";
            insert_btn.Text = "Add Vendor Data";
            update_btn.Text = "Update Vendor Data";
            view_btn.Text = "View Vendor Data";
        }
    }
}
