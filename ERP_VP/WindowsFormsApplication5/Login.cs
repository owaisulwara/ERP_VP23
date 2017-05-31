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

namespace WindowsFormsApplication5
{
    public class Login
    {
        #region "Initialize-Classes & Forms"
        SelectionPanel selectionpanel = new SelectionPanel();
        public Connection cls = new Connection();
        #endregion
        #region "Declaration & Initialization"
        //Everything in Login will be initialized here.
        #region "Panels"
        //Login form panel -->
        public Panel Login_Pnl = new Panel();
        //Login form panel <--
        #endregion
        #region "Labels"
        //Login form labels -->
        public Label Login_lbl = new Label();
        Label User_lbl = new Label();
        Label Password_lbl = new Label();
        Label About_lbl = new Label();
        public Label or = new Label();
        //Login form labels <--
        #endregion
        #region "TextBoxes"
        //Login form textboxes -->
        public TextBox User_txt = new TextBox();
        public TextBox Password_txt = new TextBox();
        //Login form textboxes <--
        #endregion
        #region "Buttons"
        //Login form buttons -->
        public Button Log_Btn = new Button();
        public Button Sign_Btn = new Button();
        //Login form buttons <--
        #endregion
        #endregion
        #region "Login_Form Styles"
        public void LoginForm()
        {
            cls.conString();
            #region "Login_Form"
            #region "Login_pnl"
            Login_Pnl.Size = new Size(400, 300);
            Login_Pnl.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - Login_Pnl.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - Login_Pnl.Size.Height / 2);
            Login_Pnl.BackColor = Color.White;
            Login_Pnl.Paint += Login_Pnl_Paint;
            
            #endregion

            #region "Login_lbl"
            Login_lbl.Size = new Size(150, 30);
            Login_lbl.Location = new Point(Login_Pnl.Width / 2 - Login_lbl.Width / 2, 20);
            Login_lbl.Text = "Log in to Code-App";
            Login_lbl.ForeColor = Color.Gray;
            Login_lbl.Font = new Font("Arial", 12);
            Login_Pnl.Controls.Add(Login_lbl);
            #endregion

            #region "User_lbl"
            User_lbl.Size = new Size(80, 20);
            User_lbl.Location = new Point(Login_Pnl.Width / 2 - User_lbl.Width / 2, 60);
            User_lbl.Text = "USERNAME";
            User_lbl.ForeColor = Color.Gray;
            User_lbl.Font = new Font("Arial", 9);
            Login_Pnl.Controls.Add(User_lbl);
            #endregion

            #region "User_txt"
            User_txt.Size = new Size(200, 20);
            User_txt.Location = new Point(Login_Pnl.Width / 2 - User_txt.Width / 2, 80);
            User_txt.ForeColor = Color.Gray;
            User_txt.Font = new Font("Arial", 9);
            Login_Pnl.Controls.Add(User_txt);
            #endregion

            #region "Password_lbl"
            Password_lbl.Size = new Size(80, 20);
            Password_lbl.Location = new Point(Login_Pnl.Width / 2 - Password_lbl.Width / 2, 120);
            Password_lbl.Text = "PASSWORD";
            Password_lbl.ForeColor = Color.Gray;
            Password_lbl.Font = new Font("Arial", 9);
            Login_Pnl.Controls.Add(Password_lbl);
            #endregion

            #region "User_txt"
            Password_txt.Size = new Size(200, 20);
            Password_txt.Location = new Point(Login_Pnl.Width / 2 - Password_txt.Width / 2, 140);
            Password_txt.ForeColor = Color.Gray;
            Password_txt.Font = new Font("Arial", 9);
            Password_txt.PasswordChar = '*';
            Login_Pnl.Controls.Add(Password_txt);
            #endregion

            #region "Log_Btn"
            Log_Btn.FlatStyle = FlatStyle.Flat;
            Log_Btn.FlatAppearance.BorderSize = 0;
            Log_Btn.Size = new Size(200, 22);
            Log_Btn.Location = new Point(Login_Pnl.Width / 2 - Log_Btn.Width / 2, 180);
            Log_Btn.ForeColor = Color.White;
            Log_Btn.Font = new Font("Arial", 9);
            Log_Btn.Text = "LOG IN";
            Log_Btn.BackColor = Color.Gray;
            Log_Btn.MouseHover += Log_Btn_MouseHover;
            Login_Pnl.Controls.Add(Log_Btn);
            #endregion

            #region "or"
            or.Size = new Size(12, 10);
            or.Location = new Point(Login_Pnl.Size.Width / 2 - or.Size.Width / 2, 205);
            or.Text = "or";
            or.ForeColor = Color.Gray;
            or.Font = new Font("Arial", 6);
            Login_Pnl.Controls.Add(or);
            #endregion

            #region "Sign_Btn"
            Sign_Btn.FlatStyle = FlatStyle.Flat;
            Sign_Btn.FlatAppearance.BorderSize = 0;
            Sign_Btn.Size = new Size(200, 22);
            Sign_Btn.Location = new Point(Login_Pnl.Width / 2 - Sign_Btn.Width / 2, 220);
            Sign_Btn.ForeColor = Color.White;
            Sign_Btn.Font = new Font("Arial", 9);
            Sign_Btn.Text = "SIGN UP";
            Sign_Btn.BackColor = Color.Gray;
            Sign_Btn.Click += Sign_Btn_Click;
            Sign_Btn.MouseHover += Sign_Btn_MouseHover;
            Login_Pnl.Controls.Add(Sign_Btn);
            #endregion

            #region "About_lbl"
            About_lbl.Size = new Size(90, 10);
            About_lbl.Location = new Point(300, 280);
            About_lbl.Text = "Created by Owais ul wara";
            About_lbl.ForeColor = Color.DarkGray;
            About_lbl.Font = new Font("Arial", 6);
            Login_Pnl.Controls.Add(About_lbl);
            #endregion
            #endregion
        }
        #endregion
        #region "Login Form Functions"
        void Sign_Btn_MouseHover(object sender, EventArgs e)
        {
            Sign_Btn.Cursor = Cursors.Hand;
        }

        void Log_Btn_MouseHover(object sender, EventArgs e)
        {
            Log_Btn.Cursor = Cursors.Hand;
        }
        void Sign_Btn_Click(object sender, EventArgs e)
        {
            Login_Pnl.Visible = false;
            
        }

        void Login_Pnl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Login_Pnl.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            Rectangle r = new Rectangle();
            r.Size = new Size(390,290);
            r.Location = new Point(Login_Pnl.Size.Width/2 - r.Size.Width/2, Login_Pnl.Size.Height/2 - r.Size.Height/2 );
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(p,r);
            Pen p1 = new Pen(Color.Gray);
            p1.Width = 1;
            g.DrawLine(p1, 100, 210, 180, 210);
            g.DrawLine(p1, 220, 210, 299, 210);
 
        }
        #endregion
    }
}
