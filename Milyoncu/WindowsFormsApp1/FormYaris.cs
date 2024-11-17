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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Threading;
using System.Media;
using System.Reflection.Emit;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class FormYaris : Form
    {
        int z = 0, s1 = 0, s2 = 0, s3 = 0;
        int say;
        int xalInt = -1;
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Desktop\\project1\\Users.accdb";
        int x = 0;
        string level;
        string kom;
        int xal = -1;
        string point;
        SoundPlayer sp3 = new SoundPlayer();

        public void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                System.Threading.Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }

        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Desktop\\project1\\Users.accdb";
        string c1, c2, c3, c4;

        private void buttonA_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonA.Enabled=false;
            buttonA.BackColor = Color.Yellow;

            Wait(3000);
            if (buttonA.Text == c4)
            {
                SoundPlayer sp1 = new SoundPlayer();
                sp1.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Win.wav";
                sp1.Play();
                buttonA.BackColor = Color.Green;
                buttonB.BackColor = Color.Red;
                buttonC.BackColor = Color.Red;
                buttonD.BackColor = Color.Red;
                Wait(4000);
                gx();
            }

            else
            {
                savet(label27.Text);
                SoundPlayer sp2 = new SoundPlayer();
                sp2.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Lose.wav";
                sp2.Play();
                buttonA.BackColor = Color.Red;

                if (buttonB.Text == c4)
                {
                    buttonB.BackColor = Color.Green;
                }
                else
                {
                    buttonB.BackColor = Color.Red;
                }
                if (buttonC.Text == c4)
                {
                    buttonC.BackColor = Color.Green;
                }
                else
                {
                    buttonC.BackColor = Color.Red;
                }
                if (buttonD.Text == c4)
                {
                    buttonD.BackColor = Color.Green;
                }
                else
                {
                    buttonD.BackColor = Color.Red;
                }
                Wait(4000);
                MessageBox.Show("siz " + label27.Text + "$ Qazandiniz");
                DialogResult result = MessageBox.Show("Oyuna yeniden baslamaq isteyirsiz?", "??????", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form form = new FormYaris();
                    form.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonB.Enabled = false;
            buttonB.BackColor = Color.Yellow;

            Wait(3000);
            if (buttonB.Text == c4)
            {
                SoundPlayer sp1 = new SoundPlayer();
                sp1.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Win.wav";
                sp1.Play();
                buttonB.BackColor = Color.Green;
                buttonA.BackColor = Color.Red;
                buttonC.BackColor = Color.Red;
                buttonD.BackColor = Color.Red;
                Wait(4000);
                gx();
            }

            else
            {
                savet(label27.Text);
                SoundPlayer sp2 = new SoundPlayer();
                sp2.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Lose.wav";
                sp2.Play();
                buttonB.BackColor = Color.Red;

                if (buttonA.Text == c4)
                {
                    buttonA.BackColor = Color.Green;
                }
                else
                {
                    buttonA.BackColor = Color.Red;
                }
                if (buttonC.Text == c4)
                {
                    buttonC.BackColor = Color.Green;
                }
                else
                {
                    buttonC.BackColor = Color.Red;
                }
                if (buttonD.Text == c4)
                {
                    buttonD.BackColor = Color.Green;
                }
                else
                {
                    buttonD.BackColor = Color.Red;
                }
                Wait(4000);
                MessageBox.Show("siz " + label27.Text + "$ Qazandiniz");

                DialogResult result = MessageBox.Show("Oyuna yeniden baslamaq isteyirsiz?", "??????", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form form = new FormYaris();
                    form.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonC.Enabled=false;
            buttonC.BackColor = Color.Yellow;

            Wait(3000);
            if (buttonC.Text == c4)
            {
                SoundPlayer sp1 = new SoundPlayer();
                sp1.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Win.wav";
                sp1.Play();
                buttonC.BackColor = Color.Green;
                buttonB.BackColor = Color.Red;
                buttonA.BackColor = Color.Red;
                buttonD.BackColor = Color.Red;
                Wait(4000);
                gx();
            }

            else
            {

                savet(label27.Text);
                SoundPlayer sp2 = new SoundPlayer();
                sp2.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Lose.wav";
                sp2.Play();
                buttonC.BackColor = Color.Red;

                if (buttonB.Text == c4)
                {
                    buttonB.BackColor = Color.Green;
                }
                else
                {
                    buttonB.BackColor = Color.Red;
                }
                if (buttonA.Text == c4)
                {
                    buttonA.BackColor = Color.Green;
                }
                else
                {
                    buttonA.BackColor = Color.Red;
                }
                if (buttonD.Text == c4)
                {
                    buttonD.BackColor = Color.Green;
                }
                else
                {
                    buttonD.BackColor = Color.Red;
                }
                Wait(4000);
                MessageBox.Show("siz " + label27.Text + "$ Qazandiniz");

                DialogResult result = MessageBox.Show("Oyuna yeniden baslamaq isteyirsiz?", "??????", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form form = new FormYaris();
                    form.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonD.Enabled = false;
            buttonD.BackColor = Color.Yellow;

            Wait(3000);
            if (buttonD.Text == c4)
            {
                SoundPlayer sp1 = new SoundPlayer();
                sp1.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Win.wav";
                sp1.Play();
                buttonD.BackColor = Color.Green;
                buttonB.BackColor = Color.Red;
                buttonC.BackColor = Color.Red;
                buttonA.BackColor = Color.Red;
                Wait(4000);
                gx();
            }
            else
            {
                savet(label27.Text);
                SoundPlayer sp2 = new SoundPlayer();
                sp2.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Lose.wav";
                sp2.Play();
                buttonD.BackColor = Color.Red;

                if (buttonB.Text == c4)
                {
                    buttonB.BackColor = Color.Green;
                }
                else
                {
                    buttonB.BackColor = Color.Red;
                }
                if (buttonC.Text == c4)
                {
                    buttonC.BackColor = Color.Green;
                }
                else
                {
                    buttonC.BackColor = Color.Red;
                }
                if (buttonA.Text == c4)
                {
                    buttonA.BackColor = Color.Green;
                }
                else
                {
                    buttonA.BackColor = Color.Red;
                }
                Wait(4000);
                MessageBox.Show("siz " + label27.Text + "$ Qazandiniz");

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            s1++;
            button1.Visible = false;
            button2.Enabled = false;
            button3.Enabled = false;          

            if (buttonA.Text == c4)
            {
                buttonB.Visible = false;
                buttonC.Visible = false;
            }
            else if (buttonB.Text == c4)
            {
                buttonA.Visible = false;
                buttonD.Visible = false;
            }
            else if (buttonC.Text == c4)
            {
                buttonA.Visible = false;
                buttonB.Visible = false;
            }
            else
            {
                buttonC.Visible = false;
                buttonA.Visible = false;
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            s1++;
            button2.Visible = false;
            button1.Enabled = false;
            button3.Enabled = false;
            if (buttonA.Text == c4)
            {
                buttonB.Visible = false;
                buttonC.Visible = false;
            }
            else if (buttonB.Text == c4)
            {
                buttonA.Visible = false;
                buttonD.Visible = false;
            }
            else if (buttonC.Text == c4)
            {
                buttonA.Visible = false;
                buttonB.Visible = false;
            }
            else
            {
                buttonC.Visible = false;
                buttonA.Visible = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            s1++;
            button3.Visible = false;
            button2.Enabled = false;
            button1.Enabled = false;
            if (buttonA.Text == c4)
            {
                buttonB.Visible = false;
                buttonC.Visible = false;
            }
            else if (buttonB.Text == c4)
            {
                buttonA.Visible = false;
                buttonD.Visible = false;
            }
            else if (buttonC.Text == c4)
            {
                buttonA.Visible = false;
                buttonB.Visible = false;
            }
            else
            {
                buttonC.Visible = false;
                buttonA.Visible = false;
            }    
        }

        private void yeniOyunaBaslaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormYaris();
            form.Show();
            this.Close();
        }

        private void FormYaris_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
        }

        private void anaSehifeyeQayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormMainMenu();
            form.Show();
            this.Close();
        }

        private void musiqiniDayandirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sp3.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Start.wav";
            sp3.Stop();



            if (label27.Text == "1000")
            {
                SoundPlayer sp1000 = new SoundPlayer();
                sp1000.SoundLocation = @"C:\Users\user\Desktop\project1\sound\7500.wav";
                sp1000.Stop();
            }
            else if (label27.Text == "7500")
            {
                SoundPlayer sp7500 = new SoundPlayer();
                sp7500.SoundLocation = @"C:\Users\user\Desktop\project1\sound\60000.wav";
                sp7500.Stop();
            }
            else if (label27.Text == "60000")
            {
                SoundPlayer sp60000 = new SoundPlayer();
                sp60000.SoundLocation = @"C:\Users\user\Desktop\project1\sound\1m.wav";
                sp60000.Stop();
            }
            else if (label28.Text == "250000")
            {
                SoundPlayer sp1m = new SoundPlayer();
                sp1m.SoundLocation = @"C:\Users\user\Desktop\project1\sound\last.wav";
                sp1m.Stop();
            }
        }

        private void mahniniAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sp3.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Start.wav";
            sp3.Play();


            if (label27.Text == "1000")
            {
                SoundPlayer sp1000 = new SoundPlayer();
                sp1000.SoundLocation = @"C:\Users\user\Desktop\project1\sound\7500.wav";
                sp1000.Play();
            }
            else if (label27.Text == "7500")
            {
                SoundPlayer sp7500 = new SoundPlayer();
                sp7500.SoundLocation = @"C:\Users\user\Desktop\project1\sound\60000.wav";
                sp7500.Play();
            }
            else if (label27.Text == "60000")
            {
                SoundPlayer sp60000 = new SoundPlayer();
                sp60000.SoundLocation = @"C:\Users\user\Desktop\project1\sound\1m.wav";
                sp60000.Play();
            }
            else if (label28.Text == "250000")
            {
                SoundPlayer sp1m = new SoundPlayer();
                sp1m.SoundLocation = @"C:\Users\user\Desktop\project1\sound\last.wav";
                sp1m.Play();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            z++;

            label29.Text = (30 - z).ToString();
            if (z == 30)
            {
                timer1.Enabled = false;
                MessageBox.Show("Sizin vaxtiniz bitdi");
                if (buttonA.Text == c4)
                {
                    buttonA.BackColor = Color.Green;
                    buttonB.BackColor = Color.Red;
                    buttonC.BackColor = Color.Red;
                    buttonD.BackColor = Color.Red;
                }
                else if (buttonB.Text == c4)
                {
                    buttonB.BackColor = Color.Green;
                    buttonC.BackColor = Color.Red;
                    buttonD.BackColor = Color.Red;
                    buttonA.BackColor = Color.Red;
                }
                else if (buttonC.Text == c4)
                {
                    buttonC.BackColor = Color.Green;
                    buttonA.BackColor = Color.Red;
                    buttonB.BackColor = Color.Red;
                    buttonD.BackColor = Color.Red;
                }
                else if (buttonD.Text == c4)
                {
                    buttonD.BackColor = Color.Green;
                    buttonB.BackColor = Color.Red;
                    buttonC.BackColor = Color.Red;
                    buttonA.BackColor = Color.Red;
                }
                Wait(3000);
                savet(label27.Text);
                MessageBox.Show("siz " + label27.Text + "$ Qazandiniz");
                this.Close();
            }
        }

        private void oyundanCixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\user\Desktop\project1\sound\wait.wav";
            timer1.Stop();
            sp.Stop();
            DialogResult result = MessageBox.Show(label28.Text + "$ pulunuz var,geri  çəkilmək istədiyinizdən əminsiniz?", "Geri çəkil", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {
                MessageBox.Show(label28.Text + " $ Qazandiniz");
                savet(label28.Text);
                if (buttonA.Text == c4)
                {
                    buttonA.BackColor = Color.Green;
                    buttonB.BackColor = Color.Red;
                    buttonC.BackColor = Color.Red;
                    buttonD.BackColor = Color.Red;
                }
                else if (buttonB.Text == c4)
                {
                    buttonB.BackColor = Color.Green;
                    buttonA.BackColor = Color.Red;
                    buttonC.BackColor = Color.Red;
                    buttonD.BackColor = Color.Red;
                }
                else if (buttonC.Text == c4)
                {
                    buttonC.BackColor = Color.Green;
                    buttonB.BackColor = Color.Red;
                    buttonA.BackColor = Color.Red;
                    buttonD.BackColor = Color.Red;
                }
                else if (buttonD.Text == c4)
                {
                    buttonD.BackColor = Color.Green;
                    buttonA.BackColor = Color.Red;
                    buttonB.BackColor = Color.Red;
                    buttonC.BackColor = Color.Red;
                }
                Wait(4000);
            }
            else if (result == DialogResult.No)
            {
                timer1.Start();
                sp.Play();
            }
        }

        private void oyunaBaslaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled=true;
            buttonC.Enabled=true;
            buttonD.Enabled=true;

            timer1.Start();
            richTextBox1.Visible = true;
            gx();
        }

        public void savet(string xal)
        {
            xalInt = Convert.ToInt32(xal);

            OleDbConnection connection1 = new OleDbConnection(connection);
            connection1.Open();

            string qazanc = "INSERT INTO Leaderboard (Login,Qazanc) values (@ad,@point)";
            OleDbCommand pb = new OleDbCommand(qazanc, connection1);
            pb.Parameters.AddWithValue("@ad", FormGiris.userName);
            pb.Parameters.AddWithValue("@point", Convert.ToInt32(xalInt));
            pb.ExecuteNonQuery();
            connection1.Close();
        }
        public FormYaris()
        {
            InitializeComponent();
            sp3.SoundLocation = @"C:\Users\user\Desktop\project1\sound\Start.wav";
            sp3.Play();
        }

        private void gx()
        {
            if (s1 == 0)
            {
                button1.Visible = true;
            }
            if (s2 == 0)
            {
                button2.Visible = true;
            }
            if (s3 == 0)
            {
                button3.Visible = true;
            }
            z = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;

            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\user\Desktop\project1\sound\1000.wav";
            sp.Play();

            xalInt++;
            if (xalInt == 0)
            {
                panel2.BackColor = Color.Yellow;
                label27.Text = "0";
                label28.Text = "0";
            }
            else if (xalInt == 1)
            {
                panel2.BackColor = Color.Green;
                panel3.BackColor = Color.Yellow;
                label27.Text = "0";
                label28.Text = "500";
            }
            else if (xalInt == 2)
            {
                panel3.BackColor = Color.Green;
                panel4.BackColor = Color.Yellow;
                label27.Text = "1000";
                label28.Text = "1000";
            }
            else if (xalInt == 3)
            {
                panel4.BackColor = Color.Green;
                panel5.BackColor = Color.Yellow;
                label28.Text = "2000";
            }
            else if (xalInt == 4)
            {
                panel5.BackColor = Color.Green;
                panel6.BackColor = Color.Yellow;
                label28.Text = "3000";
            }
            else if (xalInt == 5)
            {
                panel6.BackColor = Color.Green;
                panel7.BackColor = Color.Yellow;
                label28.Text = "5000";
            }
            else if (xalInt == 6)
            {
                panel7.BackColor = Color.Green;
                panel8.BackColor = Color.Yellow;
                label27.Text = "7500";
                label28.Text = "7500";
            }
            else if (xalInt == 7)
            {
                panel8.BackColor = Color.Green;
                panel9.BackColor = Color.Yellow;
                label28.Text = "15000";
            }
            else if (xalInt == 8)
            {
                panel9.BackColor = Color.Green;
                panel10.BackColor = Color.Yellow;
                label28.Text = "30000";
            }
            else if (xalInt == 9)
            {
                panel10.BackColor = Color.Green;
                panel11.BackColor = Color.Yellow;
                label27.Text = "60000";
                label28.Text = "60000";
            }
            else if (xalInt == 10)
            {
                panel11.BackColor = Color.Green;
                panel12.BackColor = Color.Yellow;
                label28.Text = "125000";
            }
            else if (xalInt == 11)
            {
                panel12.BackColor = Color.Green;
                panel13.BackColor = Color.Yellow;
                label28.Text = "250000";
            }
            else if (xalInt == 12)
            {
                timer1.Enabled = false;
                sp.Stop();
                label27.Text = "1000000";
                label28.Text = "1000000";
                panel13.BackColor = Color.Green;
                MessageBox.Show("Təbriklər 1000000 $ qazandınız!");
                savet(label27.Text);

                this.Close();
            }
            if (label27.Text == "1000")
            {
                SoundPlayer sp1000 = new SoundPlayer();
                sp1000.SoundLocation = @"C:\Users\user\Desktop\project1\sound\7500.wav";
                sp1000.Play();
            }
            else if (label27.Text == "7500")
            {
                SoundPlayer sp7500 = new SoundPlayer();
                sp7500.SoundLocation = @"C:\Users\user\Desktop\project1\sound\60000.wav";
                sp7500.Play();
            }
            else if (label27.Text == "60000")
            {
                SoundPlayer sp60000 = new SoundPlayer();
                sp60000.SoundLocation = @"C:\Users\user\Desktop\project1\sound\1m.wav";
                sp60000.Play();
            }
            else if (label28.Text == "250000")
            {
                SoundPlayer sp1m = new SoundPlayer();
                sp1m.SoundLocation = @"C:\Users\user\Desktop\project1\sound\last.wav";
                sp1m.Play();
            }

            buttonA.BackColor = Color.Transparent;
            buttonB.BackColor = Color.Transparent;
            buttonC.BackColor = Color.Transparent;
            buttonD.BackColor = Color.Transparent;
            x++;
            level = x.ToString();
            string  kom = "Select[Sual] from suallar where Lvl =" + level;

            OleDbConnection connection1 = new OleDbConnection(connection);
            Array arr;
            using (OleDbCommand selectCommand = new OleDbCommand(kom, connection1))
            {
                connection1.Open();

                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = selectCommand;
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Random random = new Random(Environment.TickCount);

                    buttonA.Enabled = true;
                    buttonB.Enabled = true;
                    buttonC.Enabled = true;
                    buttonD.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    object nameValue = row["Sual"];
                    listBox1.Items.Add(nameValue.ToString());
                    int index = random.Next(listBox1.Items.Count);
                    richTextBox1.Text = listBox1.Items[index].ToString();
                }
                listBox1.Items.Clear();

                string cmdText = "select* from Suallar WHERE Sual ='" + richTextBox1.Text + "'";
                OleDbCommand cmd1 = new OleDbCommand(cmdText, connection1);
                OleDbDataReader reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    c1 = reader["yalnish1"].ToString();
                    c2 = reader["yalnish2"].ToString();
                    c3 = reader["yalnish3"].ToString();
                    c4 = reader["dogru"].ToString();

                    listBox2.Items.Clear();
                    listBox2.Items.Add(c1);
                    listBox2.Items.Add(c2);
                    listBox2.Items.Add(c3);
                    listBox2.Items.Add(c4);

                    Random var = new Random();
                    List<int> list = new List<int>();
                    int randomnum = 0;
                    for (int i = 0; i < 10000; i++)
                    {
                        randomnum = var.Next(0, 4);
                        if (!list.Contains(randomnum))
                            list.Add(randomnum);
                    }
                    buttonA.Text = listBox2.Items[list[0]].ToString();
                    buttonB.Text = listBox2.Items[list[1]].ToString();
                    buttonC.Text = listBox2.Items[list[2]].ToString();
                    buttonD.Text = listBox2.Items[list[3]].ToString();
                }
            }
            connection1.Close();
        }
    }
}
