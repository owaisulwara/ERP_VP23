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
    public class CustomerDataApprove:CustomerDataUpdate
    {
        public Button UnapproveBtn = new Button();

        public void customerDataApprove() {
            customerDataUpdate();
            #region "UnpproveBtn"
            UnapproveBtn.Size = new Size(300, 40);
            UnapproveBtn.Location = new Point(customer_grp.Size.Width / 2 - submit_btn.Size.Width / 2, 490);
            UnapproveBtn.Font = new Font("", 10, FontStyle.Regular);
            UnapproveBtn.ForeColor = Color.White;
            UnapproveBtn.BackColor = Color.DeepSkyBlue;
            UnapproveBtn.FlatStyle = FlatStyle.Flat;
            UnapproveBtn.FlatAppearance.BorderSize = 0;
            UnapproveBtn.Text = "Unapprove";
            UnapproveBtn.Click += UnapproveBtn_Click;
            UnapproveBtn.MouseHover += UnapproveBtn_MouseHover;
            customer_grp.Controls.Add(UnapproveBtn);
            #endregion
            submit_btn.Text = "Approve";
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

        private void UnapproveBtn_MouseHover(object sender, EventArgs e)
        {
            UnapproveBtn.Cursor = Cursors.Hand;
        }

        private void UnapproveBtn_Click(object sender, EventArgs e)
        {
            if (cname_txt.Text != "" && caddress_txt.Text != "" && city_txt.Text != "" && ph1_txt.Text != "" && ph2_txt.Text != "" && cperson_txt.Text != "" && cph_txt.Text != "" && cemail_txt.Text != "" && creditlmt_txt.Text != "" && grp_comBox.Text != "" && active_comBox.Text != "Choose Status" && active_comBox.Text != "")
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand("Update Customer set Approval = 'Unapproved' where CID='" + CID_txt.Text + "'", cls.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Unapproved Successfully!");
                cls.con.Close();
                //Customer Unapprove Data Clear Start -->
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
                //Customer Unapprove Data Clear End <--
            }
            else
                MessageBox.Show("Please Insert Correct Data");
        }
        public override void submit_btn_Click(object sender, EventArgs e)
        {
            if (cname_txt.Text != "" && caddress_txt.Text != "" && city_txt.Text != "" && ph1_txt.Text != "" && ph2_txt.Text != "" && cperson_txt.Text != "" && cph_txt.Text != "" && cemail_txt.Text != "" && creditlmt_txt.Text != "" && grp_comBox.Text != "" && active_comBox.Text != "Choose Status" && active_comBox.Text != "")
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand("Update Customer set Approval = 'Approved' where CID='" + CID_txt.Text + "'", cls.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Approved Successfully!");
                cls.con.Close();
                //Customer Approve Data Clear Start -->
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
            //Customer Approve Data Clear End <--
            }
            else
                MessageBox.Show("Please Insert Correct Data");
        }

    }
}
