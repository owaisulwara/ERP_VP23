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
    public class VendorDataView:VendorDataUpdate
    {
        public void vendorDataView() {
            vendorDataUpdate();
            submit_btn.Visible = false;
            cname_txt.Enabled = false;
            caddress_txt.Enabled = false;
            city_txt.Enabled = false;
            ph1_txt.Enabled = false;
            ph2_txt.Enabled = false;
            cperson_txt.Enabled = false;
            cph_txt.Enabled = false;
            cemail_txt.Enabled = false;
            creditlmt_txt.Enabled = false;
            active_comBox.Enabled = false;
            grp_comBox.Enabled = false;
        }
    }
}
