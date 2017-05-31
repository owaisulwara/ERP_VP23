using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        #region "Initialize-Classes & Forms"
        Connection cls = new Connection();
        Front frontClass = new Front();
        Login login = new Login();
        SignUp signup = new SignUp();
        SelectionPanel selectionpanel = new SelectionPanel();
        AdministratorFunc administratorfunc = new AdministratorFunc();
        CustomerFunc customerfunc = new CustomerFunc();
        CustomerDataApprove customerdataapprove = new CustomerDataApprove();
        CustomerData customerData = new CustomerData();
        CustomerDataUpdate customerdataupdate = new CustomerDataUpdate();
        CustomerDataView customerdataview = new CustomerDataView();
        VendorFunc vendorfunc = new VendorFunc();
        VendorData vendordata = new VendorData();
        VendorDataUpdate vendordataupdate = new VendorDataUpdate();
        VendorDataView vendordataview = new VendorDataView();
        PurchaseFunc purchasefunc = new PurchaseFunc();
        PurchaseOrder purchaseorder = new PurchaseOrder();
        GRNFunc grnfunc = new GRNFunc();
        GRN grn = new GRN();
        InvoiceFunc invoicefunc = new InvoiceFunc();
        Invoice invoice = new Invoice();
        SalesOrderFunc salesfunc = new SalesOrderFunc();
        SalesOrder salesorder = new SalesOrder();
        #endregion
        #region "Panels"
        //Top Cotrol Panel -->
        Panel controlBox_Pnl = new Panel();
        //Top Cotrol Panel <--
        #endregion
        #region "Buttons"
        //Top Control Buttons -->
        Button Exit_Btn = new Button();
        Button Minimize_Btn = new Button();
        //Top Control Buttons <--
        #endregion
        #region "Labels"
        //Top Control Label -->
        Label Title_lbl = new Label();
        //Top Control Label <--
        Label wel = new Label();
        #endregion
        public Form1()
        {
            InitializeComponent();
            cls.conString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region "Form1-Styles"
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.DeepSkyBlue;
            #endregion
            #region "ControlBox_Panel"
            #region "controlBox_pnl"
            controlBox_Pnl.Location = new Point(0, 0);
            controlBox_Pnl.Size = new Size(0, 35);
            controlBox_Pnl.Dock = DockStyle.Top;
            controlBox_Pnl.BackColor = Color.White;
            this.Controls.Add(controlBox_Pnl);
            #endregion
            #region "Title_lbl"
            Title_lbl.Location = new Point(15, 15);
            Title_lbl.Text = "Code-App";
            Title_lbl.ForeColor = Color.DarkGray;
            controlBox_Pnl.Controls.Add(Title_lbl);
            #endregion
            #region "Minimize_Btn"
            Minimize_Btn.Left = 932;
            Minimize_Btn.Size = new Size(50, 35);
            Minimize_Btn.BackColor = Color.White;
            Minimize_Btn.ForeColor = Color.Gray;
            Minimize_Btn.FlatStyle = FlatStyle.Flat;
            Minimize_Btn.FlatAppearance.BorderSize = 0;
            Minimize_Btn.Text = "-";
            Minimize_Btn.Font = new Font("", 15);
            Minimize_Btn.MouseEnter += Minimize_Btn_MouseEnter;
            Minimize_Btn.Click += Minimize_Btn_Click;
            Minimize_Btn.MouseLeave += Minimize_Btn_MouseLeave;
            controlBox_Pnl.Controls.Add(Minimize_Btn);
            #endregion

            #region "Exit_btn"
            Exit_Btn.Left = 982;
            Exit_Btn.Size = new Size(50, 35);
            Exit_Btn.BackColor = Color.White;
            Exit_Btn.ForeColor = Color.Gray;
            Exit_Btn.FlatStyle = FlatStyle.Flat;
            Exit_Btn.FlatAppearance.BorderSize = 0;
            Exit_Btn.Text = "X";
            Exit_Btn.MouseEnter += Exit_Btn_MouseEnter;
            Exit_Btn.Click += Exit_Btn_Click;
            Exit_Btn.MouseLeave += Exit_Btn_MouseLeave;
            controlBox_Pnl.Controls.Add(Exit_Btn);
            #endregion
            #endregion
            #region "Welcome"
            wel.Size = new Size(350,70);
            wel.Location = new Point(((Screen.PrimaryScreen.Bounds.Width/2)+130)-(wel.Width/2), ((Screen.PrimaryScreen.Bounds.Height/2)-35)-(wel.Height/2));
            wel.Font = new Font("", 50, FontStyle.Bold);
            wel.Text = "Welcome!";
            wel.ForeColor = Color.White;
            wel.Visible = false;
            this.Controls.Add(wel);
            #endregion
            #region "Login"
            login.LoginForm();
            login.Log_Btn.Click += Log_Btn_Click;
            login.Sign_Btn.Click += Sign_Btn_Click;
            this.Controls.Add(login.Login_Pnl);
            #endregion
            #region "Sign Up"
            signup.signupData();
            this.Controls.Add(signup.Login_Pnl);
            #endregion
            #region "SelectionPanel"
            selectionpanel.selectionPanel();
            this.Controls.Add(selectionpanel.selection_Pnl);
            selectionpanel.admin_Btn.Click += admin_Btn_Click;
            selectionpanel.customer_Btn.Click += customer_Btn_Click;
            selectionpanel.purchase_Btn.Click += purchase_Btn_Click;
            selectionpanel.vendor_Btn.Click += vendor_Btn_Click;
            selectionpanel.GRN_Btn.Click += GRN_Btn_Click;
            selectionpanel.Invoice_Btn.Click += Invoice_Btn_Click;
            selectionpanel.Sales_Btn.Click += Sales_Btn_Click;
            #endregion
            #region "AdministratorFunc"
            administratorfunc.adminFunc();
            this.Controls.Add(administratorfunc.customer_Pnl);
            administratorfunc.insert_btn.Click -= insert_btn_Click;
            administratorfunc.insert_btn.Click += customerApproveBtn_Click;
            #endregion
            #region "CustomerFunc"
            customerfunc.customerFunc();
            this.Controls.Add(customerfunc.customer_Pnl);
            customerfunc.insert_btn.Click += insert_btn_Click;
            customerfunc.update_btn.Click += update_btn_Click;
            customerfunc.view_btn.Click += view_btn_Click;
            #endregion
            #region "CustomerDataApprove"
            customerdataapprove.customerDataApprove();
            this.Controls.Add(customerdataapprove.customerDataPnl);
            #endregion
            #region "CustomerData"
            customerData.customerData();
            this.Controls.Add(customerData.customerDataPnl);
            #endregion
            #region "CustomerDataUpdate"
            customerdataupdate.customerDataUpdate();
            this.Controls.Add(customerdataupdate.customerDataPnl);
            #endregion
            #region "CustomerDataView"
            customerdataview.customerDataView();
            this.Controls.Add(customerdataview.customerDataPnl);
            #endregion
            #region "VendorFunc"
            vendorfunc.vendorFunc();
            this.Controls.Add(vendorfunc.customer_Pnl);
            vendorfunc.insert_btn.Click -= insert_btn_Click;
            vendorfunc.insert_btn.Click += addVendor_Click;
            vendorfunc.update_btn.Click -= update_btn_Click;
            vendorfunc.update_btn.Click += updateVendor_Click;
            vendorfunc.view_btn.Click -= view_btn_Click;
            vendorfunc.view_btn.Click += viewVendor_Click;
            #endregion
            #region "VendorData"
            vendordata.vendorData();
            this.Controls.Add(vendordata.customerDataPnl);
            #endregion
            #region "VendorDataUpdate"
            vendordataupdate.vendorDataUpdate();
            this.Controls.Add(vendordataupdate.customerDataPnl);
            #endregion
            #region "VendorDataView"
            vendordataview.vendorDataView();
            this.Controls.Add(vendordataview.customerDataPnl);
            #endregion
            #region "PurchaseFunc"
            purchasefunc.pruchaseFunc();
            this.Controls.Add(purchasefunc.customer_Pnl);
            purchasefunc.insert_btn.Click -= insert_btn_Click;
            purchasefunc.insert_btn.Click += POAdd_Click;
            #endregion
            #region "PurchaseOrder"
            purchaseorder.purchaseOrder();
            this.Controls.Add(purchaseorder.PO_Pnl);
            #endregion
            #region "GRNFunc"
            grnfunc.GRNfunc();
            this.Controls.Add(grnfunc.customer_Pnl);
            grnfunc.insert_btn.Click -= insert_btn_Click;
            grnfunc.insert_btn.Click += GRNAdd_Click;
            #endregion
            #region "GRN"
            grn.GRNData();
            this.Controls.Add(grn.GRN_Pnl);
            #endregion
            #region "InvoiceFunc"
            invoicefunc.invoiceFunc();
            this.Controls.Add(invoicefunc.customer_Pnl);
            invoicefunc.insert_btn.Click -= insert_btn_Click;
            invoicefunc.insert_btn.Click += InvoiceAdd_Click;
            #endregion
            #region "Invoice"
            invoice.invoiceData();
            this.Controls.Add(invoice.Invoice_Pnl);
            #endregion
            #region "SalesOrderFunc"
            salesfunc.SalesFunc();
            this.Controls.Add(salesfunc.customer_Pnl);
            salesfunc.insert_btn.Click -= insert_btn_Click;
            salesfunc.insert_btn.Click += salesAdd_Click;
            #endregion
            #region "SalesOrder"
            salesorder.salesOrder();
            this.Controls.Add(salesorder.PO_Pnl);
            #endregion
        }

        

        

        void Sign_Btn_Click(object sender, EventArgs e)
        {
            login.Login_Pnl.Visible = false;
            signup.Login_Pnl.Visible = true;
        }

        #region "ControlBox_Panel Functions"
        void Exit_Btn_MouseLeave(object sender, EventArgs e)
        {
            Exit_Btn.BackColor = Color.White;
            Exit_Btn.ForeColor = Color.Gray;
        }

        private void Exit_Btn_MouseEnter(object sender, EventArgs e)
        {
            Exit_Btn.BackColor = Color.Red;
            Exit_Btn.ForeColor = Color.White;
        }

        void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimize_Btn_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Btn.BackColor = Color.White;
            Minimize_Btn.ForeColor = Color.Gray;
        }

        private void Minimize_Btn_MouseEnter(object sender, EventArgs e)
        {
            Minimize_Btn.BackColor = Color.Red;
            Minimize_Btn.ForeColor = Color.White;
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region "Login Form Functions"
        void Log_Btn_Click(object sender, EventArgs e)
        {
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Userdata;", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (login.User_txt.Text == dr["Username"].ToString() && login.Password_txt.Text == dr["Password"].ToString())
                {
                    login.Login_Pnl.Visible = false;
                    selectionpanel.selection_Pnl.Visible = true;
                    wel.Visible = true;
                }
                else
                    MessageBox.Show("Please insert correct username or password.");
            }
            cls.con.Close();
        }
        #endregion
        #region "SelectionPanel Functions"
        void admin_Btn_Click(object sender, EventArgs e)
        {
            customerData.customerDataPnl.Visible = false;
            customerdataupdate.customerDataPnl.Visible = false;
            customerfunc.customer_Pnl.Visible = false;
            purchasefunc.customer_Pnl.Visible = false;
            customerdataview.customerDataPnl.Visible = false;
            vendordata.customerDataPnl.Visible = false;
            administratorfunc.customer_Pnl.Visible = true;
            customerdataapprove.customerDataPnl.Visible = false;
            vendorfunc.customer_Pnl.Visible = false;
            vendordataview.customerDataPnl.Visible = false;
            vendordataupdate.customerDataPnl.Visible = false;
            wel.Visible = false;
            purchaseorder.PO_Pnl.Visible = false;
            grnfunc.customer_Pnl.Visible = false;
            grn.GRN_Pnl.Visible = false;
            invoicefunc.customer_Pnl.Visible = false;
            invoice.Invoice_Pnl.Visible = false;
            salesfunc.customer_Pnl.Visible = false;
            salesorder.PO_Pnl.Visible = false;
        }
        private void customer_Btn_Click(object sender, EventArgs e)
        {
            wel.Visible = false;
            customerData.customerDataPnl.Visible = false;
            customerdataupdate.customerDataPnl.Visible = false;
            administratorfunc.customer_Pnl.Visible = false;
            purchasefunc.customer_Pnl.Visible = false;
            customerdataview.customerDataPnl.Visible = false;
            vendordata.customerDataPnl.Visible = false;
            customerfunc.customer_Pnl.Visible = true;
            vendorfunc.customer_Pnl.Visible = false;
            vendordataupdate.customerDataPnl.Visible = false;
            vendordataview.customerDataPnl.Visible = false;
            customerdataapprove.customerDataPnl.Visible = false;
            purchaseorder.PO_Pnl.Visible = false;
            grnfunc.customer_Pnl.Visible = false;
            grn.GRN_Pnl.Visible = false;
            invoicefunc.customer_Pnl.Visible = false;
            invoice.Invoice_Pnl.Visible = false;
            salesfunc.customer_Pnl.Visible = false;
            salesorder.PO_Pnl.Visible = false;
        }
        void vendor_Btn_Click(object sender, EventArgs e)
        {
            invoice.Invoice_Pnl.Visible = false;
            wel.Visible = false;
            customerData.customerDataPnl.Visible = false;
            customerdataupdate.customerDataPnl.Visible = false;
            administratorfunc.customer_Pnl.Visible = false;
            customerfunc.customer_Pnl.Visible = false;
            customerdataview.customerDataPnl.Visible = false;
            vendordata.customerDataPnl.Visible = false;
            purchasefunc.customer_Pnl.Visible = false;
            vendordataupdate.customerDataPnl.Visible = false;
            vendorfunc.customer_Pnl.Visible = true;
            vendordataview.customerDataPnl.Visible = false;
            customerdataapprove.customerDataPnl.Visible = false;
            purchaseorder.PO_Pnl.Visible = false;
            grnfunc.customer_Pnl.Visible = false;
            grn.GRN_Pnl.Visible = false;
            salesfunc.customer_Pnl.Visible = false;
            invoicefunc.customer_Pnl.Visible = false;
            salesorder.PO_Pnl.Visible = false;
        }
        void purchase_Btn_Click(object sender, EventArgs e)
        {
            invoice.Invoice_Pnl.Visible = false;
            wel.Visible = false;
            customerData.customerDataPnl.Visible = false;
            customerdataupdate.customerDataPnl.Visible = false;
            administratorfunc.customer_Pnl.Visible = false;
            customerfunc.customer_Pnl.Visible = false;
            customerdataview.customerDataPnl.Visible = false;
            vendordata.customerDataPnl.Visible = false;
            purchasefunc.customer_Pnl.Visible = true;
            vendorfunc.customer_Pnl.Visible = false;
            vendordataupdate.customerDataPnl.Visible = false;
            vendordataview.customerDataPnl.Visible = false;
            customerdataapprove.customerDataPnl.Visible = false;
            purchaseorder.PO_Pnl.Visible = false;
            grnfunc.customer_Pnl.Visible = false;
            grn.GRN_Pnl.Visible = false;
            salesfunc.customer_Pnl.Visible = false;
            invoicefunc.customer_Pnl.Visible = false;
            salesorder.PO_Pnl.Visible = false;
        }
        void GRN_Btn_Click(object sender, EventArgs e)
        {
            invoice.Invoice_Pnl.Visible = false;
            wel.Visible = false;
            customerData.customerDataPnl.Visible = false;
            customerdataupdate.customerDataPnl.Visible = false;
            administratorfunc.customer_Pnl.Visible = false;
            customerfunc.customer_Pnl.Visible = false;
            customerdataview.customerDataPnl.Visible = false;
            vendordata.customerDataPnl.Visible = false;
            purchasefunc.customer_Pnl.Visible = false;
            vendorfunc.customer_Pnl.Visible = false;
            vendordataupdate.customerDataPnl.Visible = false;
            vendordataview.customerDataPnl.Visible = false;
            customerdataapprove.customerDataPnl.Visible = false;
            purchaseorder.PO_Pnl.Visible = false;
            grnfunc.customer_Pnl.Visible = true;
            grn.GRN_Pnl.Visible = false;
            salesfunc.customer_Pnl.Visible = false;
            invoicefunc.customer_Pnl.Visible = false;
            salesorder.PO_Pnl.Visible = false;
        }
        void Invoice_Btn_Click(object sender, EventArgs e)
        {
            invoice.Invoice_Pnl.Visible = false;
            wel.Visible = false;
            customerData.customerDataPnl.Visible = false;
            customerdataupdate.customerDataPnl.Visible = false;
            administratorfunc.customer_Pnl.Visible = false;
            customerfunc.customer_Pnl.Visible = false;
            customerdataview.customerDataPnl.Visible = false;
            vendordata.customerDataPnl.Visible = false;
            purchasefunc.customer_Pnl.Visible = false;
            vendorfunc.customer_Pnl.Visible = false;
            vendordataupdate.customerDataPnl.Visible = false;
            vendordataview.customerDataPnl.Visible = false;
            customerdataapprove.customerDataPnl.Visible = false;
            purchaseorder.PO_Pnl.Visible = false;
            grnfunc.customer_Pnl.Visible = false;
            grn.GRN_Pnl.Visible = false;
            salesfunc.customer_Pnl.Visible = false;
            invoicefunc.customer_Pnl.Visible = true;
            salesorder.PO_Pnl.Visible = false;
        }
        void Sales_Btn_Click(object sender, EventArgs e)
        {
            invoice.Invoice_Pnl.Visible = false;
            wel.Visible = false;
            customerData.customerDataPnl.Visible = false;
            customerdataupdate.customerDataPnl.Visible = false;
            administratorfunc.customer_Pnl.Visible = false;
            customerfunc.customer_Pnl.Visible = false;
            customerdataview.customerDataPnl.Visible = false;
            vendordata.customerDataPnl.Visible = false;
            purchasefunc.customer_Pnl.Visible = false;
            vendorfunc.customer_Pnl.Visible = false;
            vendordataupdate.customerDataPnl.Visible = false;
            vendordataview.customerDataPnl.Visible = false;
            customerdataapprove.customerDataPnl.Visible = false;
            purchaseorder.PO_Pnl.Visible = false;
            grnfunc.customer_Pnl.Visible = false;
            grn.GRN_Pnl.Visible = false;
            invoicefunc.customer_Pnl.Visible = false;
            salesfunc.customer_Pnl.Visible = true;
            salesorder.PO_Pnl.Visible = false;
        }
        #endregion
        #region "AdministratorFunc"
        #region "CustomerApproveBtn"
        private void customerApproveBtn_Click(object sender, EventArgs e)
        {
            administratorfunc.customer_Pnl.Visible = false;
            customerdataapprove.customerDataPnl.Visible = true;
        }
        #endregion
        #endregion
        #region "CustomerFunc Functions"
        private void insert_btn_Click(object sender, EventArgs e)
        {
            customerfunc.customer_Pnl.Visible = false;
            customerData.CID_txt.Clear();
            customerData.cname_txt.Clear();
            customerData.caddress_txt.Clear();
            customerData.city_txt.Clear();
            customerData.ph1_txt.Clear();
            customerData.ph2_txt.Clear();
            customerData.cperson_txt.Clear();
            customerData.cph_txt.Clear();
            customerData.cemail_txt.Clear();
            customerData.creditlmt_txt.Clear();
            customerData.active_comBox.Items.Clear();
            customerData.active_comBox.Items.Add("Active");
            customerData.active_comBox.Items.Add("InActive");
            customerData.grp_comBox.Items.Clear();
            #region "CID_Txt & grp_comBox"
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select CID from Customer", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            int c = 0;
            while (dr.Read())
            {
                c++;
            }
            OleDbCommand cmd2 = new OleDbCommand("Select GrpName from CusGroup;", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                customerData.grp_comBox.Items.Add(dr2["GrpName"]);
            }
            cls.con.Close();
            customerData.CID_txt.Text = "CID-00" + (c + 1).ToString() + System.DateTime.Today.Year;
            #endregion
            customerData.customerDataPnl.Visible = true;
        }

        void update_btn_Click(object sender, EventArgs e)
        {
            customerfunc.customer_Pnl.Visible = false;
            customerdataupdate.CID_txt.Clear();
            customerdataupdate.cname_txt.Clear();
            customerdataupdate.caddress_txt.Clear();
            customerdataupdate.city_txt.Clear();
            customerdataupdate.ph1_txt.Clear();
            customerdataupdate.ph2_txt.Clear();
            customerdataupdate.cperson_txt.Clear();
            customerdataupdate.cph_txt.Clear();
            customerdataupdate.cemail_txt.Clear();
            customerdataupdate.creditlmt_txt.Clear();
            customerdataupdate.active_comBox.Items.Clear();
            customerdataupdate.active_comBox.Items.Add("Active");
            customerdataupdate.active_comBox.Items.Add("InActive");
            customerdataupdate.grp_comBox.Items.Clear();
            cls.con.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select GrpName from CusGroup;", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                customerdataupdate.grp_comBox.Items.Add(dr2["GrpName"]);
            }
            cls.con.Close();
            customerdataupdate.customerDataPnl.Visible = true;
        }
        #region "view_btn_Click"
        private void view_btn_Click(object sender, EventArgs e)
        {
            customerfunc.customer_Pnl.Visible = false;
            customerdataview.CID_txt.Clear();
            customerdataview.cname_txt.Clear();
            customerdataview.caddress_txt.Clear();
            customerdataview.city_txt.Clear();
            customerdataview.ph1_txt.Clear();
            customerdataview.ph2_txt.Clear();
            customerdataview.cperson_txt.Clear();
            customerdataview.cph_txt.Clear();
            customerdataview.cemail_txt.Clear();
            customerdataview.creditlmt_txt.Clear();
            customerdataview.active_comBox.Items.Clear();
            customerdataview.active_comBox.Items.Add("Active");
            customerdataview.active_comBox.Items.Add("InActive");
            customerdataview.grp_comBox.Items.Clear();
            customerdataview.customerDataPnl.Visible = true;
        }
        #endregion
        #endregion
        #region "VendorFunc"
        #region "addVendor"
        private void addVendor_Click(object sender, EventArgs e)
        {
            vendorfunc.customer_Pnl.Visible = false;
            customerData.CID_txt.Clear();
            customerData.cname_txt.Clear();
            customerData.caddress_txt.Clear();
            customerData.city_txt.Clear();
            customerData.ph1_txt.Clear();
            customerData.ph2_txt.Clear();
            customerData.cperson_txt.Clear();
            customerData.cph_txt.Clear();
            customerData.cemail_txt.Clear();
            customerData.creditlmt_txt.Clear();
            customerData.active_comBox.Items.Clear();
            customerData.active_comBox.Items.Add("Active");
            customerData.active_comBox.Items.Add("InActive");
            customerData.grp_comBox.Items.Clear();
            #region "CID_Txt & grp_comBox"
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select VID from Vendor", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            int c = 0;
            while (dr.Read())
            {
                c++;
            }
            OleDbCommand cmd2 = new OleDbCommand("Select GrpName from CusGroup;", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                vendordata.grp_comBox.Items.Add(dr2["GrpName"]);
            }
            cls.con.Close();
            vendordata.CID_txt.Text = "VID-00" + (c + 1).ToString() + System.DateTime.Today.Year;
            #endregion
            vendordata.customerDataPnl.Visible = true;
        }
            #endregion
        #region "updateVendor"
        private void updateVendor_Click(object sender, EventArgs e)
        {
            vendorfunc.customer_Pnl.Visible = false;
            vendordataupdate.CID_txt.Clear();
            vendordataupdate.cname_txt.Clear();
            vendordataupdate.caddress_txt.Clear();
            vendordataupdate.city_txt.Clear();
            vendordataupdate.ph1_txt.Clear();
            vendordataupdate.ph2_txt.Clear();
            vendordataupdate.cperson_txt.Clear();
            vendordataupdate.cph_txt.Clear();
            vendordataupdate.cemail_txt.Clear();
            vendordataupdate.creditlmt_txt.Clear();
            vendordataupdate.active_comBox.Items.Clear();
            vendordataupdate.active_comBox.Items.Add("Active");
            vendordataupdate.active_comBox.Items.Add("InActive");
            vendordataupdate.grp_comBox.Items.Clear();
            cls.con.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select GrpName from CusGroup;", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                vendordataupdate.grp_comBox.Items.Add(dr2["GrpName"]);
            }
            cls.con.Close();
            vendordataupdate.customerDataPnl.Visible = true;
        }
        #endregion
        #region "viewVendor"
        private void viewVendor_Click(object sender, EventArgs e)
        {
            vendorfunc.customer_Pnl.Visible = false;
            vendordataview.CID_txt.Clear();
            vendordataview.cname_txt.Clear();
            vendordataview.caddress_txt.Clear();
            vendordataview.city_txt.Clear();
            vendordataview.ph1_txt.Clear();
            vendordataview.ph2_txt.Clear();
            vendordataview.cperson_txt.Clear();
            vendordataview.cph_txt.Clear();
            vendordataview.cemail_txt.Clear();
            vendordataview.creditlmt_txt.Clear();
            vendordataview.active_comBox.Items.Clear();
            vendordataview.active_comBox.Items.Add("Active");
            vendordataview.active_comBox.Items.Add("InActive");
            vendordataview.grp_comBox.Items.Clear();
            vendordataview.customerDataPnl.Visible = true;
        }
        #endregion
        #endregion
        #region "PurchaseFunc"
        private void POAdd_Click(object sender, EventArgs e)
        {
            purchasefunc.customer_Pnl.Visible = false;
            purchaseorder.POID_txt.Clear();
            purchaseorder.VName_txt.Clear();
            purchaseorder.Vdpt_txt.Clear();
            purchaseorder.CPName_txt.Clear();
            purchaseorder.CPPH_txt.Clear();
            purchaseorder.PName_txt.Clear();
            purchaseorder.PPrice_txt.Clear();
            purchaseorder.PQuantity_txt.Clear();
            purchaseorder.Final_txt.Clear();
            purchaseorder.PODpt_comBox.Text = "Choose Department";
            purchaseorder.PODpt_comBox.Items.Clear();
            purchaseorder.VID_comBox.Text = "Choose Vendor ID";
            purchaseorder.VID_comBox.Items.Clear();
            purchaseorder.PModel_comBox.Text = "Choose Product Model";
            purchaseorder.PModel_comBox.Items.Clear();
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand("Select GrpName from CusGroup", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                purchaseorder.PODpt_comBox.Items.Add(dr["GrpName"]);
            }
            OleDbCommand cmd1 = new OleDbCommand("Select VID from Vendor", cls.con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                purchaseorder.VID_comBox.Items.Add(dr1["VID"]);
            }
            OleDbCommand cmd2 = new OleDbCommand("Select PModel from Products", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                purchaseorder.PModel_comBox.Items.Add(dr2["PModel"]);
            }
            cls.con.Close();
            purchaseorder.PO_Pnl.Visible = true;
        }
        #endregion
        #region "GRNFunc"
        private void GRNAdd_Click(object sender, EventArgs e)
        {
            grnfunc.customer_Pnl.Visible = false;
            grn.GRN_Pnl.Visible = true;
            grn.POID_comBox.Items.Clear();
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand("select POID from PO", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read()){
                grn.POID_comBox.Items.Add(dr["POID"]);
            }
            cls.con.Close();
        }
        #endregion
        #region "InvoiceFunc"
        private void InvoiceAdd_Click(object sender, EventArgs e)
        {
            invoicefunc.customer_Pnl.Visible = false;
            invoice.Invoice_Pnl.Visible = true;
            invoice.GRNID_comBox.Items.Clear();
            invoice.PayableAmount_txt.Clear();
            invoice.Deliver_txt.Clear();
            invoice.GRNDate_txt.Clear();
            invoice.VID_txt.Clear();
            invoice.VName_txt.Clear();
            invoice.PModel_txt.Clear();
            invoice.PQuantity_txt.Clear();
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand(@"Select GRNID from GRN",cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                invoice.GRNID_comBox.Items.Add(dr["GRNID"]);
            }
            cls.con.Close();
        }
        #endregion
        #region "SalesOrderFunc"
        private void salesAdd_Click(object sender, EventArgs e)
        {
            salesfunc.customer_Pnl.Visible = false;
            salesorder.PO_Pnl.Visible = true;
            salesorder.POID_txt.Clear();
            salesorder.VName_txt.Clear();
            salesorder.Vdpt_txt.Clear();
            salesorder.CPName_txt.Clear();
            salesorder.CPPH_txt.Clear();
            salesorder.PName_txt.Clear();
            salesorder.PPrice_txt.Clear();
            salesorder.PQuantity_txt.Clear();
            salesorder.Final_txt.Clear();
            salesorder.PODpt_comBox.Text = "Choose Department";
            salesorder.PODpt_comBox.Items.Clear();
            salesorder.VID_comBox.Text = "Choose Vendor ID";
            salesorder.VID_comBox.Items.Clear();
            salesorder.PModel_comBox.Text = "Choose Product Model";
            salesorder.PModel_comBox.Items.Clear();
            cls.con.Open();
            OleDbCommand cmd = new OleDbCommand("Select GrpName from CusGroup", cls.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                salesorder.PODpt_comBox.Items.Add(dr["GrpName"]);
            }
            OleDbCommand cmd1 = new OleDbCommand("Select VID from Vendor", cls.con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                salesorder.VID_comBox.Items.Add(dr1["VID"]);
            }
            OleDbCommand cmd2 = new OleDbCommand("Select PModel from Products", cls.con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                 salesorder.PModel_comBox.Items.Add(dr2["PModel"]);
            }
            cls.con.Close();
        }
        #endregion
    }   
}
