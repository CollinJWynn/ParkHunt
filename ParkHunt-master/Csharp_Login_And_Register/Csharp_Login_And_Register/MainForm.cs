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
        public MainForm()
        {
            InitializeComponent();
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
                    button1.Text = reader.GetValue(0).ToString() + "/56";
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            int a = Int32.Parse(String.Concat(button1.Text.TakeWhile(c => c != '/')));
            if (a > 0)
            {
                button1.BackColor = Color.GreenYellow;
            }
            if (a > 5)
            {
                button1.BackColor = Color.Orange;
            }
            if (a > 10)
            {
                button1.BackColor = Color.Red;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            int a = Int32.Parse(String.Concat(button1.Text.TakeWhile(c => c != '/')));
            ++a;
            button1.Text = a.ToString() + "/56";
            if (a > 0)
            {
                button1.BackColor = Color.GreenYellow;
            }
            if (a > 5)
            {
                button1.BackColor = Color.Orange;
            }
            if (a > 10)
            {
                button1.BackColor = Color.Red;
            }
        }
    }
    
}
