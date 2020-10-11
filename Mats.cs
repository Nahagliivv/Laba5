using System;
namespace Lab5
{
    partial class Mats : Inventory, Iusing
    {
        private string form; //форма мата
        private int space; //площадь мата
        public Mats()
        {
            Quantity = 0;
            Price = 0;
            form = "";
            space = 0;
        }
        public Mats(int _quantity, int _price, string _form, int _space)
        {
            Quantity = _quantity;
            Price = _price;
            form = _form;
            space = _space;
        }

    }
}
