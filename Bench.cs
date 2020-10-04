using System;
namespace Lab5
{
    sealed class Bench: Inventory, Iusing
    {
        private double length;
        public Bench()
        {
            Quantity = 0;
            Price = 0;
            length = 0;
        }
        public Bench(double _length, int _quantity, int _price)
        {
            length = _length;
            Quantity = _quantity;
            Price = _price;
        }
        void Iusing.Use()
        {
            Console.WriteLine("Сидим на скамеечке");
        }
        public override void Use()
        {
            Console.WriteLine("Сидим на переопределённой скамеечке");
        }
        //public string GetInfo()
        //{
        //    return "Количество: " + Quantity + "\nЦена: " + Price + "\nДлина скамейки: " + length;
        //}
        public override string ToString()////////переопределение tostring
        {
            return "Скамейки: " +
                "\n Количество: " + Quantity.ToString() +
                "\n Цена: " + Price.ToString() +
                "\n Длина скамейки: " + length.ToString() + "\n------------------------------------------------";
        }
    }
}
