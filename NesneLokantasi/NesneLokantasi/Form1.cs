using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using state;
using Facebookdede;
using iteterminator;
using temple;
using commando;
using WindowsFormsApp6;


namespace NesneLokantasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }
        Dukkan s = new Dukkan("NesneDükkanı");
        private void button2_Click(object sender, EventArgs e)
        {
            stateform mysokete = new stateform();
            //this.Hide();
            //mysokete.Show();
            label1.Text = s.Do();
            //Soket nesnesini oluşturuyoruz
            //her Do metodunu çalıştırdığımızda farklı işlemler çalışacaktır.



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(label1.Text == "NesneDükkanı kapalı."))
            {
                faceform myfaceform = new faceform();
                myfaceform.Show();
            }
            
            if (label1.Text == "NesneDükkanı kapalı.")            {
                this.errorProvider1.SetError(label1,"aefaef");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(label1.Text == "NesneDükkanı kapalı."))
            {
                iterform myiterform = new iterform();
                myiterform.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(label1.Text == "NesneDükkanı kapalı."))
            {
                adapform myadapform = new adapform();
                myadapform.Show();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(label1.Text == "NesneDükkanı kapalı."))
            {
                tempform mytempform = new tempform();
                mytempform.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "bugün" + dateTimePicker1.Value.ToLongDateString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "kucultuldu";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            commandoform mycommandoform = new commandoform();
            mycommandoform.Show();
        }
    }
}
