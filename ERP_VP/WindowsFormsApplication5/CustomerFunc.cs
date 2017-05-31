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
    public class CustomerFunc
    {
        #region "Initialize-Classes & Forms"
        #endregion
        #region "Declaration & Initialization"
        //Everything in CustomerFunc will be initialized here.
        #region "Panels"
        public Panel customer_Pnl = new Panel();
        #endregion
        #region "Labels"
        public Label CustomerData_lbl = new Label();
        #endregion
        #region "TextBoxes"

        #endregion
        #region "Buttons"
        public Button insert_btn = new Button();
        public Button update_btn = new Button();
        public Button view_btn = new Button();
        #endregion
        #endregion

        public void customerFunc()
        {
            #region "customer_Pnl Styles"
            customer_Pnl.Dock = DockStyle.Fill;
            customer_Pnl.BackColor = Color.MintCream;
            customer_Pnl.Visible = false;
            #endregion
            #region "CustomerData_lbl"
            CustomerData_lbl.Size = new Size(260, 35);
            CustomerData_lbl.Location = new Point(500, 160);
            CustomerData_lbl.ForeColor = Color.Gray;
            CustomerData_lbl.Font = new Font("Arial", 25, FontStyle.Bold);
            CustomerData_lbl.Text = "Customer Data";
            customer_Pnl.Controls.Add(CustomerData_lbl);
            #endregion

            #region "insert_btn"
            insert_btn.Size = new Size(300, 35);
            insert_btn.Location = new Point(CustomerData_lbl.Location.X + ((CustomerData_lbl.Size.Width / 2) - insert_btn.Size.Width / 2), 250);
            insert_btn.BackColor = Color.DeepSkyBlue;
            insert_btn.ForeColor = Color.White;
            insert_btn.FlatStyle = FlatStyle.Flat;
            insert_btn.FlatAppearance.BorderSize = 0;
            insert_btn.Font = new Font("Arial", 10, FontStyle.Bold);
            insert_btn.Text = "Add Customer Data";
            insert_btn.MouseHover += insert_btn_MouseHover;
            customer_Pnl.Controls.Add(insert_btn);
            #endregion
            #region "update_btn"
            update_btn.Size = new Size(300, 35);
            update_btn.Location = new Point(CustomerData_lbl.Location.X + ((CustomerData_lbl.Size.Width / 2) - update_btn.Size.Width / 2), 295);
            update_btn.BackColor = Color.DeepSkyBlue;
            update_btn.ForeColor = Color.White;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.Font = new Font("Arial", 10, FontStyle.Bold);
            update_btn.Text = "Update Customer Data";
            update_btn.MouseHover += update_btn_MouseHover;
            customer_Pnl.Controls.Add(update_btn);
            #endregion
            #region "delete_btn"
            view_btn.Size = new Size(300, 35);
            view_btn.Location = new Point(CustomerData_lbl.Location.X + ((CustomerData_lbl.Size.Width / 2) - view_btn.Size.Width / 2), 340);
            view_btn.BackColor = Color.DeepSkyBlue;
            view_btn.ForeColor = Color.White;
            view_btn.FlatStyle = FlatStyle.Flat;
            view_btn.FlatAppearance.BorderSize = 0;
            view_btn.Font = new Font("Arial", 10, FontStyle.Bold);
            view_btn.Text = "View Customer Data";
            view_btn.MouseHover += view_btn_MouseHover;
            customer_Pnl.Controls.Add(view_btn);
            #endregion

        }

        private void view_btn_MouseHover(object sender, EventArgs e)
        {
            view_btn.Cursor = Cursors.Hand;
        }

        private void update_btn_MouseHover(object sender, EventArgs e)
        {
            update_btn.Cursor = Cursors.Hand;
        }

        private void insert_btn_MouseHover(object sender, EventArgs e)
        {
            insert_btn.Cursor = Cursors.Hand;
        }
    }
}
