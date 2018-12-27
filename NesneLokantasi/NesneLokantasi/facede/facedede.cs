using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebookdede
{
    class facedede
    {
    }

    public class Sistem1Kontrol
    {
        
        public bool malzemeListeKontrol(string malzeme)
        {
            //kontrol edildiğini varsayalım
            if (malzeme == "çikolata") { return true; }
            return false;
        }
    }

    public class Sistem2Operations
    {
        List<string> menu = new List<string>();
        public List<string> maddeEkle(string malzeme)
        {
            menu.Add(malzeme);
            return menu;
        }
    }
    public class malzemeSistem
    {
        public bool Kontrol(string malzeme)
        {

            //kontrol edildiğini varsayalım
            if (malzeme == "muz" | malzeme == "çilek" | malzeme == "karpuz" | malzeme == "çikolata") { return true; }
            return false;
        }
    }
    public class Facade
    {
        //constructor da oluşturulabilir
        //singleton olarak tasarlanabilir
        malzemeSistem malzemeSistem = new malzemeSistem();
        Sistem1Kontrol Sistem1 = new Sistem1Kontrol();
        Sistem2Operations Sistem2 = new Sistem2Operations();
        public List<string> Sistem2malzemeEkle(string malzeme)
        {
            if (malzemeSistem.Kontrol(malzeme) && !Sistem1.malzemeListeKontrol(malzeme))
            {
                return (Sistem2.maddeEkle(malzeme));
            }
            List<string> blank = new List<string>();
            return blank;
        }
    }
}
