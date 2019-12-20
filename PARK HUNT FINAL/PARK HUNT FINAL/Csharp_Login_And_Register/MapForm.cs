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
    public partial class MapForm : Form
    {
        public MapForm(string email)
        {
            InitializeComponent();
            label6.Text = email;
            DB db = new DB();
            DataTable table = new DataTable();

            Ahere.Hide();
            Bhere.Hide();
            Chere.Hide();
            Dhere.Hide();
            
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
            if (a > 5)
            {
                LotAAvailable.BackColor = Color.Orange;
            }
            if (a > 10)
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
            if (b > 5)
            {
                lotBAvailable.BackColor = Color.Orange;
            }
            if (b > 10)
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
                    lotCAvailable.Text = ree.GetValue(0).ToString() + "/25";
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
            if (d > 5)
            {
                lotCAvailable.BackColor = Color.Orange;
            }
            if (d > 10)
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
                    if (red.GetValue(0).ToString() == "A")
                    {
                        Ahere.Show();
                    }
                    if (red.GetValue(0).ToString() == "B")
                    {
                        Bhere.Show();
                    }
                    if (red.GetValue(0).ToString() == "C")
                    {
                        Chere.Show();
                    }
                    if (red.GetValue(0).ToString() == "D")
                    {
                        Dhere.Show();
                    }
                }
            }
            red.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string email = label6.Text;
            this.Hide();
            MainForm main = new MainForm(email);
            main.Show();
        }
        private void MapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
