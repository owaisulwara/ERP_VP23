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
    public class VendorData:CustomerData
    {
        public void vendorData() {
            customerData();
            customer_grp.Text = "Vendor Data";
            CID_lbl.Text = "Vendor ID:";
            cname_lbl.Text = "Vendor Name:";
            creditlmt_lbl.Text = "Fax Number";
            creditlmt_lbl.Size = new Size(100, 20);
        }
        public override void submit_btn_Click(object sender, EventArgs e)
        {
            if (cname_txt.Text != "" && caddress_txt.Text != "" && city_txt.Text != "" && ph1_txt.Text != "" && ph2_txt.Text != "" && cperson_txt.Text != "" && cph_txt.Text != "" && cemail_txt.Text != "" && creditlmt_txt.Text != "" && grp_comBox.Text != "" && active_comBox.Text != "Choose Status" && active_comBox.Text != "")
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID, VName, VAddress, VCity, PH1, PH2, CPName, CPPH, VEmail, VFax, VStatus, VGroup, Approval)values(@VID, @VName, @VAddress, @VCity, @PH1, @PH2, @CPName, @CPPH, @VEmail, @VFax, @VStatus, @VGroup, 'Unapproved')", cls.con);
                cmd.Parameters.AddWithValue("@VID", CID_txt.Text);
                cmd.Parameters.AddWithValue("@VName", cname_txt.Text);
                cmd.Parameters.AddWithValue("@VAddress", caddress_txt.Text);
                cmd.Parameters.AddWithValue("@VCity", city_txt.Text);
                cmd.Parameters.AddWithValue("@PH1", ph1_txt.Text);
                cmd.Parameters.AddWithValue("@PH2", ph2_txt.Text);
                cmd.Parameters.AddWithValue("@CPName", cperson_txt.Text);
                cmd.Parameters.AddWithValue("@CPPH", cph_txt.Text);
                cmd.Parameters.AddWithValue("@VEmail", cemail_txt.Text);
                cmd.Parameters.AddWithValue("@VFax", creditlmt_txt.Text);
                cmd.Parameters.AddWithValue("@VStatus", active_comBox.Text);
                cmd.Parameters.AddWithValue("@VGroup", grp_comBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Entered Successfully!");
                //Customer Insert Data Clear Start -->
                CID_txt.Clear();
                cname_txt.Clear();
                caddress_txt.Clear();
                city_txt.Clear();
                ph1_txt.Clear();
                ph2_txt.Clear();
                cperson_txt.Clear();
                cph_txt.Clear();
                cemail_txt.Clear();
                creditlmt_txt.Clear();
                active_comBox.Items.Clear();
                active_comBox.Items.Add("Active");
                active_comBox.Items.Add("InActive");
                grp_comBox.Items.Clear();
                //Customer Insert Data Clear End <--
                OleDbCommand cmd1 = new OleDbCommand("Select VID from Vendor;", cls.con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                int d = 0;
                while (dr1.Read())
                {
                    d++;
                }
                CID_txt.Text = "VID-00" + (d + 1).ToString() + DateTime.Today.Year;
                OleDbCommand cmd2 = new OleDbCommand("Select GrpName from CusGroup;", cls.con);
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    grp_comBox.Items.Add(dr2["GrpName"]);
                }
                cls.con.Close();
            }
            else
                MessageBox.Show("Please Insert Correct Data");
        }
    }
}
