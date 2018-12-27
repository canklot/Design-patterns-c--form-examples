using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{


    //State
    interface IDurum
    {
        string Handle(Dukkan s);
    }

    //ConcreteState
    class DukkanAc : IDurum
    {
        public string Handle(Dukkan s)
        {
            
            
            /*Context birdahaki çalışmasında SoketStateDinle nesnesine göre çalışacak*/
            s.State = new DukkanIslemede();
            return (  s.dkkn.ToString() + " açıldı.");
        }
    }

    //ConcreteState
    class DukkanIslemede : IDurum
    {
        public string Handle(Dukkan s)
        {
            
            /*Context birdahaki çalışmasında SoketStateKapat nesnesine göre çalışacak*/
            s.State = new DukkanKapalı();
            return (  s.dkkn.ToString() + " işlemede.");
        }
    }

    //ConcreteState
    class DukkanKapalı : IDurum
    {
        public string Handle(Dukkan s)
        {

            
            /*Context birdahaki çalışmasında SoketStateAc nesnesine göre çalışacak*/
            s.State = new DukkanAc();
            return (s.dkkn.ToString() + " kapalı.");
        }
    }

    //Context
    class Dukkan
    {
        public string cikti = " bos";
        public string dkkn { get; set; }
        public Dukkan(string dkkn)
        {
            this.dkkn = dkkn;
            State = new DukkanAc();
        }

        private IDurum _State { get; set; }
        public IDurum State
        {
            get { return _State; }
            set
            {
                _State = value;
                /*Senaryoya göre Handle burada da çalıştırılabilir.*/
            }
        }

        public string Do()
        {
            return State.Handle(this);
        }
    }
}
    
