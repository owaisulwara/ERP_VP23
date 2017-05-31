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
    public class InvoiceSOFunc:CustomerFunc
    {
        public void invoiceSOFunc()
        {
            customerFunc();
            CustomerData_lbl.Size = new Size(280, 35);
            CustomerData_lbl.Location = new Point(495, 160);
            CustomerData_lbl.Text = "Invoice Creation";
            insert_btn.Text = "Create Invoice";
            update_btn.Visible = false;
            view_btn.Visible = false;
        }
    }
}
