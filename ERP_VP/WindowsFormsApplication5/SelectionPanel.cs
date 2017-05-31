using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public class SelectionPanel
    {
        #region "Initialize-Classes & Forms"
        #endregion
        #region "Declaration & Initialization"
        //Everything in Login will be initialized here.
        #region "Panels"
        //Selection panels -->
        public Panel selection_Pnl = new Panel();
        //Selection panels -->
        #endregion
        #region "Labels"
        //Selection_Pnl Labels Start
        Label module_lbl = new Label();
        //Selection_Pnl Labels end

        //Customer_Pnl Labels Start
        //Customer Data -->
        Label CustomerData_lbl = new Label();
        //Customer Data <--

        //Admin Labels -->
        Label admin_lbl = new Label();
        //Admin Labels <--
        #endregion
        #region "TextBoxes"

        #endregion
        #region "Buttons"
        //selection_Pnl buttons -->
        public Button admin_Btn = new Button();
        public Button customer_Btn = new Button();
        public Button vendor_Btn = new Button();
        public Button purchase_Btn = new Button();
        public Button GRN_Btn = new Button();
        public Button Invoice_Btn = new Button();
        public Button Sales_Btn = new Button();
        public Button SDN_Btn = new Button();
        public Button SOInvoice_Btn = new Button();
        //selection_Pnl buttons <--
        #endregion
        #endregion

        #region "Selection Panel Properties"
        public void selectionPanel()
        {
            #region "selection_Pnl"
            selection_Pnl.Visible = false;
            selection_Pnl.Size = new Size(250, 900-35);
            selection_Pnl.Location = new Point(0 , 35);
            selection_Pnl.BackColor = Color.FromArgb(10, 11, 24);
            selection_Pnl.Paint += selection_Pnl_Paint;
            #endregion
            #region "module_lbl"
            module_lbl.Size = new Size(90, 20);
            module_lbl.Location = new Point((selection_Pnl.Size.Width / 2) - (module_lbl.Size.Width / 2), 35);
            module_lbl.Text = "Modules";
            module_lbl.Font = new Font("Arial", 15, FontStyle.Bold);
            module_lbl.ForeColor = Color.CornflowerBlue;
            selection_Pnl.Controls.Add(module_lbl);
            #endregion
            #region "admin_Btn"
            admin_Btn.Size = new Size(250, 25);
            admin_Btn.TextAlign = ContentAlignment.MiddleLeft;
            admin_Btn.Padding = new Padding(15, 0, 0, 0);
            admin_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            admin_Btn.FlatAppearance.BorderSize = 0;
            admin_Btn.Location = new Point(0, 95);
            admin_Btn.FlatStyle = FlatStyle.Flat;
            admin_Btn.BackColor = Color.Transparent;
            admin_Btn.ForeColor = Color.White;
            admin_Btn.Text = "> Administrator";
            admin_Btn.MouseEnter += admin_Btn_MouseEnter;
            admin_Btn.MouseLeave += admin_Btn_MouseLeave;
            selection_Pnl.Controls.Add(admin_Btn);
            #endregion
            #region "cutomer_Btn"
            customer_Btn.Size = new Size(250, 25);
            customer_Btn.Padding = new Padding(15, 0, 0, 0);
            customer_Btn.TextAlign = ContentAlignment.MiddleLeft;
            customer_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            customer_Btn.FlatAppearance.BorderSize = 0;
            customer_Btn.Location = new Point(0, admin_Btn.Location.Y+30 );
            customer_Btn.FlatStyle = FlatStyle.Flat;
            customer_Btn.BackColor = Color.Transparent;
            customer_Btn.ForeColor = Color.White;
            customer_Btn.Text = "> Customer";
            customer_Btn.MouseEnter += customer_Btn_MouseEnter;
            customer_Btn.MouseLeave += customer_Btn_MouseLeave;
            selection_Pnl.Controls.Add(customer_Btn);
            #endregion
            #region "vendor_Btn"
            vendor_Btn.Size = new Size(250, 25);
            vendor_Btn.Padding = new Padding(15, 0, 0, 0);
            vendor_Btn.TextAlign = ContentAlignment.MiddleLeft;
            vendor_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            vendor_Btn.FlatAppearance.BorderSize = 0;
            vendor_Btn.Location = new Point(0, customer_Btn.Location.Y+30);
            vendor_Btn.FlatStyle = FlatStyle.Flat;
            vendor_Btn.BackColor = Color.Transparent;
            vendor_Btn.ForeColor = Color.White;
            vendor_Btn.Text = "> Vendor";
            vendor_Btn.MouseEnter += vendor_Btn_MouseEnter;
            vendor_Btn.MouseLeave += vendor_Btn_MouseLeave;
            selection_Pnl.Controls.Add(vendor_Btn);
            #endregion
            #region "purchase_Btn"
            purchase_Btn.Size = new Size(250, 25);
            purchase_Btn.Padding = new Padding(15, 0, 0, 0);
            purchase_Btn.TextAlign = ContentAlignment.MiddleLeft;
            purchase_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            purchase_Btn.FlatAppearance.BorderSize = 0;
            purchase_Btn.Location = new Point(0, vendor_Btn.Location.Y+30);
            purchase_Btn.FlatStyle = FlatStyle.Flat;
            purchase_Btn.BackColor = Color.Transparent;
            purchase_Btn.ForeColor = Color.White;
            purchase_Btn.Text = "> Purchase Order";
            purchase_Btn.MouseEnter += purchase_Btn_MouseEnter;
            purchase_Btn.MouseLeave += purchase_Btn_MouseLeave;
            selection_Pnl.Controls.Add(purchase_Btn);
            #endregion
            #region "GRN_Btn"
            GRN_Btn.Size = new Size(250, 25);
            GRN_Btn.Padding = new Padding(15, 0, 0, 0);
            GRN_Btn.TextAlign = ContentAlignment.MiddleLeft;
            GRN_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            GRN_Btn.FlatAppearance.BorderSize = 0;
            GRN_Btn.Location = new Point(0, purchase_Btn.Location.Y + 30);
            GRN_Btn.FlatStyle = FlatStyle.Flat;
            GRN_Btn.BackColor = Color.Transparent;
            GRN_Btn.ForeColor = Color.White;
            GRN_Btn.Text = "> GRN Creation";
            GRN_Btn.MouseEnter += GRN_Btn_MouseEnter;
            GRN_Btn.MouseLeave += GRN_Btn_MouseLeave;
            selection_Pnl.Controls.Add(GRN_Btn);
            #endregion
            #region "Invoice_Btn"
            Invoice_Btn.Size = new Size(250, 25);
            Invoice_Btn.Padding = new Padding(15, 0, 0, 0);
            Invoice_Btn.TextAlign = ContentAlignment.MiddleLeft;
            Invoice_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            Invoice_Btn.FlatAppearance.BorderSize = 0;
            Invoice_Btn.Location = new Point(0, GRN_Btn.Location.Y + 30);
            Invoice_Btn.FlatStyle = FlatStyle.Flat;
            Invoice_Btn.BackColor = Color.Transparent;
            Invoice_Btn.ForeColor = Color.White;
            Invoice_Btn.Text = "> Invoice Creation";
            Invoice_Btn.MouseEnter += Invoice_Btn_MouseEnter;
            Invoice_Btn.MouseLeave += Invoice_Btn_MouseLeave;
            selection_Pnl.Controls.Add(Invoice_Btn);
            #endregion
            #region "Sales_Btn"
            Sales_Btn.Size = new Size(250, 25);
            Sales_Btn.Padding = new Padding(15, 0, 0, 0);
            Sales_Btn.TextAlign = ContentAlignment.MiddleLeft;
            Sales_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            Sales_Btn.FlatAppearance.BorderSize = 0;
            Sales_Btn.Location = new Point(0, Invoice_Btn.Location.Y + 30);
            Sales_Btn.FlatStyle = FlatStyle.Flat;
            Sales_Btn.BackColor = Color.Transparent;
            Sales_Btn.ForeColor = Color.White;
            Sales_Btn.Text = "> Sales Order";
            Sales_Btn.MouseEnter += Sales_Btn_MouseEnter;
            Sales_Btn.MouseLeave += Sales_Btn_MouseLeave;
            selection_Pnl.Controls.Add(Sales_Btn);
            #endregion
            #region "SDN_Btn"
            SDN_Btn.Size = new Size(250, 25);
            SDN_Btn.Padding = new Padding(15, 0, 0, 0);
            SDN_Btn.TextAlign = ContentAlignment.MiddleLeft;
            SDN_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            SDN_Btn.FlatAppearance.BorderSize = 0;
            SDN_Btn.Location = new Point(0, Sales_Btn.Location.Y + 30);
            SDN_Btn.FlatStyle = FlatStyle.Flat;
            SDN_Btn.BackColor = Color.Transparent;
            SDN_Btn.ForeColor = Color.White;
            SDN_Btn.Text = "> SDN Creation";
            SDN_Btn.MouseEnter += SDN_Btn_MouseEnter;
            SDN_Btn.MouseLeave += SDN_Btn_MouseLeave;
            selection_Pnl.Controls.Add(SDN_Btn);
            #endregion
            #region "SOInvoice_Btn"
            SOInvoice_Btn.Size = new Size(250, 25);
            SOInvoice_Btn.Padding = new Padding(15, 0, 0, 0);
            SOInvoice_Btn.TextAlign = ContentAlignment.MiddleLeft;
            SOInvoice_Btn.Font = new Font("Arial", 10, FontStyle.Regular);
            SOInvoice_Btn.FlatAppearance.BorderSize = 0;
            SOInvoice_Btn.Location = new Point(0, SDN_Btn.Location.Y + 30);
            SOInvoice_Btn.FlatStyle = FlatStyle.Flat;
            SOInvoice_Btn.BackColor = Color.Transparent;
            SOInvoice_Btn.ForeColor = Color.White;
            SOInvoice_Btn.Text = "> SOInvoice Creation";
            SOInvoice_Btn.MouseEnter += SOInvoice_Btn_MouseEnter;
            SOInvoice_Btn.MouseLeave += SOInvoice_Btn_MouseLeave;
            selection_Pnl.Controls.Add(SOInvoice_Btn);
            #endregion
        }

        

        

        #region "Selection_pnl Functions"
        private void SOInvoice_Btn_MouseLeave(object sender, EventArgs e)
        {
            SOInvoice_Btn.BackColor = Color.Transparent;
            SOInvoice_Btn.ForeColor = Color.White;
        }

        private void SOInvoice_Btn_MouseEnter(object sender, EventArgs e)
        {
            SOInvoice_Btn.BackColor = Color.White;
            SOInvoice_Btn.ForeColor = Color.CornflowerBlue;
            SOInvoice_Btn.Cursor = Cursors.Hand;
        }
        private void SDN_Btn_MouseLeave(object sender, EventArgs e)
        {
            SDN_Btn.BackColor = Color.Transparent;
            SDN_Btn.ForeColor = Color.White;
        }

        private void SDN_Btn_MouseEnter(object sender, EventArgs e)
        {
            SDN_Btn.BackColor = Color.White;
            SDN_Btn.ForeColor = Color.CornflowerBlue;
            SDN_Btn.Cursor = Cursors.Hand;
        }
        private void Sales_Btn_MouseLeave(object sender, EventArgs e)
        {
            Sales_Btn.BackColor = Color.Transparent;
            Sales_Btn.ForeColor = Color.White;
        }

        private void Sales_Btn_MouseEnter(object sender, EventArgs e)
        {
            Sales_Btn.BackColor = Color.White;
            Sales_Btn.ForeColor = Color.CornflowerBlue;
            Sales_Btn.Cursor = Cursors.Hand;
        }
        private void Invoice_Btn_MouseLeave(object sender, EventArgs e)
        {
            Invoice_Btn.BackColor = Color.Transparent;
            Invoice_Btn.ForeColor = Color.White;
        }

        private void Invoice_Btn_MouseEnter(object sender, EventArgs e)
        {
            Invoice_Btn.BackColor = Color.White;
            Invoice_Btn.ForeColor = Color.CornflowerBlue;
            Invoice_Btn.Cursor = Cursors.Hand;
        }
        private void vendor_Btn_MouseLeave(object sender, EventArgs e)
        {
            vendor_Btn.BackColor = Color.Transparent;
            vendor_Btn.ForeColor = Color.White;
        }

        private void vendor_Btn_MouseEnter(object sender, EventArgs e)
        {
            vendor_Btn.BackColor = Color.White;
            vendor_Btn.ForeColor = Color.CornflowerBlue;
            vendor_Btn.Cursor = Cursors.Hand;
        }

        private void purchase_Btn_MouseLeave(object sender, EventArgs e)
        {
            purchase_Btn.BackColor = Color.Transparent;
            purchase_Btn.ForeColor = Color.White;
        }

        private void purchase_Btn_MouseEnter(object sender, EventArgs e)
        {
            purchase_Btn.BackColor = Color.White;
            purchase_Btn.ForeColor = Color.CornflowerBlue;
            purchase_Btn.Cursor = Cursors.Hand;
        }
        private void GRN_Btn_MouseLeave(object sender, EventArgs e)
        {
            GRN_Btn.BackColor = Color.Transparent;
            GRN_Btn.ForeColor = Color.White;
        }

        private void GRN_Btn_MouseEnter(object sender, EventArgs e)
        {
            GRN_Btn.BackColor = Color.White;
            GRN_Btn.ForeColor = Color.CornflowerBlue;
            GRN_Btn.Cursor = Cursors.Hand;
        }

        private void admin_Btn_MouseLeave(object sender, EventArgs e)
        {
            admin_Btn.BackColor = Color.Transparent;
            admin_Btn.ForeColor = Color.White;
        }

        private void admin_Btn_MouseEnter(object sender, EventArgs e)
        {
            admin_Btn.BackColor = Color.White;
            admin_Btn.ForeColor = Color.CornflowerBlue;
            admin_Btn.Cursor = Cursors.Hand;
        }


        void customer_Btn_MouseLeave(object sender, EventArgs e)
        {
            customer_Btn.BackColor = Color.Transparent;
            customer_Btn.ForeColor = Color.White;
        }

        void customer_Btn_MouseEnter(object sender, EventArgs e)
        {
            customer_Btn.BackColor = Color.White;
            customer_Btn.ForeColor = Color.CornflowerBlue;
            customer_Btn.Cursor = Cursors.Hand;
        }


        void selection_Pnl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = selection_Pnl.CreateGraphics();
            Pen p = new Pen(Color.DarkBlue);
            p.Width = 1;
            g.DrawLine(p, 10, 85, 240, 85);
        }
        #endregion
        #endregion
    }
}
