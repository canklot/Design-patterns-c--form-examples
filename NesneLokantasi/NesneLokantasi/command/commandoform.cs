using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commando
{
    public partial class commandoform : Form
    {
        public commandoform()
        {
            InitializeComponent();
        }
        static string cikti = "";
        //                      INTERFACE                //
        public interface ICommand
        {
            void Execute();
            void Undo();
        }

        //                      VENDORCLASS             //
        public class KekKalibi
        {
            public void KKkullanilsin()
            {
                cikti = "Kek kalibi kullanilsin";
            }
            public void KKkullanilmasin()
            {
                cikti = "Kek kalibi kullanilmasin";
            }
        }
        public class Sus
        {
            public void Skullanilsin()
            {
                cikti = "Süs kullanilsin";

            }
            public void Skullanilmasin()
            {
                cikti = "Süs kullanilmasin";
            }
        }

        //                     COMMANDS             //
        public class NoCommand : ICommand
        {
            public void Execute() { }
            public void Undo() { }
        }
        public class KalıpC : ICommand
        {
            KekKalibi kekKalibi;
            public KalıpC(KekKalibi kekKalibi)
            {
                this.kekKalibi = kekKalibi;
            }
            public void Execute()
            {
                this.kekKalibi.KKkullanilsin();
            }
            public void Undo()
            {
                this.kekKalibi.KKkullanilmasin();
            }
        }
        public class SusC : ICommand
        {
            Sus sus;
            public SusC(Sus sus)
            {
                this.sus = sus;
            }
            public void Execute()
            {
                this.sus.Skullanilsin();
            }
            public void Undo()
            {
                this.sus.Skullanilmasin();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        Sus sus = new Sus();
        KekKalibi kekKalibi = new KekKalibi();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KalıpC kalıp = new KalıpC(kekKalibi);
            SusC susC = new SusC(sus);

            if (comboBox1.SelectedItem == "süs ekle")
            {
                susC.Execute();
                label1.Text = cikti + "\n";
            }
            if (comboBox1.SelectedItem == "süsü kaldır")
            {
                
                susC.Undo();
                label1.Text += cikti + "\n";
            }
            if (comboBox1.SelectedItem == "kalıp ekle")
            {
                kalıp.Execute();
                label1.Text += cikti + "\n";
            }
            if (comboBox1.SelectedItem == "kalıp kaldır")
            {

                kalıp.Undo();
                label1.Text += cikti + "\n";
            }
        }
    }
}
