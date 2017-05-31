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
    public class Invoice
    {

        #region "Initialize-Classes & Forms"
        public Connection cls = new Connection();
        #endregion
        #region "Declaration & Initialization"
        //Everything in CustomerData will be initialized here.
        #region "Panels"
        public Panel Invoice_Pnl = new Panel();
        #endregion
        #region "Labels"
        //Vendor Details -->
        public Label VID_lbl = new Label();
        public Label VName_lbl = new Label();
        public Label PQuantity_lbl = new Label();
        //Vendor Details <--
        //GRN Details -->
        public Label GRNID_lbl = new Label();
        public Label PayableAmount_lbl = new Label();
        public Label Deliver_lbl = new Label();
        public Label GRNDate_lbl = new Label();
        public Label PModel_lbl = new Label();
        //GRN Details <--
        #endregion
        #region "TextBoxes"
        //Vendor Details -->
        public TextBox VID_txt = new TextBox();
        public TextBox VName_txt = new TextBox();
        public TextBox PQuantity_txt = new TextBox();
        //Vendor Details <--
        //GRN Details -->
        public TextBox PayableAmount_txt = new TextBox();
        public TextBox Deliver_txt = new TextBox();
        public TextBox GRNDate_txt = new TextBox();
        public TextBox PModel_txt = new TextBox();
        //GRN Details <--
        #endregion
        #region "ComboBoxes"
        public ComboBox GRNID_comBox = new ComboBox();
        #endregion
        #region "Buttons"
        public Button create_Btn = new Button();
        #endregion
        #region "GroupBoxes"
        public GroupBox Invoice_grp = new GroupBox();
        #endregion
        #endregion
        public void invoiceData() {
            cls.conString();
            #region "Invoice_Pnl"
            Invoice_Pnl.Dock = DockStyle.Fill;
            Invoice_Pnl.BackColor = Color.MintCream;
            Invoice_Pnl.Visible = false;
            #endregion
            #region "GroupBox"
            Invoice_grp.Size = new Size(700, 650);
            Invoice_grp.Location = new Point(295, 60);
            Invoice_grp.Text = "GRN Data Form";
            Invoice_grp.ForeColor = Color.DarkGray;
            Invoice_grp.Font = new Font("Arial", 12, FontStyle.Bold);
            Invoice_grp.FlatStyle = FlatStyle.Flat;
            Invoice_grp.Paint += Invoice_grp_Paint;
            Invoice_Pnl.Controls.Add(Invoice_grp);
            #endregion
            #region "create_Btn"
            create_Btn.Size = new Size(300, 40);
            create_Btn.Location = new Point(Invoice_grp.Size.Width / 2 - create_Btn.Size.Width / 2, 400);
            create_Btn.Font = new Font("", 10, FontStyle.Regular);
            create_Btn.ForeColor = Color.White;
            create_Btn.BackColor = Color.DeepSkyBlue;
            create_Btn.FlatStyle = FlatStyle.Flat;
            create_Btn.FlatAppearance.BorderSize = 0;
            create_Btn.Text = "Create Invoice";
            create_Btn.Click += create_Btn_Click;
            create_Btn.MouseHover += create_Btn_MouseHover;
            Invoice_grp.Controls.Add(create_Btn);
            #endregion
            #region "GRNID_lbl"
            GRNID_lbl.Size = new Size(195, 20);
            GRNID_lbl.Location = new Point((Invoice_grp.Width / 3) - GRNID_lbl.Size.Width / 2, 105);
            GRNID_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            GRNID_lbl.Text = "GRN ID:";
            GRNID_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(GRNID_lbl);
            #endregion
            #region "GRNID_comBox"
            GRNID_comBox.Size = new Size(200, 20);
            GRNID_comBox.Margin = new Padding(0, 0, 0, 0);
            GRNID_comBox.Location = new Point((Invoice_grp.Width / 4) - GRNID_comBox.Size.Width / 2, 125);
            GRNID_comBox.Font = new Font("Arial", 9, FontStyle.Regular);
            GRNID_comBox.Text = "Choose GRN ID";
            GRNID_comBox.ForeColor = Color.Gray;
            GRNID_comBox.SelectedIndexChanged += GRNID_comBox_SelectedIndexChanged;
            Invoice_grp.Controls.Add(GRNID_comBox);
            #endregion
            #region "PayableAmount_lbl"
            PayableAmount_lbl.Size = new Size(120, 20);
            PayableAmount_lbl.Location = new Point((Invoice_grp.Width / 4) - PayableAmount_lbl.Size.Width / 2, 155);
            PayableAmount_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PayableAmount_lbl.Text = "Payable Amount:";
            PayableAmount_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(PayableAmount_lbl);
            #endregion
            #region "PayableAmount_txt"
            PayableAmount_txt.Size = new Size(200, 20);
            PayableAmount_txt.Location = new Point((Invoice_grp.Width / 4) - PayableAmount_txt.Size.Width / 2, 175);
            PayableAmount_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PayableAmount_txt.ForeColor = Color.Gray;
            PayableAmount_txt.Enabled = false;
            PayableAmount_txt.BackColor = Color.White;
            Invoice_grp.Controls.Add(PayableAmount_txt);
            #endregion
            #region "Deliver_lbl"
            Deliver_lbl.Size = new Size(100, 20);
            Deliver_lbl.Location = new Point((Invoice_grp.Width / 4) - Deliver_lbl.Size.Width / 2, 205);
            Deliver_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            Deliver_lbl.Text = "Deliver Date:";
            Deliver_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(Deliver_lbl);
            #endregion
            #region "Deliver_txt"
            Deliver_txt.Size = new Size(200, 20);
            Deliver_txt.Location = new Point((Invoice_grp.Width / 4) - Deliver_txt.Size.Width / 2, 225);
            Deliver_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            Deliver_txt.ForeColor = Color.Gray;
            Deliver_txt.Enabled = false;
            Deliver_txt.BackColor = Color.White;
            Invoice_grp.Controls.Add(Deliver_txt);
            #endregion
            #region "GRNDate_lbl"
            GRNDate_lbl.Size = new Size(80, 20);
            GRNDate_lbl.Location = new Point((Invoice_grp.Width / 4) - GRNDate_lbl.Size.Width / 2, 255);
            GRNDate_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            GRNDate_lbl.Text = "GRN Date:";
            GRNDate_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(GRNDate_lbl);
            #endregion
            #region "GRNDate_txt"
            GRNDate_txt.Size = new Size(200, 20);
            GRNDate_txt.Location = new Point((Invoice_grp.Width / 4) - GRNDate_txt.Size.Width / 2, 275);
            GRNDate_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            GRNDate_txt.ForeColor = Color.Gray;
            GRNDate_txt.BackColor = Color.White;
            GRNDate_txt.Enabled = false;
            Invoice_grp.Controls.Add(GRNDate_txt);
            #endregion
            #region "VID_lbl"
            VID_lbl.Size = new Size(75, 20);
            VID_lbl.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - VID_lbl.Size.Width / 2, 105);
            VID_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            VID_lbl.Text = "Vendor ID:";
            VID_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(VID_lbl);
            #endregion
            #region "VID_txt"
            VID_txt.Size = new Size(200, 20);
            VID_txt.Margin = new Padding(0, 0, 0, 0);
            VID_txt.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - VID_txt.Size.Width / 2, 125);
            VID_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            VID_txt.Enabled = false;
            VID_txt.ForeColor = Color.Gray;
            VID_txt.BackColor = Color.White;
            Invoice_grp.Controls.Add(VID_txt);
            #endregion
            #region "VName_lbl"
            VName_lbl.Size = new Size(100, 20);
            VName_lbl.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - VName_lbl.Size.Width / 2, 155);
            VName_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            VName_lbl.Text = "Vendor Name:";
            VName_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(VName_lbl);
            #endregion
            #region "VName_txt"
            VName_txt.Size = new Size(200, 20);
            VName_txt.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - VName_txt.Size.Width / 2, 175);
            VName_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            VName_txt.ForeColor = Color.Gray;
            VName_txt.Enabled = false;
            VName_txt.BackColor = Color.White;
            Invoice_grp.Controls.Add(VName_txt);
            #endregion
            #region "PModel_lbl"
            PModel_lbl.Size = new Size(105, 20);
            PModel_lbl.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - PModel_lbl.Size.Width / 2, 205);
            PModel_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PModel_lbl.Text = "Product Model:";
            PModel_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(PModel_lbl);
            #endregion
            #region "PModel_txt"
            PModel_txt.Size = new Size(200, 20);
            PModel_txt.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - PModel_txt.Size.Width / 2, 225);
            PModel_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PModel_txt.ForeColor = Color.Gray;
            PModel_txt.Enabled = false;
            PModel_txt.BackColor = Color.White;
            Invoice_grp.Controls.Add(PModel_txt);
            #endregion
            #region "PQuantity_lbl"
            PQuantity_lbl.Size = new Size(120, 20);
            PQuantity_lbl.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - PQuantity_lbl.Size.Width / 2, 255);
            PQuantity_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PQuantity_lbl.Text = "Product Quantity:";
            PQuantity_lbl.ForeColor = Color.Gray;
            Invoice_grp.Controls.Add(PQuantity_lbl);
            #endregion
            #region "PQuantity_txt"
            PQuantity_txt.Size = new Size(200, 20);
            PQuantity_txt.Location = new Point((((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4))) - PQuantity_txt.Size.Width / 2, 275);
            PQuantity_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PQuantity_txt.ForeColor = Color.Gray;
            PQuantity_txt.BackColor = Color.White;
            PQuantity_txt.Enabled = false;
            Invoice_grp.Controls.Add(PQuantity_txt);
            #endregion
        }
        #region "GRNID"
        public virtual void GRNID_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select * from GRN where GRNID = '"+GRNID_comBox.Text+"'", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read()){
                VID_txt.Text = (dr["BaseDocument"]).ToString();
                VName_txt.Text = (dr["VName"]).ToString();
                Deliver_txt.Text = (dr["DDate"]).ToString();
                GRNDate_txt.Text = (dr["GRDate"]).ToString();
                PayableAmount_txt.Text = (dr["TotalAmount"]).ToString();
            }
            OleDbCommand cmd1 = new OleDbCommand(@"Select * from GRNProducts where GRNID = '" + GRNID_comBox.Text + "'", cls.con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read()) {
                PModel_txt.Text = (dr1["PModel"]).ToString();
                PQuantity_txt.Text = (dr1["PQty"]).ToString();
            }
            cls.con.Close();
        }
        #endregion
        #region "Create_Btn Functions"
        private void create_Btn_MouseHover(object sender, EventArgs e)
        {
            create_Btn.Cursor = Cursors.Hand;
        }

        public virtual void create_Btn_Click(object sender, EventArgs e)
        {
            if(!(GRNID_comBox.Text=="" && GRNID_comBox.Text=="Choose GRN ID")){
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"insert into invoice(GRNID, DDate, GRDate, VID, VName, PModel, PQuantity, AmountPayable)values(@GRNID, @DDate, @GRDate, @VID, @VName, @PModel, @PQuantity, @AmountPayable)", cls.con);
            cmd.Parameters.AddWithValue("@GRNID", GRNID_comBox.Text);
            cmd.Parameters.AddWithValue("@DDate", Deliver_txt.Text);
            cmd.Parameters.AddWithValue("@GRDate", GRNDate_txt.Text);
            cmd.Parameters.AddWithValue("@VID", VID_txt.Text);
            cmd.Parameters.AddWithValue("@VName", VName_txt.Text);
            cmd.Parameters.AddWithValue("@PModel", PModel_txt.Text);
            cmd.Parameters.AddWithValue("@PQuantity", PQuantity_txt.Text);
            cmd.Parameters.AddWithValue("@AmountPayable", PayableAmount_txt.Text);
            cmd.ExecuteNonQuery();
            OleDbCommand cmd1 = new OleDbCommand(@"update GRN set Status = 'Close'", cls.con);
            cmd1.ExecuteNonQuery();
            cls.con.Close();
            MessageBox.Show("Invoice has been created successfully.");
            }
        }
        #endregion
        #region "Invoice_Paint"
        private void Invoice_grp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Invoice_grp.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            p.Width = 1;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, (Invoice_grp.Width / 3) - (445 / 2), 95, 325, 220);
            g.DrawRectangle(p, ((Invoice_grp.Width / 2) + (Invoice_grp.Width / 4)) - (325 / 2), 95, 325, 220);
        }
        #endregion
    }
}
