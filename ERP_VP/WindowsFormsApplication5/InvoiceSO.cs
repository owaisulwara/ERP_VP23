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
    public class InvoiceSO:Invoice
    {
        public void invoiceSO() {
            invoiceData();
            GRNID_lbl.Text = "SDN ID:";
            GRNID_comBox.Text = "Choose SDN ID";
            PayableAmount_lbl.Text = "Receiveable Amount:";
            PayableAmount_lbl.Size = new Size(160, 20);
            PayableAmount_lbl.Location = new Point((Invoice_grp.Width / 4) - PayableAmount_lbl.Size.Width / 2, 155);
            Deliver_lbl.Text = "Receive Date:";
            GRNDate_lbl.Text = "SDN Date:";
            VID_lbl.Text = "Customer ID:";
            VID_lbl.Size = new Size(90, 20);
            VID_lbl.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - VID_lbl.Size.Width / 2, 105);
            VName_lbl.Text = "Customer Name:";
            VName_lbl.Size = new Size(115, 20);
            VName_lbl.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - VName_lbl.Size.Width / 2, 155);
            
        }
        #region "GRNID"
        public override void GRNID_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select * from SDN where SDNID = '" + GRNID_comBox.Text + "'", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                VID_txt.Text = (dr["BaseDocument"]).ToString();
                VName_txt.Text = (dr["CName"]).ToString();
                Deliver_txt.Text = (dr["RDate"]).ToString();
                GRNDate_txt.Text = (dr["SDDate"]).ToString();
                PayableAmount_txt.Text = (dr["TotalAmount"]).ToString();
            }
            OleDbCommand cmd1 = new OleDbCommand(@"Select * from SDNProducts where SDNID = '" + GRNID_comBox.Text + "'", cls.con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                PModel_txt.Text = (dr1["PModel"]).ToString();
                PQuantity_txt.Text = (dr1["PQty"]).ToString();
            }
            cls.con.Close();
        }
        #endregion
        #region "Create_Btn Functions"
        public override void create_Btn_Click(object sender, EventArgs e)
        {
            if (!(GRNID_comBox.Text == "" && GRNID_comBox.Text == "Choose SDN ID"))
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand(@"insert into InvoiceSO(SDNID, RDate, SDDate, CID, CName, PModel, PQuantity, AmountReceiveable)values(@SDNID, @CDate, @GRDate, @CID, @CName, @PModel, @PQuantity, @AmountReceiveable)", cls.con);
                cmd.Parameters.AddWithValue("@SDNID", GRNID_comBox.Text);
                cmd.Parameters.AddWithValue("@CDate", Deliver_txt.Text);
                cmd.Parameters.AddWithValue("@SDDate", GRNDate_txt.Text);
                cmd.Parameters.AddWithValue("@CID", VID_txt.Text);
                cmd.Parameters.AddWithValue("@CName", VName_txt.Text);
                cmd.Parameters.AddWithValue("@PModel", PModel_txt.Text);
                cmd.Parameters.AddWithValue("@PQuantity", PQuantity_txt.Text);
                cmd.Parameters.AddWithValue("@AmountReceiveable", PayableAmount_txt.Text);
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand(@"update SDN set Status = 'Close'", cls.con);
                cmd1.ExecuteNonQuery();
                cls.con.Close();
                MessageBox.Show("Invoice has been created successfully.");
            }
        }
        #endregion
    }
}
