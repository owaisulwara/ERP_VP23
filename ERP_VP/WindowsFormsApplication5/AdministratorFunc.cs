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
    public class AdministratorFunc:CustomerFunc
    {
        public void adminFunc() {
            customerFunc();
            CustomerData_lbl.Size = new Size(280, 35);
            CustomerData_lbl.Location = new Point(495, 160);
            CustomerData_lbl.Text = "Admin Approval";
            insert_btn.Text = "Customer Data";
            update_btn.Visible = false;
            view_btn.Visible = false;
        }
    }
}
