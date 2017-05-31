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
    public class PurchaseOrder
    {
        #region "Initialize-Classes & Forms"
        public Connection cls = new Connection();
        #endregion
        #region "Panels"
        public Panel PO_Pnl = new Panel();
        #endregion
        #region "GroupBoxes"
        public GroupBox PO_grp = new GroupBox();
        #endregion
        #region "Labels"
        public Label POID_lbl = new Label();
        public Label Deliver_lbl = new Label();
        public Label VID_lbl = new Label();
        public Label Vdpt_lbl = new Label();
        public Label VName_lbl = new Label();
        public Label CPName_lbl = new Label();
        public Label CPPH_lbl = new Label();
        public Label PODpt_lbl = new Label();
        public Label PModel_lbl = new Label();
        public Label PName_lbl = new Label();
        public Label PPrice_lbl = new Label();
        public Label PQuantity_lbl = new Label();
        #endregion
        #region "TextBoxes"
        // PurchaseOrder Textboxes -->
        public TextBox POID_txt = new TextBox();
        // PurchaseOrder Textboxes <--
        // VendorData TextBoxes -->
        public TextBox VName_txt = new TextBox();
        public TextBox Vdpt_txt = new TextBox();
        public TextBox CPName_txt = new TextBox();
        public TextBox CPPH_txt = new TextBox();
        // VendorData TextBoxes <--
        //ProductData TextBoxes -->
        public TextBox PName_txt = new TextBox();
        public TextBox PPrice_txt = new TextBox();
        public TextBox PQuantity_txt = new TextBox();
        //ProductData TextBoxes <--
        //FinalData TextBoxes -->
        public TextBox Final_txt = new TextBox();
        //FinalData TextBoxes <--
        #endregion
        #region "ComboBoxes"
        public ComboBox PODpt_comBox = new ComboBox();
        public ComboBox VID_comBox = new ComboBox();
        public ComboBox PModel_comBox = new ComboBox();
        #endregion
        #region "Buttons"
        public Button addData_btn = new Button();
        public Button Create_btn = new Button();
        #endregion
        #region "DateTimePicker"
        public DateTimePicker DTP = new DateTimePicker();
        #endregion
        public void purchaseOrder() {
            cls.conString();
            #region "PO_Pnl"
            PO_Pnl.Dock = DockStyle.Fill;
            PO_Pnl.BackColor = Color.MintCream;
            PO_Pnl.Visible = false;
            #endregion
            #region "PO_grp"
            PO_grp.Size = new Size(700, 650);
            PO_grp.Location = new Point(295, 50);
            PO_grp.Text = "Purchase Order Form";
            PO_grp.ForeColor = Color.DarkGray;
            PO_grp.Font = new Font("Arial", 12, FontStyle.Bold);
            PO_grp.FlatStyle = FlatStyle.Flat;
            PO_grp.Paint += PO_grp_Paint;
            PO_Pnl.Controls.Add(PO_grp);
            #endregion
            #region "PODpt_lbl"
            PODpt_lbl.Size = new Size(195, 20);
            PODpt_lbl.Location = new Point(PO_grp.Width/2 - PODpt_lbl.Size.Width/2, 45);
            PODpt_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PODpt_lbl.Text = "Purchase Order Department:";
            PODpt_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(PODpt_lbl);
            #endregion
            #region "PODpt_comBox"
            PODpt_comBox.Size = new Size(300, 20);
            PODpt_comBox.Margin = new Padding(0, 0, 0, 0);
            PODpt_comBox.Location = new Point(PO_grp.Width / 2 - PODpt_comBox.Size.Width / 2, 65);
            PODpt_comBox.Font = new Font("Arial", 9, FontStyle.Regular);
            PODpt_comBox.Text = "Choose Department";
            PODpt_comBox.ForeColor = Color.Gray;
            PODpt_comBox.KeyPress += PODpt_comBox_KeyPress;
            PODpt_comBox.SelectedIndexChanged += PODpt_comBox_SelectedIndexChanged;
            PO_grp.Controls.Add(PODpt_comBox);
            #endregion
            #region "POID_lbl"
            POID_lbl.Size = new Size(130, 20);
            POID_lbl.Location = new Point(PO_grp.Width / 2 - POID_lbl.Size.Width / 2, 95);
            POID_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            POID_lbl.Text = "Purchase Order ID:";
            POID_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(POID_lbl);
            #endregion
            #region "POID_txt"
            POID_txt.Size = new Size(300, 20);
            POID_txt.Location = new Point(PO_grp.Width / 2 - POID_txt.Size.Width / 2, 115);
            POID_txt.Font = new Font("Arial", 10, FontStyle.Regular);
            POID_txt.ForeColor = Color.Gray;
            POID_txt.Enabled = false;
            POID_txt.BackColor = Color.White;
            PO_grp.Controls.Add(POID_txt);
            #endregion
            #region "Deliver_lbl"
            Deliver_lbl.Size = new Size(100, 20);
            Deliver_lbl.Location = new Point(PO_grp.Width / 2 - Deliver_lbl.Size.Width / 2, 145);
            Deliver_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            Deliver_lbl.Text = "Deliver Date:";
            Deliver_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(Deliver_lbl);
            #endregion
            #region "DTP"
            DTP.Size = new Size(300, 20);
            DTP.Location = new Point(PO_grp.Width / 2 - POID_txt.Size.Width / 2, 165);
            DTP.Font = new Font("Arial", 10, FontStyle.Regular);
            DTP.ForeColor = Color.Gray;
            PO_grp.Controls.Add(DTP);
            #endregion
            #region "VID_lbl"
            VID_lbl.Size = new Size(195, 20);
            VID_lbl.Location = new Point((PO_grp.Width / 3) - VID_lbl.Size.Width / 2, 230);
            VID_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            VID_lbl.Text = "Vendor ID:";
            VID_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(VID_lbl);
            #endregion
            #region "VID_comBox"
            VID_comBox.Size = new Size(200, 20);
            VID_comBox.Margin = new Padding(0, 0, 0, 0);
            VID_comBox.Location = new Point((PO_grp.Width / 4) - VID_comBox.Size.Width / 2, 250);
            VID_comBox.Font = new Font("Arial", 9, FontStyle.Regular);
            VID_comBox.Text = "Choose Vendor ID";
            VID_comBox.ForeColor = Color.Gray;
            VID_comBox.KeyPress += VID_comBox_KeyPress;
            VID_comBox.SelectedIndexChanged += VID_comBox_SelectedIndexChanged;
            PO_grp.Controls.Add(VID_comBox);
            #endregion
            #region "VName_lbl"
            VName_lbl.Size = new Size(100, 20);
            VName_lbl.Location = new Point((PO_grp.Width / 4) - VName_lbl.Size.Width / 2, 280);
            VName_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            VName_lbl.Text = "Vendor Name:";
            VName_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(VName_lbl);
            #endregion
            #region "VName_txt"
            VName_txt.Size = new Size(200, 20);
            VName_txt.Location = new Point((PO_grp.Width / 4) - VName_txt.Size.Width / 2, 300);
            VName_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            VName_txt.ForeColor = Color.Gray;
            VName_txt.Enabled = false;
            VName_txt.BackColor = Color.White;
            PO_grp.Controls.Add(VName_txt);
            #endregion
            #region "Vdpt_lbl"
            Vdpt_lbl.Size = new Size(140, 20);
            Vdpt_lbl.Location = new Point((PO_grp.Width / 4) - Vdpt_lbl.Size.Width / 2, 330);
            Vdpt_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            Vdpt_lbl.Text = "Vendor Department:";
            Vdpt_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(Vdpt_lbl);
            #endregion
            #region "Vdpt_txt"
            Vdpt_txt.Size = new Size(200, 20);
            Vdpt_txt.Location = new Point((PO_grp.Width / 4) - Vdpt_txt.Size.Width / 2, 350);
            Vdpt_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            Vdpt_txt.ForeColor = Color.Gray;
            Vdpt_txt.Enabled = false;
            Vdpt_txt.BackColor = Color.White;
            PO_grp.Controls.Add(Vdpt_txt);
            #endregion
            #region "CPName_lbl"
            CPName_lbl.Size = new Size(110, 20);
            CPName_lbl.Location = new Point((PO_grp.Width / 4) - CPName_lbl.Size.Width / 2, 380);
            CPName_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            CPName_lbl.Text = "Contact Person:";
            CPName_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(CPName_lbl);
            #endregion
            #region "CPName_txt"
            CPName_txt.Size = new Size(200, 20);
            CPName_txt.Location = new Point((PO_grp.Width / 4) - CPName_txt.Size.Width / 2, 400);
            CPName_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            CPName_txt.ForeColor = Color.Gray;
            CPName_txt.Enabled = false;
            CPName_txt.BackColor = Color.White;
            PO_grp.Controls.Add(CPName_txt);
            #endregion
            #region "CPPH_lbl"
            CPPH_lbl.Size = new Size(80, 20);
            CPPH_lbl.Location = new Point((PO_grp.Width / 4) - CPPH_lbl.Size.Width / 2, 430);
            CPPH_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            CPPH_lbl.Text = "Phone no:";
            CPPH_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(CPPH_lbl);
            #endregion
            #region "CPPH_txt"
            CPPH_txt.Size = new Size(200, 20);
            CPPH_txt.Location = new Point((PO_grp.Width / 4) - CPPH_txt.Size.Width / 2, 450);
            CPPH_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            CPPH_txt.ForeColor = Color.Gray;
            CPPH_txt.Enabled = false;
            CPPH_txt.BackColor = Color.White;
            PO_grp.Controls.Add(CPPH_txt);
            #endregion
            #region "PModel_lbl"
            PModel_lbl.Size = new Size(110, 20);
            PModel_lbl.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PModel_lbl.Size.Width / 2, 230);
            PModel_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PModel_lbl.Text = "Product Model:";
            PModel_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(PModel_lbl);
            #endregion
            #region "PModel_comBox"
            PModel_comBox.Size = new Size(200, 20);
            PModel_comBox.Margin = new Padding(0, 0, 0, 0);
            PModel_comBox.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PModel_comBox.Size.Width / 2, 250);
            PModel_comBox.Font = new Font("Arial", 9, FontStyle.Regular);
            PModel_comBox.Text = "Choose Product Model";
            PModel_comBox.ForeColor = Color.Gray;
            PModel_comBox.KeyPress += PModel_comBox_KeyPress;
            PModel_comBox.SelectedIndexChanged += PModel_comBox_SelectedIndexChanged;
            PO_grp.Controls.Add(PModel_comBox);
            #endregion
            #region "PName_lbl"
            PName_lbl.Size = new Size(105, 20);
            PName_lbl.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PName_lbl.Size.Width / 2, 280);
            PName_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PName_lbl.Text = "Product Name:";
            PName_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(PName_lbl);
            #endregion
            #region "PName_txt"
            PName_txt.Size = new Size(200, 20);
            PName_txt.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PName_txt.Size.Width / 2, 300);
            PName_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PName_txt.ForeColor = Color.Gray;
            PName_txt.Enabled = false;
            PName_txt.BackColor = Color.White;
            PO_grp.Controls.Add(PName_txt);
            #endregion
            #region "PPrice_lbl"
            PPrice_lbl.Size = new Size(100, 20);
            PPrice_lbl.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PPrice_lbl.Size.Width / 2, 330);
            PPrice_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PPrice_lbl.Text = "Product Price:";
            PPrice_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(PPrice_lbl);
            #endregion
            #region "PPrice_txt"
            PPrice_txt.Size = new Size(200, 20);
            PPrice_txt.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PPrice_txt.Size.Width / 2, 350);
            PPrice_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PPrice_txt.ForeColor = Color.Gray;
            PPrice_txt.Enabled = false;
            PPrice_txt.BackColor = Color.White;
            PO_grp.Controls.Add(PPrice_txt);
            #endregion
            #region "PQuantity_lbl"
            PQuantity_lbl.Size = new Size(120, 20);
            PQuantity_lbl.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PQuantity_lbl.Size.Width / 2, 380);
            PQuantity_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            PQuantity_lbl.Text = "Product Quantity:";
            PQuantity_lbl.ForeColor = Color.Gray;
            PO_grp.Controls.Add(PQuantity_lbl);
            #endregion
            #region "PQuantity_txt"
            PQuantity_txt.Size = new Size(200, 20);
            PQuantity_txt.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - PQuantity_txt.Size.Width / 2, 400);
            PQuantity_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            PQuantity_txt.ForeColor = Color.Gray;
            PO_grp.Controls.Add(PQuantity_txt);
            #endregion
            #region "addData_btn"
            addData_btn.Size = new Size(201, 40);
            addData_btn.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 4))) - addData_btn.Size.Width / 2, 430);
            addData_btn.Font = new Font("Arial", 11, FontStyle.Regular);
            addData_btn.ForeColor = Color.White;
            addData_btn.BackColor = Color.DeepSkyBlue;
            addData_btn.FlatStyle = FlatStyle.Flat;
            addData_btn.Text = "Add Products";
            addData_btn.FlatAppearance.BorderSize = 0;
            addData_btn.MouseHover += addData_btn_MouseHover;
            addData_btn.Click += addData_btn_Click;
            PO_grp.Controls.Add(addData_btn);
            #endregion
            #region "Final_txt"
            Final_txt.Multiline = true;
            Final_txt.Size = new Size(415, 120);
            Final_txt.Location = new Point((PO_grp.Width/3) - (415/2), 505);
            Final_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            Final_txt.ForeColor = Color.Gray;
            Final_txt.Enabled = false;
            PO_grp.Controls.Add(Final_txt);
            #endregion
            #region "Create_btn"
            Create_btn.Size = new Size(130, 130);
            Create_btn.Location = new Point((((PO_grp.Width / 2) + (PO_grp.Width / 3))) - Create_btn.Size.Width / 2, 500);
            Create_btn.Font = new Font("Arial", 12, FontStyle.Bold);
            Create_btn.ForeColor = Color.White;
            Create_btn.BackColor = Color.DeepSkyBlue;
            Create_btn.FlatStyle = FlatStyle.Flat;
            Create_btn.Text = "Create\nPurchase\nOrder";
            Create_btn.FlatAppearance.BorderSize = 0;
            Create_btn.MouseHover += Create_btn_MouseHover;
            Create_btn.Click += Create_btn_Click;
            PO_grp.Controls.Add(Create_btn);
            #endregion
            
        }

        
        #region "PO_grp Functions"
        #region "PODpt_comBox"
        void PODpt_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PODpt_comBox.Text == "Consumer")
            {
                cls.con.Open();
                OleDbCommand cmd1 = new OleDbCommand("Select POID from PO;", cls.con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                int d = 0;
                while (dr1.Read())
                {
                    d++;
                }
                cls.con.Close();
                POID_txt.Text = "Cons-00" + (d + 1).ToString() + DateTime.Today.Year;
            }
            else if (PODpt_comBox.Text == "HR")
            {
                cls.con.Open();
                OleDbCommand cmd1 = new OleDbCommand("Select POID from PO;", cls.con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                int d = 0;
                while (dr1.Read())
                {
                    d++;
                }
                cls.con.Close();
                POID_txt.Text = "HR-00" + (d + 1).ToString() + DateTime.Today.Year;
            }
            else if (PODpt_comBox.Text == "Marketing")
            {
                cls.con.Open();
                OleDbCommand cmd1 = new OleDbCommand("Select POID from PO;", cls.con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                int d = 0;
                while (dr1.Read())
                {
                    d++;
                }
                cls.con.Close();
                POID_txt.Text = "Mark-00" + (d + 1).ToString() + DateTime.Today.Year;
            }
            else if (PODpt_comBox.Text == "Sales")
            {
                cls.con.Open();
                OleDbCommand cmd1 = new OleDbCommand("Select POID from PO;", cls.con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                int d = 0;
                while (dr1.Read())
                {
                    d++;
                }
                cls.con.Close();
                POID_txt.Text = "Sale-00" + (d + 1).ToString() + DateTime.Today.Year;
            }
            else
            {
                MessageBox.Show("Your input is invalid.");
            }
        }
        #endregion
        #endregion
        #region "VID_comBox"
        void VID_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select * from Vendor where VID='"+VID_comBox.Text+"';",cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read()){
                VName_txt.Text=(dr["VName"]).ToString();
                Vdpt_txt.Text=(dr["VGroup"]).ToString();
                CPName_txt.Text=(dr["CPName"]).ToString();
                CPPH_txt.Text=(dr["CPPH"]).ToString();
            }
            cls.con.Close();
        }
        #endregion
        #region "PModel_comBox"
        void PModel_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand("Select PName, BasePrice from Products where PModel='"+PModel_comBox.Text+"'", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read()){
                PName_txt.Text = dr["PName"].ToString();
                PPrice_txt.Text = dr["BasePrice"].ToString();
            }
            cls.con.Close();
        }
        #endregion
        #region "Form_Validation"
        void PODpt_comBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void VID_comBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void PModel_comBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion
        #region "PO_grp_Paint"
        private void PO_grp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = PO_grp.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            p.Width = 1;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, (PO_grp.Width/2) - (425/2), 35, 425, 170);
            g.DrawRectangle(p, (PO_grp.Width / 3) - (445 / 2), 220, 325, 265);
            g.DrawRectangle(p, ((PO_grp.Width / 2) + (PO_grp.Width / 4)) - (325 / 2), 220, 325, 265);
            g.DrawRectangle(p, (PO_grp.Width / 3) - (425 / 2), 500, 425, 130);
        }
        #endregion
        #region "Create_btn Functions"
        void Create_btn_MouseHover(object sender, EventArgs e)
        {
            Create_btn.Cursor = Cursors.Hand;
        }
        public virtual void Create_btn_Click(object sender, EventArgs e)
        {
            if (!(PODpt_comBox.Text == "" && PODpt_comBox.Text == "Choose Department" && POID_txt.Text == "" && VID_comBox.Text == "" && VID_comBox.Text == "Choose Vendor ID" && VName_txt.Text == "" && Vdpt_txt.Text == "" && CPName_txt.Text == "" && CPPH_txt.Text == "" && Final_txt.Text == ""))
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into PO(POID, DDate, VID, VName, VDept, VContectPerson, VCPPH, TotalAmount, Status)values(@POID, @DDate, @VID, @VName, @VDept, @VContectPerson, @VCPPH, @TotalAmount, 'Open')", cls.con);
                cmd.Parameters.AddWithValue("@POID", POID_txt.Text);
                cmd.Parameters.AddWithValue("@DDate", DTP.Text);
                cmd.Parameters.AddWithValue("@VID", VID_comBox.Text);
                cmd.Parameters.AddWithValue("@VName", VName_txt.Text);
                cmd.Parameters.AddWithValue("@VDept", Vdpt_txt.Text);
                cmd.Parameters.AddWithValue("@VContectPerson", CPName_txt.Text);
                cmd.Parameters.AddWithValue("@VCPPH", CPPH_txt.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", (Convert.ToInt32(PPrice_txt.Text) * Convert.ToInt32(PQuantity_txt.Text)).ToString());
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand(@"insert into POProducts(POID, PModel, PQty)values(@POID, @PModel, @PQty)", cls.con);
                cmd1.Parameters.AddWithValue("@POID", POID_txt.Text);
                cmd1.Parameters.AddWithValue("@PModel", PModel_comBox.Text);
                cmd1.Parameters.AddWithValue("@PQty", PQuantity_txt.Text);
                cmd1.ExecuteNonQuery();
                cls.con.Close();
                MessageBox.Show("Purchase Order has been created.");
                PODpt_comBox.Text = "Choose Department";
                VID_comBox.Text = "Choose Vendor ID";
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
        #endregion
        #region "addData_btn Functions"
        void addData_btn_Click(object sender, EventArgs e)
        {
            if (!(PModel_comBox.Text == "" || PModel_comBox.Text == "Choose Product Model" && PName_txt.Text == "" && PPrice_txt.Text == "" && PQuantity_txt.Text == ""))
            {
                try
                {
                    Final_txt.Text = "PModel: " + PModel_comBox.Text + Environment.NewLine + "Product Price: " + PName_txt.Text + Environment.NewLine + "Product Price: " + PPrice_txt.Text + Environment.NewLine + "Total Amount: " + Convert.ToInt32(PPrice_txt.Text) * Convert.ToInt32(PQuantity_txt.Text);
                }
                catch {
                    MessageBox.Show("Please insert the quantity of the products.");
                }
            }
            else
            {
                MessageBox.Show("Please insert product details.");
            }
        }
        void addData_btn_MouseHover(object sender, EventArgs e)
        {
            addData_btn.Cursor = Cursors.Hand;
        }
        #endregion
    }
}
