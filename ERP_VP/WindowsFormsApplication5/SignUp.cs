using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public class SignUp:Login
    {
        #region "Initialize-Classes & Forms"
        #endregion
        #region "Declaration & Initialization"
        //Everything in CustomerData will be initialized here.
        #region "Panels"
        public Panel signup_Pnl = new Panel();
        #endregion
        #region "Labels"

        #endregion
        #region "TextBoxes"

        #endregion
        #region "ComboBoxes"

        #endregion
        #region "Buttons"
        public Button Signup_Btn = new Button();
        #endregion
        #region "GroupBoxes"

        #endregion
        #endregion
        public void signupData()
        {
            LoginForm();
            Login_Pnl.Visible = false;
            Login_lbl.Size = new Size (160, 30);
            Login_Pnl.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - Login_Pnl.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - Login_Pnl.Size.Height / 2);
            Login_lbl.Text = "Sign Up to Code-App";
            Log_Btn.Visible = false;
            Sign_Btn.Visible = false;
            or.Visible = false;
            #region "Signup_Btn"
            Signup_Btn.FlatStyle = FlatStyle.Flat;
            Signup_Btn.FlatAppearance.BorderSize = 0;
            Signup_Btn.Size = new Size(200, 40);
            Signup_Btn.Location = new Point(Login_Pnl.Width / 2 - Signup_Btn.Width / 2, 180);
            Signup_Btn.ForeColor = Color.White;
            Signup_Btn.Font = new Font("Arial", 9);
            Signup_Btn.Text = "Create Account";
            Signup_Btn.BackColor = Color.Gray;
            Signup_Btn.Click += Signup_Btn_Click;
            Signup_Btn.MouseHover += Signup_Btn_MouseHover;
            Login_Pnl.Controls.Add(Signup_Btn);
            #endregion
            #region "User_txt & Password_txt"
            User_txt.KeyPress += User_txt_KeyPress;
            Password_txt.KeyPress += Password_txt_KeyPress;
            #endregion
        }

        void Password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        void User_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar==(char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void Signup_Btn_MouseHover(object sender, EventArgs e)
        {
            Signup_Btn.Cursor = Cursors.Hand;
        }

        private void Signup_Btn_Click(object sender, EventArgs e)
        {
            if (!(User_txt.Text == "" && Password_txt.Text == ""))
            {
                cls.con.Open();
                OleDbCommand cmd = new OleDbCommand("select Username from Userdata", cls.con);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (!(User_txt.Text == dr["Username"].ToString()))
                    {
                        
                        OleDbCommand cmd1 = new OleDbCommand(@"insert into Userdata(Username, Password)values(@Username, @Password);", cls.con);
                        cmd1.Parameters.AddWithValue("@Username", User_txt.Text);
                        cmd1.Parameters.AddWithValue("@Password", Password_txt.Text);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Your account is created successfully, you must login first.");
                        cls.con.Close();
                    }
                    else
                    MessageBox.Show("Username already existed!");
                    cls.con.Close();
                }
            }
            else
                MessageBox.Show("Please insert username or password.");
            
        }
    }
}
