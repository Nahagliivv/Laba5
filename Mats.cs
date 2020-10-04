using System;
namespace Lab5
{
    sealed class Mats : Inventory, Iusing
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
        void Iusing.Use()
        {
            Console.WriteLine("Адыхаем на мате....");
        }
        public override void Use()
        {
            Console.WriteLine("Уже спим на мате...");
        }
        //    public string GetInfo()
        //    {
        //        return "Количество: " + Quantity + "\nЦена: " + Price + "\nФорма: " + form + "\nПлощадь: " + space;
        //}
        public override string ToString()////////переопределение tostring
        {
            return "Маты: " +
                "\n Количество: " + Quantity.ToString() +
                "\n Цена: " + Price.ToString() +
                "\n Форма: " + form.ToString() +
                "\n Площадь мата: " + space.ToString() + "\n------------------------------------------------";
        }
    }
}
