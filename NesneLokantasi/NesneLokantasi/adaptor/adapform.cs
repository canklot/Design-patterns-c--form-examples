using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class adapform : Form
    {
        public adapform()
        {
            InitializeComponent();
            label1.Text = "keki pastaya adapte edip süsle";

        }

        private void button1_Click(object sender, EventArgs e)
        {
             var kek = new Kek();
            IPasta pasta = new Pasta();
            IPasta kekadapt = new KekAdapter(kek);
            if (radioButton1.Checked == true)
            {
                label1.Text = kekadapt.Kapla(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                label1.Text = kekadapt.Kapla(radioButton2.Text);
            }
            
        }
    }
    public class Pasta : IPasta
    {
        public string tip;

        public string Susle(string x)
        {
            return x;
        }
        public string Kapla(string x)
        {
            return x;
        }

    }
    public class Kek : IKek
    {
        public string tip;
        public string Susle(string x)
        {
            return x;
        }

    }
    public interface IPasta
    {
        string Susle(string x);
        string Kapla(string x);
    }
    public interface IKek
    {
        string Susle(string x);
    }
    public class KekAdapter : IPasta
    {
        private readonly IKek kekI;
        public KekAdapter(IKek kekI)
        {
            this.kekI = kekI;
        }
        public string Susle(string x)
        {
            return kekI.Susle(x);
        }
        public string Kapla(string x)
        {
            return x;
        }
    }
}
