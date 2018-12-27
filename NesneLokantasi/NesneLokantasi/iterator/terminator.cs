using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteterminator
{
    

    class MenuL
    {
        public string menu { get; set; }
        public int menuFiyat { get; set; }
    }

    //Iterator arayüzü
    interface IMenuLIterator
    {
        MenuL Next();
        bool IsDone();
        MenuL CurrentItem();
    }
    //Aggregate arayüzü
    interface IMenuLAggregate
    {
        IMenuLIterator GetIterator();
    }
    //ConcreteAggregate
    class MenuLConcreteAggregate : IMenuLAggregate
    {
        private List<MenuL> MenuList = new List<MenuL>();
        public int MenuCount { get { return MenuList.Count; } }
        public void Add(MenuL t)
        {
            MenuList.Add(t);
        }
        public MenuL GetItem(int index)
        {
            return MenuList[index];
        }
        public IMenuLIterator GetIterator()
        {
            return new MenuLConcreteIterator(this);
        }
    }
    //ConcreteIterator
    class MenuLConcreteIterator : IMenuLIterator
    {
        private MenuLConcreteAggregate CollectionMenu;
        private int _index = 0;
        public MenuLConcreteIterator(MenuLConcreteAggregate ColMenu)
        {
            CollectionMenu = ColMenu;
        }
        public MenuL Next()
        {
            _index++;
            if (IsDone())
                return CollectionMenu.GetItem(_index);
            else
                return null;
        }
        public bool IsDone()
        {
            return _index < CollectionMenu.MenuCount;
        }
        public MenuL CurrentItem()
        {
            return CollectionMenu.GetItem(_index);
        }
    }
}
