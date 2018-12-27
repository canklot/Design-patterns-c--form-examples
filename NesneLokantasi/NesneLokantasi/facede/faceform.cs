using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebookdede
{
    public partial class faceform : Form
    {
        public faceform()
        {
            InitializeComponent();
            label3.Text = "Menu \n Muz \n karpuz \n çilek \n çikolata";
        }
        
        Facade f = new Facade();

        private void button1_Click(object sender, EventArgs e)
        {
            string girdi = textBox1.Text;
            List<string> gelen =  f.Sistem2malzemeEkle(girdi);
            label1.Text = "";
            foreach( string icinde in gelen) { label1.Text += icinde + "\n"; }
            
            
        }
    }
}
