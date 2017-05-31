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
    public class GRN
    {
        #region "Initialize-Classes & Forms"
        public Connection cls = new Connection();
        #endregion
        #region "Declaration & Initialization"
        //Everything in CustomerData will be initialized here.
        #region "Panels"
        public Panel GRN_Pnl = new Panel();
        #endregion
        #region "Labels"
        //Product Details -->
        public Label POID_lbl = new Label();
        public Label PModel_lbl = new Label();
        public Label PPrice_lbl = new Label();
        public Label PQuantity_lbl = new Label();
        public Label PTotal_lbl = new Label();
        //Product Details <--
        //Vendor -->
        public Label Vendor_lbl = new Label();
        public Label VName_lbl = new Label();
        public Label DDate_lbl = new Label();
        //Vendor <--
        //GRN Details -->
        public Label GRNID_lbl = new Label();
        public Label GDate_lbl = new Label();
        //GRN Details <--
        #endregion
        #region "TextBoxes"
        //Product Details -->
        public TextBox PModel_txt = new TextBox();
        public TextBox PPrice_txt = new TextBox();
        public TextBox PQuantity_txt = new TextBox();
        public TextBox PTotal_txt = new TextBox();
        //Product Details <--
        //Vendor Details -->
        public TextBox Vendor_txt = new TextBox();
        public TextBox VName_txt = new TextBox();
        public TextBox DDate_txt = new TextBox();
        //Vendor Details <--
        //GRN Details -->
        public TextBox GRNID_txt = new TextBox();
        //GRN Details <--
        #endregion
        #region "ComboBoxes"
        public ComboBox POID_comBox = new ComboBox();
        #endregion
        #region "Buttons"
        public Button create_Btn = new Button();
        #endregion
        #region "GroupBoxes"
        public GroupBox GRN_grp = new GroupBox();
        #endregion
        #region "DateTimePiker"
        DateTimePicker GDate = new DateTimePicker();
        #endregion
        #endregion
        public void GRNData() {
            cls.conString();
            #region "GRN_Pnl"
            GRN_Pnl.Dock = DockStyle.Fill;
            GRN_Pnl.BackColor = Color.MintCream;
            GRN_Pnl.Visible = false;
            #endregion
            #region "GroupBox"
            GRN_grp.Size = new Size(700, 650);
            GRN_grp.Location = new Point(295, 60);
            GRN_grp.Text = "GRN Data Form";
            GRN_grp.ForeColor = Color.DarkGray;
            GRN_grp.Font = new Font("Arial", 12, FontStyle.Bold);
            GRN_grp.FlatStyle = FlatStyle.Flat;
            GRN_grp.Paint += GRN_grp_Paint;
            GRN_Pnl.Controls.Add(GRN_grp);
            #endregion
            #region "POID_lbl"
            POID_lbl.Size = new Size(195, 20);
            POID_lbl.Location = new Point((GRN_grp.Width / 3) - POID_lbl.Size.Width / 2, 105);
            POID_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            POID_lbl.Text = "Product ID:";
            POID_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(POID_lbl);
            #endregion
            #region "POID_comBox"
            POID_comBox.Size = new Size(200, 20);
            POID_comBox.Margin = new Padding(0, 0, 0, 0);
            POID_comBox.Location = new Point((GRN_grp.Width / 4) - POID_comBox.Size.Width / 2, 125);
            POID_comBox.Font = new Font("Arial", 9, FontStyle.Regular);
            POID_comBox.Text = "Choose Product ID";
            POID_comBox.ForeColor = Color.Gray;
            POID_comBox.KeyPress += POID_comBox_KeyPress;
            POID_comBox.SelectedIndexChanged += POID_comBox_SelectedIndexChanged;
            GRN_grp.Controls.Add(POID_comBox);
            #endregion
            #region "PModel_lbl"
            PModel_lbl.Size = new Size(105, 20);
            PModel_lbl.Location = new Point((GRN_grp.Width / 4) - PModel_lbl.Size.Width / 2, 155);
            PModel_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PModel_lbl.Text = "Product Model:";
            PModel_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(PModel_lbl);
            #endregion
            #region "PModel_txt"
            PModel_txt.Size = new Size(200, 20);
            PModel_txt.Location = new Point((GRN_grp.Width / 4) - PModel_txt.Size.Width / 2, 175);
            PModel_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PModel_txt.ForeColor = Color.Gray;
            PModel_txt.Enabled = false;
            PModel_txt.BackColor = Color.White;
            GRN_grp.Controls.Add(PModel_txt);
            #endregion
            #region "PPrice_lbl"
            PPrice_lbl.Size = new Size(100, 20);
            PPrice_lbl.Location = new Point((GRN_grp.Width / 4) - PPrice_lbl.Size.Width / 2, 205);
            PPrice_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PPrice_lbl.Text = "Product Price:";
            PPrice_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(PPrice_lbl);
            #endregion
            #region "PPrice_txt"
            PPrice_txt.Size = new Size(200, 20);
            PPrice_txt.Location = new Point((GRN_grp.Width / 4) - PPrice_txt.Size.Width / 2, 225);
            PPrice_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PPrice_txt.ForeColor = Color.Gray;
            PPrice_txt.Enabled = false;
            PPrice_txt.BackColor = Color.White;
            GRN_grp.Controls.Add(PPrice_txt);
            #endregion
            #region "PQuantity_lbl"
            PQuantity_lbl.Size = new Size(120, 20);
            PQuantity_lbl.Location = new Point((GRN_grp.Width / 4) - PQuantity_lbl.Size.Width / 2, 255);
            PQuantity_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PQuantity_lbl.Text = "Product Quantity:";
            PQuantity_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(PQuantity_lbl);
            #endregion
            #region "PQuantity_txt"
            PQuantity_txt.Size = new Size(200, 20);
            PQuantity_txt.Location = new Point((GRN_grp.Width / 4) - PQuantity_txt.Size.Width / 2, 275);
            PQuantity_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PQuantity_txt.ForeColor = Color.Gray;
            PQuantity_txt.BackColor = Color.White;
            PQuantity_txt.Enabled = false;
            GRN_grp.Controls.Add(PQuantity_txt);
            #endregion
            #region "PTotal_lbl"
            PTotal_lbl.Size = new Size(80, 20);
            PTotal_lbl.Location = new Point((GRN_grp.Width / 4) - PTotal_lbl.Size.Width / 2, 305);
            PTotal_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PTotal_lbl.Text = "Total Price:";
            PTotal_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(PTotal_lbl);
            #endregion
            #region "PTotal_txt"
            PTotal_txt.Size = new Size(200, 20);
            PTotal_txt.Location = new Point((GRN_grp.Width / 4) - PTotal_txt.Size.Width / 2, 325);
            PTotal_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PTotal_txt.ForeColor = Color.Gray;
            PTotal_txt.Enabled = false;
            PTotal_txt.BackColor = Color.White;
            GRN_grp.Controls.Add(PTotal_txt);
            #endregion
            #region "Vendor_lbl"
            Vendor_lbl.Size = new Size(75, 20);
            Vendor_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - Vendor_lbl.Size.Width / 2, 105);
            Vendor_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            Vendor_lbl.Text = "Vendor ID:";
            Vendor_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(Vendor_lbl);
            #endregion
            #region "Vendor_txt"
            Vendor_txt.Size = new Size(200, 20);
            Vendor_txt.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - Vendor_txt.Size.Width / 2, 125);
            Vendor_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            Vendor_txt.ForeColor = Color.Gray;
            Vendor_txt.BackColor = Color.White;
            Vendor_txt.Enabled = false;
            GRN_grp.Controls.Add(Vendor_txt);
            #endregion
            #region "DDate_lbl"
            DDate_lbl.Size = new Size(90, 20);
            DDate_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - DDate_lbl.Size.Width / 2, 305);
            DDate_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            DDate_lbl.Text = "Deliver Date:";
            DDate_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(DDate_lbl);
            #endregion
            #region "DDate_txt"
            DDate_txt.Size = new Size(190, 20);
            DDate_txt.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - DDate_txt.Size.Width / 2, 325);
            DDate_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            DDate_txt.ForeColor = Color.Gray;
            DDate_txt.Enabled = false;
            DDate_txt.BackColor = Color.White;
            GRN_grp.Controls.Add(DDate_txt);
            #endregion
            #region "GRNID_lbl"
            GRNID_lbl.Size = new Size(60, 20);
            GRNID_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - GRNID_lbl.Size.Width / 2, 205);
            GRNID_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            GRNID_lbl.Text = "GRN ID:";
            GRNID_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(GRNID_lbl);
            #endregion
            #region "GRNID_txt"
            GRNID_txt.Size = new Size(200, 20);
            GRNID_txt.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - GRNID_txt.Size.Width / 2, 225);
            GRNID_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            GRNID_txt.ForeColor = Color.Gray;
            GRNID_txt.Enabled = false;
            GRNID_txt.BackColor = Color.White;
            GRN_grp.Controls.Add(GRNID_txt);
            #endregion
            #region "GDate_lbl"
            GDate_lbl.Size = new Size(80, 20);
            GDate_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - GDate_lbl.Size.Width / 2, 255);
            GDate_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            GDate_lbl.Text = "GRN Date:";
            GDate_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(GDate_lbl);
            #endregion
            #region "GDate"
            GDate.Size = new Size(200, 20);
            GDate.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - GDate.Size.Width / 2, 275);
            GDate.Font = new Font("Arial", 10, FontStyle.Regular);
            GDate.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(GDate);
            #endregion
            #region "VName_lbl"
            VName_lbl.Size = new Size(100, 20);
            VName_lbl.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - VName_lbl.Size.Width / 2, 155);
            VName_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            VName_lbl.Text = "Vendor Name:";
            VName_lbl.ForeColor = Color.Gray;
            GRN_grp.Controls.Add(VName_lbl);
            #endregion
            #region "VName_txt"
            VName_txt.Size = new Size(200, 20);
            VName_txt.Location = new Point((((GRN_grp.Width / 2) + (GRN_grp.Width / 4))) - VName_txt.Size.Width / 2, 175);
            VName_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            VName_txt.ForeColor = Color.Gray;
            VName_txt.BackColor = Color.White;
            VName_txt.Enabled = false;
            GRN_grp.Controls.Add(VName_txt);
            #endregion
            #region "create_Btn"
            create_Btn.Size = new Size(300, 40);
            create_Btn.Location = new Point(GRN_grp.Size.Width / 2 - create_Btn.Size.Width / 2, 400);
            create_Btn.Font = new Font("", 10, FontStyle.Regular);
            create_Btn.ForeColor = Color.White;
            create_Btn.BackColor = Color.DeepSkyBlue;
            create_Btn.FlatStyle = FlatStyle.Flat;
            create_Btn.FlatAppearance.BorderSize = 0;
            create_Btn.Text = "Create GRN";
            create_Btn.Click += create_Btn_Click;
            create_Btn.MouseHover += create_Btn_MouseHover;
            GRN_grp.Controls.Add(create_Btn);
            #endregion
        }

        #region "POID"
        void POID_comBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void POID_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select * from POProducts WHERE POID = '" + POID_comBox.Text + "';", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PModel_txt.Text = (dr["PModel"]).ToString();
                PQuantity_txt.Text = (dr["PQty"]).ToString();
            }
            OleDbCommand cmd2 = new OleDbCommand(@"Select * from PO where POID = '" + POID_comBox.Text + "';", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                Vendor_txt.Text = (dr2["VID"]).ToString();
                VName_txt.Text = (dr2["VName"]).ToString();
                DDate_txt.Text = (dr2["DDate"]).ToString();
                PTotal_txt.Text = (dr2["TotalAmount"]).ToString();
            }
            OleDbCommand cmd1 = new OleDbCommand(@"Select BasePrice from Products where PModel = '"+PModel_txt.Text+"';", cls.con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read()) {
                PPrice_txt.Text = (dr1["BasePrice"]).ToString();
            }
            OleDbCommand cmd3 = new OleDbCommand(@"Select GRNID from GRN", cls.con);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            int c = 0;
            while (dr3.Read())
            {
                c++;
            }
            cls.con.Close();
            GRNID_txt.Text = VName_txt.Text+"-00" + (c + 1).ToString() + System.DateTime.Today.Year;
            
        }
        #endregion
        #region "create_Btn Functions"
        private void create_Btn_MouseHover(object sender, EventArgs e)
        {
            create_Btn.Cursor = Cursors.Hand;
        }

        private void create_Btn_Click(object sender, EventArgs e)
        {
            if (!(POID_comBox.Text == "" && POID_comBox.Text=="Choose Product ID"))
            {
                cls.con.Open();
                OleDbCommand cmd1 = new OleDbCommand("insert into GRN(GRNID,BaseDocument,Status,VName,DDate,GRDate, TotalAmount)values(@GRNID,@BaseDocument,@Status,@VName,@DDate,@GRDate, @TotalAmount);", cls.con);
                cmd1.Parameters.AddWithValue("@GRNID", GRNID_txt.Text);
                cmd1.Parameters.AddWithValue("@BaseDocument", Vendor_txt.Text);
                cmd1.Parameters.AddWithValue("@Status", "open");
                cmd1.Parameters.AddWithValue("@VName", VName_txt.Text);
                cmd1.Parameters.AddWithValue("@DDate", DDate_txt.Text);
                cmd1.Parameters.AddWithValue("@GRDate", GDate.Text);
                cmd1.Parameters.AddWithValue("@TotalAmount", PTotal_txt.Text);
                cmd1.ExecuteNonQuery();
                OleDbCommand cmd2 = new OleDbCommand(@"insert into GRNProducts(GRNID, PModel, PQty)values(@GRNID, @PModel, @PQty)", cls.con);
                cmd2.Parameters.AddWithValue("@GRNID", GRNID_txt.Text);
                cmd2.Parameters.AddWithValue("@PModel", PModel_txt.Text);
                cmd2.Parameters.AddWithValue("@PQty", PQuantity_txt.Text);
                cmd2.ExecuteNonQuery();
                OleDbCommand cmd3 = new OleDbCommand(@"Update PO set Status = 'Close'", cls.con);
                cmd3.ExecuteNonQuery();
                cls.con.Close();
                MessageBox.Show("GRN has been created successfully!");
                POID_comBox.Text = "Choose Product ID";
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
                MessageBox.Show("Please select Product ID!");
        }
        #endregion
        #region "GRN_grp_Paint"
        private void GRN_grp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = GRN_grp.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            p.Width = 1;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, (GRN_grp.Width / 3) - (445 / 2), 95, 325, 265);
            g.DrawRectangle(p, ((GRN_grp.Width / 2) + (GRN_grp.Width / 4)) - (325 / 2), 95, 325, 265);
        }
        #endregion
    }
}
