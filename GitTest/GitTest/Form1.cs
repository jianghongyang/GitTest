using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Timers.Timer timer = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.AutoReset = true;
            timer.Interval = 10 * 1000;
            timer.Elapsed += Timer_Elapsed;
            //timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MessageBox.Show("倒计时结束");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "版本1.0";
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            this.timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form from2 = new Form2();
            from2.Show();
            this.Close();
        }
    }
}
