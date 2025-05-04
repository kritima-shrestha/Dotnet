using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;
using WinFormsApp1;

namespace register
{
    public partial class mainpanel : Form
    {
        public mainpanel()
        {
            InitializeComponent();
        }
        private void LoadFormInPanel(Form form)
        {

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(form);
            form.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regis regform = new regis();
            LoadFormInPanel(regform);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login log = new login();
            LoadFormInPanel(log);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator cal = new calculator();
            LoadFormInPanel(cal);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void startTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label1.Visible = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Visible = false;
        }
    }
}
