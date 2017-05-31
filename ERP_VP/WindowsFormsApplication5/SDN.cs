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
    public class SDN:GRN
    {
        public void SDNData() {
            GRNData();
            POID_lbl.Text = "Sales Order ID:";
            Vendor_lbl.Text = "Customer ID:";
            Vendor_lbl.Size = new Size(90, 20);
            Vendor_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - Vendor_lbl.Size.Width / 2, 105);
            VName_lbl.Text = "Customer Name:";
            VName_lbl.Size = new Size(115, 20);
            VName_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - VName_lbl.Size.Width / 2, 155);
            DDate_lbl.Text = "Receive Date:";
            DDate_lbl.Size = new Size(100, 20);
            DDate_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - DDate_lbl.Size.Width / 2, 305);
            GRNID_lbl.Text = "SDN ID:";
            GDate_lbl.Text = "SDN Date:";
            create_Btn.Text = "Create SDN";
        }
        #region "POID"
        void POID_comBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public override void POID_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select * from SOProducts WHERE SOID = '" + POID_comBox.Text + "';", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PModel_txt.Text = (dr["PModel"]).ToString();
                PQuantity_txt.Text = (dr["PQty"]).ToString();
            }
            OleDbCommand cmd2 = new OleDbCommand(@"Select * from SO where SOID = '" + POID_comBox.Text + "';", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                Vendor_txt.Text = (dr2["CID"]).ToString();
                VName_txt.Text = (dr2["CName"]).ToString();
                DDate_txt.Text = (dr2["RDate"]).ToString();
                PTotal_txt.Text = (dr2["TotalAmount"]).ToString();
            }
            OleDbCommand cmd1 = new OleDbCommand(@"Select BasePrice from Products where PModel = '" + PModel_txt.Text + "';", cls.con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                PPrice_txt.Text = (dr1["BasePrice"]).ToString();
            }
            OleDbCommand cmd3 = new OleDbCommand(@"Select SOID from SDN", cls.con);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            int c = 0;
            while (dr3.Read())
            {
                c++;
            }
            GRNID_txt.Text = VName_txt.Text + "-00" + (c + 1).ToString() + System.DateTime.Today.Year;
            cls.con.Close();
            
        }
        #endregion
        #region "create_Btn Functions"
        public override void create_Btn_Click(object sender, EventArgs e)
        {
            if (!(POID_comBox.Text == "" && POID_comBox.Text == "Choose Product ID"))
            {
                cls.con.Open();
                OleDbCommand cmd1 = new OleDbCommand("insert into SDN(SDNID,BaseDocument,Status,CName,RDate,SDDate, TotalAmount)values(@SDNID,@BaseDocument,@Status,@CName,@RDate,@SDDate, @TotalAmount);", cls.con);
                cmd1.Parameters.AddWithValue("@SDNID", GRNID_txt.Text);
                cmd1.Parameters.AddWithValue("@BaseDocument", Vendor_txt.Text);
                cmd1.Parameters.AddWithValue("@Status", "open");
                cmd1.Parameters.AddWithValue("@CName", VName_txt.Text);
                cmd1.Parameters.AddWithValue("@RDate", DDate_txt.Text);
                cmd1.Parameters.AddWithValue("@SDDate", GDate.Text);
                cmd1.Parameters.AddWithValue("@TotalAmount", PTotal_txt.Text);
                cmd1.ExecuteNonQuery();
                OleDbCommand cmd2 = new OleDbCommand(@"insert into SDNProducts(SDNID, PModel, PQty)values(@SDNID, @PModel, @PQty)", cls.con);
                cmd2.Parameters.AddWithValue("@SDNID", GRNID_txt.Text);
                cmd2.Parameters.AddWithValue("@PModel", PModel_txt.Text);
                cmd2.Parameters.AddWithValue("@PQty", PQuantity_txt.Text);
                cmd2.ExecuteNonQuery();
                OleDbCommand cmd3 = new OleDbCommand(@"Update SO set Status = 'Close'", cls.con);
                cmd3.ExecuteNonQuery();
                cls.con.Close();
                MessageBox.Show("SDN has been created successfully!");
                POID_comBox.Text = "Choose Sales Order ID";
                PModel_txt.Clear();
                PQuantity_txt.Clear();
                PPrice_txt.Clear();
                PTotal_txt.Clear();
                Vendor_txt.Clear();
                VName_txt.Clear();
                DDate_txt.Clear();
                GRNID_txt.Clear();
            }
            else
                MessageBox.Show("Please select Sales Order ID!");
        }
        #endregion
    }
}
