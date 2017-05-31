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
    public class SalesOrderFunc:CustomerFunc
    {
        public void SalesFunc() {
            customerFunc();
            CustomerData_lbl.Size = new Size(210, 35);
            CustomerData_lbl.Location = new Point(520, 160);
            CustomerData_lbl.Text = "Sales Order";
            insert_btn.Text = "Add Sales Order";
            update_btn.Text = "Update Sales Order";
            view_btn.Text = "View Sales Order";
        }
    }
}
