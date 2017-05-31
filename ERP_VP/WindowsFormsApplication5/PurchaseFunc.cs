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
    public class PurchaseFunc:CustomerFunc
    {
        public void pruchaseFunc() {
            customerFunc();
            CustomerData_lbl.Size = new Size(280, 35);
            CustomerData_lbl.Location = new Point(495, 160);
            CustomerData_lbl.Text = "Purchase Order";
            insert_btn.Text = "Add Purchase Order";
            update_btn.Text = "Update Purchase Order";
            view_btn.Text = "View Purchase Order";
        }
    }
}
