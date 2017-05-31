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
    public class CustomerDataUpdate : CustomerData
    {
        
        public void customerDataUpdate() {
            customerData();
            CID_txt.ReadOnly = false;
            CID_txt.Enabled = true;
            submit_btn.Text = "Update Data";
            CID_txt.TextChanged += CID_txt_TextChanged;
        }
        #region "Update Button Functions"
        void CID_txt_TextChanged(object sender, EventArgs e)
        {
            //Customer Update Data Clear Start -->
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
            //Customer Update Data Clear End <--
            cls.con.Open();
            OleDbCommand cmd1 = new OleDbCommand(@"Select CID from Customer;", cls.con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                if (CID_txt.Text == (dr1["CID"]).ToString())
                {
                    OleDbCommand cmd = new OleDbCommand(@"Select * from Customer where CID = '" + CID_txt.Text + "'", cls.con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cname_txt.Text = (dr["cname"]).ToString();
                        caddress_txt.Text = (dr["caddress"]).ToString();
                        city_txt.Text = (dr["city"]).ToString();
                        ph1_txt.Text = (dr["ph1"]).ToString();
                        ph2_txt.Text = (dr["ph2"]).ToString();
                        cperson_txt.Text = (dr["contectperson"]).ToString();
                        cph_txt.Text = (dr["cpph"]).ToString();
                        cemail_txt.Text = (dr["cemail"]).ToString();
                        creditlmt_txt.Text = (dr["creditlimit"]).ToString();
                        grp_comBox.Text = (dr["cgroup"]).ToString();
                        active_comBox.Text = (dr["cstatus"]).ToString();

                    }
                    grp_comBox.Items.Clear();
                    OleDbCommand cmd2 = new OleDbCommand("Select GrpName from CusGroup;", cls.con);
                    OleDbDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        grp_comBox.Items.Add(dr2["GrpName"]);
                    }
                }
            }

            cls.con.Close();
        }

        public override void submit_btn_Click(object sender, EventArgs e)
        {
            bool a = false;
            cls.con.Open();
            OleDbCommand cmd1 = new OleDbCommand(@"Select CID from Customer;", cls.con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (CID_txt.Text == (dr1["CID"]).ToString())
                    {
                        a = true;
                    }
                }
                cls.con.Close();
            if (cname_txt.Text != "" && caddress_txt.Text != "" && city_txt.Text != "" && ph1_txt.Text != "" && ph2_txt.Text != "" && cperson_txt.Text != "" && cph_txt.Text != "" && cemail_txt.Text != "" && creditlmt_txt.Text != "" && grp_comBox.Text != "" && active_comBox.Text != "Choose Status" && active_comBox.Text != "" && a == true)
            {
                cls.con.Open();
                
                        OleDbCommand cmd = new OleDbCommand("Update Customer set Cname = '" + cname_txt.Text + "', CAddress='" + caddress_txt.Text + "', City='" + city_txt.Text + "', PH1='" + ph1_txt.Text + "', PH2='" + ph2_txt.Text + "', ContectPerson='" + cperson_txt.Text + "', CPPH='" + cph_txt.Text + "', CEMAIL='" + cemail_txt.Text + "', CreditLimit='" + creditlmt_txt.Text + "', CGroup='" + grp_comBox.Text + "', CStatus='" + active_comBox.Text + "', Approval = 'Unapproved' where CID='" + CID_txt.Text + "'", cls.con);
                        cmd.ExecuteNonQuery();
                cls.con.Close();
                        MessageBox.Show("Data Updated Successfully!");
                        //Customer Update Data Clear Start -->
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
                        //Customer Update Data Clear End <--

            }
            else
                MessageBox.Show("Please Insert Correct Data");
            
        }
        #endregion
    }
}
