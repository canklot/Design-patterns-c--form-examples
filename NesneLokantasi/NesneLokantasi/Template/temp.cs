using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temple
{
    public abstract class temp
    {

        public void DoOP(string girdi)
        {
            Girdiler(girdi);
            Operasyon();
            Sonuc();
        }

        public abstract void Girdiler(string girdi);
        public abstract void Operasyon();
        public abstract void Sonuc();


    }
    public class Kahveyap : temp
    {
        public string Icerikler;
        public string cikti;
        public override void Girdiler(string girdi)//istersen parametreleri silip seçme şansı tanımayalım
        {                                           //sadece tek tip kahve üretsin command gibi
            Icerikler = girdi;
            
        }
        public override void Operasyon()
        {
            cikti = "Kahve hazirlaniyor...";
        }
        public override void Sonuc()
        {
            cikti += Icerikler + "li Kahve hazir...";
        }
    }

}
