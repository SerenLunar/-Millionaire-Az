using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQeydiyyat form3 = new FormQeydiyyat();
            form3.Show();

            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGiris form2 = new FormGiris();
            form2.Show();

            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
