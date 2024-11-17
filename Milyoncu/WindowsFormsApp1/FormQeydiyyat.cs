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

namespace WindowsFormsApp1
{
    public partial class FormQeydiyyat : Form
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Desktop\\project1\\Users.accdb";

        public FormQeydiyyat()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection1 = new OleDbConnection(connection);
            connection1.Open();


            string login = "SELECT * FROM Users WHERE Login= '" + textBoxUserName.Text + "' or Email= '" + textBoxMail.Text + "'";
            OleDbCommand cmd2 = new OleDbCommand(login, connection1);
            OleDbDataReader dr = cmd2.ExecuteReader();
            if (textBoxUserName.Text == " " || textBoxMail.Text == " " || textBoxName.Text == " " || textBoxPassword.Text.Length == 0 || textBoxUserName.Text.Length == 0 || textBoxMail.Text == " " || textBoxName.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Heç bir xana boş buraxılmamalıdır!");

            }
            else
            {
                if (dr.Read() == true)
                {
                    dr.Close();
                    MessageBox.Show("İstifadeçi adı və ya mail artıq istifadə olunub", "Giriş Uğursuzdur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUserName.Text = "";
                    textBoxMail.Text = "";
                    textBoxName.Text = "";
                    textBoxPassword.Text = "";

                }
                else

                {
                    dr.Close();
                    string sql = "INSERT INTO Users (Login,Password1,Name1,Email) values (@login,@password1,@name1,@mail)";
                    OleDbCommand cmd1 = new OleDbCommand(sql, connection1);
                    cmd1.Parameters.AddWithValue("@login", textBoxUserName.Text);
                    cmd1.Parameters.AddWithValue("@mail", textBoxMail.Text);
                    cmd1.Parameters.AddWithValue("@name1", textBoxName.Text);
                    cmd1.Parameters.AddWithValue("@password1", textBoxPassword.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Qeydiyyatdan keçdiniz");
                    textBoxUserName.Text = "";
                    textBoxMail.Text = "";
                    textBoxName.Text = "";
                    textBoxPassword.Text = "";
                }



                connection1.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Visible = false;
        }
        
    }
}
