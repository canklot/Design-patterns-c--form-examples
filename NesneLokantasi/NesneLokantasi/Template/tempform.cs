using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using temple;

namespace temple
{
    public partial class tempform : Form
    {
        public tempform()
        {
            InitializeComponent();
            label1.Text = "neli kahve istediğinizi yazın";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kahveyap kahve = new Kahveyap();
            kahve.DoOP(textBox1.Text);
            label1.Text = kahve.cikti;
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
