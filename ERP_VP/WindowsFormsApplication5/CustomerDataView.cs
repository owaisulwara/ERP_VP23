using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication5
{
    public class CustomerDataView:CustomerDataApprove
    {
        public void customerDataView() {
            customerDataApprove();
            submit_btn.Visible = false;
            UnapproveBtn.Visible = false;
        }
    }
}
