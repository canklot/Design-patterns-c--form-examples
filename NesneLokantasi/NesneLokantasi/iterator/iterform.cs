using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iteterminator
{
    public partial class iterform : Form
    {

        public iterform()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MenuLConcreteAggregate MenuCollection = new MenuLConcreteAggregate();
            MenuCollection.Add(new MenuL { menu = "pizza", menuFiyat = 59 });
            MenuCollection.Add(new MenuL { menu = "çay", menuFiyat = 9 });
            MenuCollection.Add(new MenuL { menu = "hamburger", menuFiyat = 10 });
            IMenuLIterator itr = MenuCollection.GetIterator();
            label1.Text = "fiyatlar \n";
            while (itr.IsDone())
            {
                label1.Text += itr.CurrentItem().menu + " " + itr.CurrentItem().menuFiyat + "\n";
                itr.Next();
            }
        }
    }
}
