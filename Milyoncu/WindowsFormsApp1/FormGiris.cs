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
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        public static string userName;

        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Desktop\\project1\\Users.accdb";

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection connection1 = new OleDbConnection(connection);
            connection1.Open();

            string str = "SELECT * FROM Users WHERE Login= '" + textBoxLogin.Text + "' or Email= '" + textBoxLogin.Text + "' and Password1= '" + textBoxPassword.Text + "'";
            OleDbCommand cmd3 = new OleDbCommand(str, connection1);

            cmd3.ExecuteNonQuery();
            OleDbDataReader reader = cmd3.ExecuteReader();
            if (reader.Read())
            {

                userName = textBoxLogin.Text;
                reader.Close();
                this.Close();
                FormYaris form4 = new FormYaris();
                form4.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login/E-mail ve ya parol yanlışdır");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQeydiyyat formQeydiyyat = new FormQeydiyyat();
            formQeydiyyat.Show(); 
            this.Visible = false;
        }
    }
}
