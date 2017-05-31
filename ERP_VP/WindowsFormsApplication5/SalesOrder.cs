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
    public class SalesOrder:PurchaseOrder
    {
        public void salesOrder() {
            purchaseOrder();
            PO_grp.Text = "Sales Order";
            PODpt_lbl.Text = "Sales Order Department:";
            PODpt_lbl.Size = new Size(170,20);
            PODpt_lbl.Location = new Point(PO_grp.Width / 2 - PODpt_lbl.Size.Width / 2, 45);
            POID_lbl.Text = "Sales Order ID:";
            POID_lbl.Size = new Size(110, 20);
            POID_lbl.Location = new Point(PO_grp.Width / 2 - POID_lbl.Size.Width / 2, 95);
            VID_lbl.Text = "Customer ID:";
            VID_lbl.Size = new Size(90, 20);
            VName_lbl.Text = "Customer Name:";
            VName_lbl.Size = new Size(115, 20);
            Vdpt_lbl.Text = "Customer Department:";
            Vdpt_lbl.Size = new Size(190, 20);
        }

        public override void Create_btn_Click(object sender, System.EventArgs e)
        {
            if (!(PODpt_comBox.Text == "" && PODpt_comBox.Text == "Choose Department" && POID_txt.Text == "" && VID_comBox.Text == "" && VID_comBox.Text == "Choose Vendor ID" && VName_txt.Text == "" && Vdpt_txt.Text == "" && CPName_txt.Text == "" && CPPH_txt.Text == "" && Final_txt.Text == ""))
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into SO(SOID, RDate, CID, CName, CDpt, CPerson, CPPH, TotalAmount, Status)values(@SOID, @RDate, @CID, @CName, @CDpt, @CPerson, @CPPH, @TotalAmount, 'Open')", cls.con);
                cmd.Parameters.AddWithValue("@SOID", POID_txt.Text);
                cmd.Parameters.AddWithValue("@RDate", DTP.Text);
                cmd.Parameters.AddWithValue("@CID", VID_comBox.Text);
                cmd.Parameters.AddWithValue("@CName", VName_txt.Text);
                cmd.Parameters.AddWithValue("@CDpt", Vdpt_txt.Text);
                cmd.Parameters.AddWithValue("@CPerson", CPName_txt.Text);
                cmd.Parameters.AddWithValue("@CPPH", CPPH_txt.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", (Convert.ToInt32(PPrice_txt.Text) * Convert.ToInt32(PQuantity_txt.Text)).ToString());
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand(@"insert into SOProducts(SOID, PModel, PQty)values(@SOID, @PModel, @PQty)", cls.con);
                cmd1.Parameters.AddWithValue("@SOID", POID_txt.Text);
                cmd1.Parameters.AddWithValue("@PModel", PModel_comBox.Text);
                cmd1.Parameters.AddWithValue("@PQty", PQuantity_txt.Text);
                cmd1.ExecuteNonQuery();
                cls.con.Close();
                MessageBox.Show("Sales Order has been created.");
                PODpt_comBox.Text = "Choose Department";
                VID_comBox.Text = "Choose Sales ID";
                PModel_comBox.Text = "Choose Product Model";
                POID_txt.Clear();
                VName_txt.Clear();
                Vdpt_txt.Clear();
                CPName_txt.Clear();
                CPPH_txt.Clear();
                PName_txt.Clear();
                PPrice_txt.Clear();
                PQuantity_txt.Clear();
                Final_txt.Clear();

            }
            else
                MessageBox.Show("Please insert all the data.");
        }
    }
}
