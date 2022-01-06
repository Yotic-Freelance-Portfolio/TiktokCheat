using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1tokBD
{
    internal partial class Form1 : Form 
    {
        internal Form1()
        {
            InitializeComponent();
            this.MouseDown += Controls_MouseDown;
            panel1.MouseDown += Controls_MouseDown;
        }

        public void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                ((Control)sender).Capture = false;
                var m = Message.Create(Handle, 0xa1, new IntPtr(0x2), IntPtr.Zero);
                WndProc(ref m);
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            Helper.CreateDirectory();
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = Color.AliceBlue;
            Grafics.SetRoundedUndNotFullShape(button1, 10);
            Grafics.SetRoundedUndNotFullShape(button2, 15);
            Grafics.SetRoundedButNotFullShape(panel1, 20);
            Grafics.SetRoundedShape(panel2, 15);
            Grafics.SetRoundedShape(panel3, 15);
            Grafics.SetRoundedShape(panel4, 15);
            Grafics.SetRoundedShape(panel5, 15);
            Grafics.SetRoundedShape(panel6, 15);
            Grafics.SetRoundedShape(panel7, 15);
            Config.Get();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config.Save();
            Process.GetCurrentProcess().Kill();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";  

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    button4.Text = "DataBase: " + openFileDialog.FileName.Split('\\')[openFileDialog.FileName.Split('\\').Length];
                    Config.dataBase = openFileDialog.FileName;
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Config.threads = uint.Parse(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Config.urlTikTok = "https://www.tiktok.com/@" + textBox1.Text;
            label9.Text = "@" + textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Config.subscriptions = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Config.likes = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Config.comments = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Config.views = checkBox4.Checked;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Config.Save();
            Work.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Config.headless = checkBox5.Checked;
        }
    }
}
