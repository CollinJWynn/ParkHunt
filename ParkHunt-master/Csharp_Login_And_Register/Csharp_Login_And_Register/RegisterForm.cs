using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Csharp_Login_And_Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if(fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstname.Text = "first name";
                textBoxFirstname.ForeColor = Color.Gray;
            }
        }
       
        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }


        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "last name";
                textBoxLastname.ForeColor = Color.Gray;
            }
        }

        private void textBoxLPNum_Enter(object sender, EventArgs e)
        {
            String lne = textBoxLPNum.Text;
            if (lne.ToLower().Trim().Equals("license plate number"))
            {
                textBoxLPNum.Text = "";
                textBoxLPNum.ForeColor = Color.Black;
            }
        }


        private void textBoxLPNum_Leave(object sender, EventArgs e)
        {
            String lne = textBoxLPNum.Text;
            if (lne.ToLower().Trim().Equals("license plate number") || lne.Trim().Equals(""))
            {
                textBoxLPNum.Text = "license plate number";
                textBoxLPNum.ForeColor = Color.Gray;
            }
        }


        private void textBoxStudentID_Enter(object sender, EventArgs e)
        {
            String ID = textBoxStudentID.Text;
            if (ID.ToLower().Trim().Equals("student id"))
            {
                textBoxStudentID.Text = "";
                textBoxStudentID.ForeColor = Color.Black;
            }
        }


        private void textBoxStudentID_Leave(object sender, EventArgs e)
        {
            String lol = textBoxStudentID.Text;
            if (lol.ToLower().Trim().Equals("student id") || lol.Trim().Equals(""))
            {
                textBoxStudentID.Text = "student id";
                textBoxStudentID.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email address";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxPhone_Enter(object sender, EventArgs e)
        {
            String phone = textBoxPhone.Text;
            if (phone.ToLower().Trim().Equals("phone number"))
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = Color.Black;
            }
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            String username = textBoxPhone.Text;
            if (username.ToLower().Trim().Equals("phone number") || username.Trim().Equals(""))
            {
                textBoxPhone.Text = "phone number";
                textBoxPhone.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                textBoxPasswordConfirm.Text = "confirm password";
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }


        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // add a new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `data`(`lastname`, `firstName`, `studentid`, `LicensePlateNumber`, `phone`, `email`, `password`) VALUES (@ln, @fn, @ID, @PlateNum, @phone, @email, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxStudentID.Text;
            command.Parameters.Add("@PlateNum", MySqlDbType.VarChar).Value = textBoxLPNum.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBoxPhone.Text;

            // open the connection
            db.openConnection();

            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if(textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One","Duplicate Username",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created","Account Created",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password","Password Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Enter Your Informations First","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            
            

            // close the connection
            db.closeConnection();

        }

        
        // check if the username already exists
        public Boolean checkUsername()
        {
            return false;

            DB db = new DB();

            String username = textBoxPhone.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

           MySqlCommand command = new MySqlCommand("SELECT * FROM `data` where username = " + username, db.getConnection());

            //command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // check if the textboxes contains the default values
        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxFirstname.Text;
            String lname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String uname = textBoxPhone.Text;
            String pass = textBoxPassword.Text;

            if(fname.Equals("first name") || lname.Equals("last name") || 
                email.Equals("email address") || uname.Equals("Phone#")
                || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void labelGoToLogin_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.Yellow;
        }

        private void labelGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.White;
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void textBoxFirstname_TextChanged(object sender, EventArgs e)
        {
            string name = textBoxFirstname.Text;
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]) || !Char.IsLetter(name[i]))
                {
                    textBoxFirstname.BackColor = System.Drawing.Color.Tomato;
                }
                else
                {
                    textBoxFirstname.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string num = textBoxPhone.Text;
            for (int i = 0; i < num.Length; i++)
            {
                if (!Char.IsDigit(num[i]))
                {
                    textBoxPhone.BackColor = System.Drawing.Color.Tomato;
                }
                else
                {
                    textBoxPhone.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        private void textBoxLPNum_TextChange(object sender, EventArgs e)
        {
          
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

            if ((textBoxEmail.Text.Contains("@snhu.edu")) || (textBoxEmail.Text.Contains("@gmail.com")))
            {
                textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                textBoxEmail.BackColor = System.Drawing.Color.Tomato;
            }
        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {
            string num = textBoxStudentID.Text;
            for (int i = 0; i < num.Length; i++)
            {
                if (!Char.IsDigit(num[i]))
                {
                    textBoxStudentID.BackColor = System.Drawing.Color.Tomato;
                }
            }
            if (num.Length != 7)
            {
                textBoxStudentID.BackColor = System.Drawing.Color.Tomato;
            }
            else
            {
                textBoxStudentID.BackColor = System.Drawing.SystemColors.Window;
            }
            
        }

        private void textBoxLastname_TextChanged(object sender, EventArgs e)
        {
            string name = textBoxLastname.Text;
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]) || !Char.IsLetter(name[i]))
                {
                    textBoxLastname.BackColor = System.Drawing.Color.Tomato;
                }
                else
                {
                    textBoxLastname.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        private void textBoxLPNum_TextChanged(object sender, EventArgs e)
        {
            string LP = textBoxLPNum.Text;
            if (LP.Length != 7)
            {
                textBoxLPNum.BackColor = System.Drawing.Color.Tomato;
            }
            else
            {
                textBoxLPNum.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
