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
    public class CustomerData
    {
        #region "Initialize-Classes & Forms"
        public Connection cls = new Connection();
        #endregion
        #region "Declaration & Initialization"
        //Everything in CustomerData will be initialized here.
        #region "Panels"
        public Panel customerDataPnl = new Panel();
        #endregion
        #region "Labels"
        public Label CID_lbl = new Label();
        public Label cname_lbl = new Label();
        Label caddress_lbl = new Label();
        Label city_lbl = new Label();
        Label ph1_lbl = new Label();
        Label ph2_lbl = new Label();
        Label cperson_lbl = new Label();
        Label cph_lbl = new Label();
        Label cemail_lbl = new Label();
        public Label creditlmt_lbl = new Label();
        Label cstatus_lbl = new Label();
        Label cgroup_lbl = new Label();
        Label cData_lbl = new Label();
        #endregion
        #region "TextBoxes"
        public TextBox CID_txt = new TextBox();
        public TextBox cname_txt = new TextBox();
        public TextBox caddress_txt = new TextBox();
        public TextBox city_txt = new TextBox();
        public TextBox ph1_txt = new TextBox();
        public TextBox ph2_txt = new TextBox();
        public TextBox cperson_txt = new TextBox();
        public TextBox cph_txt = new TextBox();
        public TextBox cemail_txt = new TextBox();
        public TextBox creditlmt_txt = new TextBox();
        #endregion
        #region "ComboBoxes"
        public ComboBox active_comBox = new ComboBox();
        public ComboBox grp_comBox = new ComboBox();
        #endregion
        #region "Buttons"
        public Button submit_btn = new Button();
        #endregion
        #region "GroupBoxes"
        public GroupBox customer_grp = new GroupBox();
        #endregion
        #endregion
        public void customerData() {
            cls.conString();
            // Customer Insert Data Start -->
            #region "CustomerDataPnl"
            customerDataPnl.Dock = DockStyle.Fill;
            customerDataPnl.BackColor = Color.MintCream;
            customerDataPnl.Visible = false;
            #endregion
            #region "GroupBox"
            customer_grp.Size = new Size(700, 650);
            customer_grp.Location = new Point(295, 60);
            customer_grp.Text = "Customer Data Form";
            customer_grp.ForeColor = Color.DarkGray;
            customer_grp.Font = new Font("Arial", 12, FontStyle.Bold);
            customer_grp.FlatStyle = FlatStyle.Flat;
            customer_grp.Paint += customer_grp_Paint;
            customerDataPnl.Controls.Add(customer_grp);
            #endregion
            #region "CID_lbl"
            CID_lbl.Size = new Size(90, 20);
            CID_lbl.Location = new Point(16, 55);
            CID_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            CID_lbl.Text = "Customer ID:";
            CID_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(CID_lbl);
            #endregion
            #region "CID_txt"
            CID_txt.Size = new Size(150, 10);
            CID_txt.Location = new Point(20, 75);
            CID_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            CID_txt.ForeColor = Color.Gray;
            CID_txt.ReadOnly = true;
            CID_txt.BackColor = Color.White;
            CID_txt.Enabled = false;
            customer_grp.Controls.Add(CID_txt);
            #endregion
            #region "cname_lbl"
            cname_lbl.Size = new Size(120, 20);
            cname_lbl.Location = new Point(16, 100);
            cname_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            cname_lbl.Text = "Customer Name:";
            cname_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(cname_lbl);
            #endregion
            #region "cname_txt"
            cname_txt.Size = new Size(150, 10);
            cname_txt.Location = new Point(20, 120);
            cname_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            cname_txt.ForeColor = Color.Gray;
            cname_txt.BackColor = Color.White;
            cname_txt.KeyPress += cname_txt_KeyPress;
            customer_grp.Controls.Add(cname_txt);
            #endregion
            #region "caddress_lbl"
            caddress_lbl.Size = new Size(120, 20);
            caddress_lbl.Location = new Point(16, 145);
            caddress_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            caddress_lbl.Text = "Address:";
            caddress_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(caddress_lbl);
            #endregion
            #region "caddress_txt"
            caddress_txt.Size = new Size(150, 10);
            caddress_txt.Location = new Point(20, 165);
            caddress_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            caddress_txt.ForeColor = Color.Gray;
            caddress_txt.BackColor = Color.White;
            customer_grp.Controls.Add(caddress_txt);
            #endregion
            #region "city_lbl"
            city_lbl.Size = new Size(120, 20);
            city_lbl.Location = new Point(16, 190);
            city_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            city_lbl.Text = "City:";
            city_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(city_lbl);
            #endregion
            #region "city_txt"
            city_txt.Size = new Size(150, 10);
            city_txt.Location = new Point(20, 210);
            city_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            city_txt.ForeColor = Color.Gray;
            city_txt.BackColor = Color.White;
            city_txt.KeyPress += city_txt_KeyPress;
            customer_grp.Controls.Add(city_txt);
            #endregion
            #region "ph1_lbl"
            ph1_lbl.Size = new Size(120, 20);
            ph1_lbl.Location = new Point(16, 235);
            ph1_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            ph1_lbl.Text = "Phone-1 #";
            ph1_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(ph1_lbl);
            #endregion
            #region "ph1_txt"
            ph1_txt.Size = new Size(150, 10);
            ph1_txt.Location = new Point(20, 255);
            ph1_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            ph1_txt.ForeColor = Color.Gray;
            ph1_txt.BackColor = Color.White;
            ph1_txt.KeyPress += ph1_txt_KeyPress;
            customer_grp.Controls.Add(ph1_txt);
            #endregion
            #region "ph2_lbl"
            ph2_lbl.Size = new Size(120, 20);
            ph2_lbl.Location = new Point(16, 280);
            ph2_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            ph2_lbl.Text = "Phone-2 #";
            ph2_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(ph2_lbl);
            #endregion
            #region "ph2_txt"
            ph2_txt.Size = new Size(150, 10);
            ph2_txt.Location = new Point(20, 300);
            ph2_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            ph2_txt.ForeColor = Color.Gray;
            ph2_txt.BackColor = Color.White;
            ph2_txt.KeyPress += ph2_txt_KeyPress;
            customer_grp.Controls.Add(ph2_txt);
            #endregion
            #region "cData_lbl"
            cData_lbl.Size = new Size(180, 20);
            cData_lbl.Location = new Point(320, 50);
            cData_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            cData_lbl.Text = "Contact Person Information";
            cData_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(cData_lbl);
            #endregion
            #region "cperson_lbl"
            cperson_lbl.Size = new Size(110, 20);
            cperson_lbl.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - cperson_lbl.Size.Width / 2, 80);
            cperson_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            cperson_lbl.Text = "Contact Person";
            cperson_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(cperson_lbl);
            #endregion
            #region "cperson_txt"
            cperson_txt.Size = new Size(150, 10);
            cperson_txt.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - cperson_txt.Size.Width / 2, 100);
            cperson_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            cperson_txt.ForeColor = Color.Gray;
            cperson_txt.BackColor = Color.White;
            cperson_txt.KeyPress += cperson_txt_KeyPress;
            customer_grp.Controls.Add(cperson_txt);
            #endregion
            #region "cph_lbl"
            cph_lbl.Size = new Size(70, 20);
            cph_lbl.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - cph_lbl.Size.Width / 2, 125);
            cph_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            cph_lbl.Text = "Phone No";
            cph_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(cph_lbl);
            #endregion
            #region "cph_txt"
            cph_txt.Size = new Size(150, 10);
            cph_txt.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - cph_txt.Size.Width / 2, 145);
            cph_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            cph_txt.ForeColor = Color.Gray;
            cph_txt.BackColor = Color.White;
            cph_txt.KeyPress += cph_txt_KeyPress;
            customer_grp.Controls.Add(cph_txt);
            #endregion
            #region "cemail_lbl"
            cemail_lbl.Size = new Size(50, 20);
            cemail_lbl.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - cemail_lbl.Size.Width / 2, 170);
            cemail_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            cemail_lbl.Text = "Email";
            cemail_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(cemail_lbl);
            #endregion
            #region "cemail_txt"
            cemail_txt.Size = new Size(150, 10);
            cemail_txt.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - cemail_txt.Size.Width / 2, 190);
            cemail_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            cemail_txt.ForeColor = Color.Gray;
            cemail_txt.BackColor = Color.White;
            cemail_txt.KeyPress += cemail_txt_KeyPress;
            customer_grp.Controls.Add(cemail_txt);
            #endregion
            #region "creditlmt_lbl"
            creditlmt_lbl.Size = new Size(85, 20);
            creditlmt_lbl.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - creditlmt_lbl.Size.Width / 2, 215);
            creditlmt_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            creditlmt_lbl.Text = "Credit Limit";
            creditlmt_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(creditlmt_lbl);
            #endregion
            #region "creditlmt_txt"
            creditlmt_txt.Size = new Size(150, 10);
            creditlmt_txt.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - creditlmt_txt.Size.Width / 2, 235);
            creditlmt_txt.Font = new Font("Arial", 9, FontStyle.Regular);
            creditlmt_txt.ForeColor = Color.Gray;
            creditlmt_txt.BackColor = Color.White;
            creditlmt_txt.KeyPress += creditlmt_txt_KeyPress;
            customer_grp.Controls.Add(creditlmt_txt);
            #endregion
            #region "cgroup_lbl"
            cgroup_lbl.Size = new Size(50, 20);
            cgroup_lbl.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - cgroup_lbl.Size.Width / 2, 260);
            cgroup_lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            cgroup_lbl.Text = "Group";
            cgroup_lbl.ForeColor = Color.Gray;
            customer_grp.Controls.Add(cgroup_lbl);
            #endregion
            #region "grp_comBox"
            grp_comBox.Size = new Size(150, 10);
            grp_comBox.Location = new Point((cData_lbl.Location.X + (cData_lbl.Size.Width / 2)) - grp_comBox.Size.Width / 2, 280);
            grp_comBox.Font = new Font("Arial", 9, FontStyle.Regular);
            grp_comBox.ForeColor = Color.Gray;
            grp_comBox.BackColor = Color.White;
            grp_comBox.Text = "Choose Group";
            grp_comBox.KeyPress += grp_comBox_KeyPress;
            customer_grp.Controls.Add(grp_comBox);
            #endregion
            #region "active_comBox"
            active_comBox.Size = new Size(300, 20);
            active_comBox.Location = new Point(customer_grp.Size.Width / 2 - active_comBox.Size.Width / 2, 400);
            active_comBox.Items.Add("Active");
            active_comBox.Items.Add("InActive");
            active_comBox.Font = new Font("", 10, FontStyle.Regular);
            active_comBox.DropDownStyle = ComboBoxStyle.DropDown;
            active_comBox.ForeColor = Color.Gray;
            active_comBox.KeyPress += active_comBox_KeyPress;
            active_comBox.Text = "Choose Status";
            customer_grp.Controls.Add(active_comBox);
            #endregion
            #region "submit_btn"
            submit_btn.Size = new Size(300, 40);
            submit_btn.Location = new Point(customer_grp.Size.Width / 2 - submit_btn.Size.Width / 2, 440);
            submit_btn.Font = new Font("", 10, FontStyle.Regular);
            submit_btn.ForeColor = Color.White;
            submit_btn.BackColor = Color.DeepSkyBlue;
            submit_btn.FlatStyle = FlatStyle.Flat;
            submit_btn.FlatAppearance.BorderSize = 0;
            submit_btn.Text = "Add Data";
            submit_btn.Click +=submit_btn_Click;
            submit_btn.MouseHover += submit_btn_MouseHover;
            customer_grp.Controls.Add(submit_btn);
            #endregion
        }



        #region "Submit_Btn Function"

        void submit_btn_MouseHover(object sender, EventArgs e)
        {
            submit_btn.Cursor = Cursors.Hand;
        }

        public virtual void submit_btn_Click(object sender, EventArgs e)
        {
            if (cname_txt.Text != "" && caddress_txt.Text != "" && city_txt.Text != "" && ph1_txt.Text != "" && ph2_txt.Text != "" && cperson_txt.Text != "" && cph_txt.Text != "" && cemail_txt.Text != "" && creditlmt_txt.Text != "" && grp_comBox.Text != "" && active_comBox.Text != "Choose Status" && active_comBox.Text != "")
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Customer(CID, Cname, CAddress, City, PH1, PH2, ContectPerson, CPPH, CEMAIL, CreditLimit, CStatus, CGroup, Approval)values(@CID, @Cname, @CAddress, @City, @PH1, @PH2, @ContectPerson, @CPPH, @CEMAIL, @CreditLimit, @CStatus, @CGroup, 'Unapproved')", cls.con);
                cmd.Parameters.AddWithValue("@CID", CID_txt.Text);
                cmd.Parameters.AddWithValue("@Cname", cname_txt.Text);
                cmd.Parameters.AddWithValue("@CAddress", caddress_txt.Text);
                cmd.Parameters.AddWithValue("@City", city_txt.Text);
                cmd.Parameters.AddWithValue("@PH1", ph1_txt.Text);
                cmd.Parameters.AddWithValue("@PH2", ph2_txt.Text);
                cmd.Parameters.AddWithValue("@ContectPerson", cperson_txt.Text);
                cmd.Parameters.AddWithValue("@CPPH", cph_txt.Text);
                cmd.Parameters.AddWithValue("@CEMAIL", cemail_txt.Text);
                cmd.Parameters.AddWithValue("@CreditLimit", creditlmt_txt.Text);
                cmd.Parameters.AddWithValue("@CStatus", active_comBox.Text);
                cmd.Parameters.AddWithValue("@CGroup", grp_comBox.Text);
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
                OleDbCommand cmd1 = new OleDbCommand("Select CID from Customer;", cls.con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                int d = 0;
                while (dr1.Read())
                {
                    d++;
                }
                CID_txt.Text = "CID-00" + (d + 1).ToString() + DateTime.Today.Year;
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

        #endregion
        #region "customer_grp Functions"
        void active_comBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void grp_comBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void cemail_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == '@' || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        

        void creditlmt_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        void cperson_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        void ph2_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        void ph1_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        void cph_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        void city_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        void cname_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        void customer_grp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = customer_grp.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            p.Width = 1;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, 200, 60, 425, 261);
        }
        #endregion

    }
}
