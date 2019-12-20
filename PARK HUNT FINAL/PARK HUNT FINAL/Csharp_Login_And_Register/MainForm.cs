using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Csharp_Login_And_Register
{
    
    public partial class MainForm : Form
    {
        public string curr;
        public MainForm(string email)
        {
            InitializeComponent();
            label1.Text = email;
            Aback.Hide();
            Bback.Hide();
            Cback.Hide();
            Dback.Hide();

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM data WHERE currentlot = 'A'", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LotAAvailable.Text = reader.GetValue(0).ToString() + "/56";
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            int a = Int32.Parse(String.Concat(LotAAvailable.Text.TakeWhile(c => c != '/')));
            if (a >= 0)
            {
                LotAAvailable.BackColor = Color.GreenYellow;
            }
            if (a > 28)
            {
                LotAAvailable.BackColor = Color.Orange;
            }
            if (a > 55)
            {
                LotAAvailable.BackColor = Color.Red;
            }
            MySqlCommand bruh = new MySqlCommand("SELECT count(*) FROM data WHERE currentlot = 'B'", db.getConnection());
            db.openConnection();
            MySqlDataReader read = bruh.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    lotBAvailable.Text = read.GetValue(0).ToString() + "/42";
                }
            }
            else
            {
                lotBAvailable.Text = "Empty";
            }
            read.Close();
            int b = Int32.Parse(String.Concat(lotBAvailable.Text.TakeWhile(c => c != '/')));
            if (b >= 0)
            {
                lotBAvailable.BackColor = Color.GreenYellow;
            }
            if (b > 21)
            {
                lotBAvailable.BackColor = Color.Orange;
            }
            if (b > 41)
            {
                lotBAvailable.BackColor = Color.Red;
            }
            MySqlCommand ay = new MySqlCommand("SELECT count(*) FROM data WHERE currentlot = 'C'", db.getConnection());
            db.openConnection();
            MySqlDataReader ree = ay.ExecuteReader();
            if (ree.HasRows)
            {
                while (ree.Read())
                {
                    lotCAvailable.Text = ree.GetValue(0).ToString() + "/35";
                }
            }
            else
            {
                lotCAvailable.Text = "Empty";
            }
            ree.Close();
            int d = Int32.Parse(String.Concat(lotCAvailable.Text.TakeWhile(c => c != '/')));
            if (d >= 0)
            {
                lotCAvailable.BackColor = Color.GreenYellow;
            }
            if (d > 20)
            {
                lotCAvailable.BackColor = Color.Orange;
            }
            if (d > 34)
            {
                lotCAvailable.BackColor = Color.Red;
            }
            MySqlCommand yuh = new MySqlCommand("SELECT count(*) FROM data WHERE currentlot = 'D'", db.getConnection());
            db.openConnection();
            MySqlDataReader duh = yuh.ExecuteReader();
            if (duh.HasRows)
            {
                while (duh.Read())
                {
                    lotDAvailable.Text = duh.GetValue(0).ToString() + "/38";
                }
            }
            else
            {
                lotDAvailable.Text = "Empty";
            }
            duh.Close();
            int u = Int32.Parse(String.Concat(lotDAvailable.Text.TakeWhile(c => c != '/')));
            if (u >= 0)
            {
                lotDAvailable.BackColor = Color.GreenYellow;
            }
            if (u > 18)
            {
                lotDAvailable.BackColor = Color.Orange;
            }
            if (u > 37)
            {
                lotDAvailable.BackColor = Color.Red;
            }

            MySqlCommand lmao = new MySqlCommand("SELECT currentlot FROM data WHERE email = @email", db.getConnection());
            lmao.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            db.openConnection();
            MySqlDataReader red = lmao.ExecuteReader();
            if (red.HasRows)
            {
                while (red.Read())
                {
                    if(red.GetValue(0).ToString() == "A")
                    {
                        Aback.Show();
                        curr = "A";
                    }
                    if (red.GetValue(0).ToString() == "B")
                    {
                        Bback.Show();
                        curr = "B";
                    }
                    if (red.GetValue(0).ToString() == "C")
                    {
                        Cback.Show();
                        curr = "C";
                    }
                    if (red.GetValue(0).ToString() == "D")
                    {
                        Dback.Show();
                        curr = "D";
                    }
                }
            }
            red.Close();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LotALabel_Click(object sender, EventArgs e)
        {
            string email = label1.Text;
            DB db = new DB();



            MySqlConnection connect = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = "SELECT count(*) FROM data WHERE currentlot = 'A' and email = @email;";

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((Int32.Parse(reader.GetValue(0).ToString())) == 1)
                    {
                        Aback.Hide();
                        int d = Int32.Parse(String.Concat(LotAAvailable.Text.TakeWhile(c => c != '/')));
                        --d;
                        LotAAvailable.Text = d.ToString() + "/56";
                        MySqlConnection connection = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        connection.Open();
                        MySqlCommand hello = new MySqlCommand();
                        hello.Connection = connection;
                        hello.CommandText = "Update data Set currentlot = Null where email = @email;";

                        hello.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        hello.ExecuteNonQuery();
                        connection.Close();
                    }
                    else if ((Int32.Parse(reader.GetValue(0).ToString())) == 0)
                    {
                        
                        int r = Int32.Parse(String.Concat(LotAAvailable.Text.TakeWhile(c => c != '/')));
                        ++r;
                        if (r > 56)
                        {
                            break;
                        }
                        Aback.Show();
                        Bback.Hide();
                        Cback.Hide();
                        Dback.Hide();
                        LotAAvailable.Text = r.ToString() + "/56";
                        MySqlConnection cnn = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        cnn.Open();
                        MySqlCommand bye = new MySqlCommand();
                        bye.Connection = cnn;
                        bye.CommandText = "Update data Set currentlot = 'A' where email = @email;";
                        bye.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        bye.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }

            reader.Close();
            connect.Close();
            int a = Int32.Parse(String.Concat(LotAAvailable.Text.TakeWhile(c => c != '/')));

            if (a > 0)
            {
                LotAAvailable.BackColor = Color.GreenYellow;
            }
            if (a > 21)
            {
                LotAAvailable.BackColor = Color.Yellow;
            }
            if (a > 37)
            {
                LotAAvailable.BackColor = Color.Orange;
            }
            if (a == 56)
            {
                LotAAvailable.BackColor = Color.Red;
            }
        }

        private void lotBLabel_Click(object sender, EventArgs e)
        {
            string email = label1.Text;
            DB db = new DB();
            
            

            MySqlConnection connect = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = "SELECT count(*) FROM data WHERE currentlot = 'B' and email = @email;";

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((Int32.Parse(reader.GetValue(0).ToString())) == 1)
                    {
                        Bback.Hide();
                        int d = Int32.Parse(String.Concat(lotBAvailable.Text.TakeWhile(c => c != '/')));
                        --d;
                        lotBAvailable.Text = d.ToString() + "/42";
                        MySqlConnection connection = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        connection.Open();
                        MySqlCommand hello = new MySqlCommand();
                        hello.Connection = connection;
                        hello.CommandText = "Update data Set currentlot = Null where email = @email;";

                        hello.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        hello.ExecuteNonQuery();
                        connection.Close();
                    }
                    else if((Int32.Parse(reader.GetValue(0).ToString())) == 0)
                    {
                        
                        int r = Int32.Parse(String.Concat(lotBAvailable.Text.TakeWhile(c => c != '/')));
                        ++r;
                        if (r > 42)
                        {
                            break;
                        }
                        Bback.Show();
                        Aback.Hide();
                        Cback.Hide();
                        Dback.Hide();
                        lotBAvailable.Text = r.ToString() + "/42";
                        MySqlConnection cnn = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        cnn.Open();
                        MySqlCommand bye = new MySqlCommand();
                        bye.Connection = cnn;
                        bye.CommandText = "Update data Set currentlot = 'B' where email = @email;";
                        bye.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        bye.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }

            reader.Close();
            connect.Close();
            int a = Int32.Parse(String.Concat(lotBAvailable.Text.TakeWhile(c => c != '/')));

            if (a > 0)
            {
                lotBAvailable.BackColor = Color.GreenYellow;
            }
            if (a > 21)
            {
                lotBAvailable.BackColor = Color.Orange;
            }
            if (a > 41)
            {
                lotBAvailable.BackColor = Color.Red;
            }
        }



        private void lotCLabel_Click(object sender, EventArgs e)
        {
            string email = label1.Text;
            DB db = new DB();



            MySqlConnection connect = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = "SELECT count(*) FROM data WHERE currentlot = 'C' and email = @email;";

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((Int32.Parse(reader.GetValue(0).ToString())) == 1)
                    {
                        Cback.Hide();
                        int d = Int32.Parse(String.Concat(lotCAvailable.Text.TakeWhile(c => c != '/')));

                        --d;
                        lotCAvailable.Text = d.ToString() + "/35";
                        MySqlConnection connection = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        connection.Open();
                        MySqlCommand hello = new MySqlCommand();
                        hello.Connection = connection;
                        hello.CommandText = "Update data Set currentlot = Null where email = @email;";
                        hello.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        hello.ExecuteNonQuery();
                        connection.Close();
                    }
                    if ((Int32.Parse(reader.GetValue(0).ToString())) == 0)
                    {
                        
                        int r = Int32.Parse(String.Concat(lotCAvailable.Text.TakeWhile(c => c != '/')));
                        ++r;
                        if (r > 35)
                        {
                            break;
                        }
                        Cback.Show();
                        Aback.Hide();
                        Bback.Hide();
                        Dback.Hide();
                        lotCAvailable.Text = r.ToString() + "/35";
                        MySqlConnection cnn = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        cnn.Open();
                        MySqlCommand bye = new MySqlCommand();
                        bye.Connection = cnn;
                        bye.CommandText = "Update data Set currentlot = 'C' where email = @email;";
                        bye.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        bye.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }

            reader.Close();
            connect.Close();
            int a = Int32.Parse(String.Concat(lotCAvailable.Text.TakeWhile(c => c != '/')));

            if (a > 0)
            {
                lotCAvailable.BackColor = Color.GreenYellow;
            }
            if (a > 18)
            {
                lotCAvailable.BackColor = Color.Orange;
            }
            if (a > 34)
            {
                lotCAvailable.BackColor = Color.Red;
            }
        }



        private void lotDLabel_Click(object sender, EventArgs e)
        {
            string email = label1.Text;
            DB db = new DB();



            MySqlConnection connect = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = "SELECT count(*) FROM data WHERE currentlot = 'D' and email = @email;";

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((Int32.Parse(reader.GetValue(0).ToString())) == 1)
                    {
                        Dback.Hide();
                        int d = Int32.Parse(String.Concat(lotDAvailable.Text.TakeWhile(c => c != '/')));

                        --d;
                        lotDAvailable.Text = d.ToString() + "/38";
                        MySqlConnection connection = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        connection.Open();
                        MySqlCommand hello = new MySqlCommand();
                        hello.Connection = connection;
                        hello.CommandText = "Update data Set currentlot = Null where email = @email;";
                        hello.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        hello.ExecuteNonQuery();
                        connection.Close();
                    }
                    if ((Int32.Parse(reader.GetValue(0).ToString())) == 0)
                    {
                        
                        int r = Int32.Parse(String.Concat(lotDAvailable.Text.TakeWhile(c => c != '/')));
                        ++r;
                        if (r > 38)
                        {
                            break;
                        }
                        Dback.Show();
                        Aback.Hide();
                        Bback.Hide();
                        Cback.Hide();
                        lotDAvailable.Text = r.ToString() + "/38";
                        MySqlConnection cnn = new MySqlConnection("server=localhost;username = root;password=123CjW123*();database=parkhunt");
                        cnn.Open();
                        MySqlCommand bye = new MySqlCommand();
                        bye.Connection = cnn;
                        bye.CommandText = "Update data Set currentlot = 'D' where email = @email;";
                        bye.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        bye.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }

            reader.Close();
            connect.Close();
            int a = Int32.Parse(String.Concat(lotDAvailable.Text.TakeWhile(c => c != '/')));

            if (a > 0)
            {
                lotDAvailable.BackColor = Color.GreenYellow;
            }
            if (a > 5)
            {
                lotDAvailable.BackColor = Color.Orange;
            }
            if (a > 10)
            {
                lotDAvailable.BackColor = Color.Red;
            }
        }





        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = label1.Text;
            this.Hide();
            MapForm mapForm = new MapForm(email);
            mapForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Show();
        }
    }
    
}
