using System;
namespace Lab5
{
    class Tennis : Inventory, Iusing
    {
        private int racket; //кол-во ракеток
        private string color; //цвет стола
        public Tennis()
        {
            Quantity = 0;
            Price = 0;
            racket = 0;
            color = "";
        }
        public Tennis(int _quantity, int _price, int _racket, string _color)
        {
            Quantity = _quantity;
            Price = _price;
            racket = _racket;
            color = _color;
        }
        void Iusing.Use()
        {
            Console.WriteLine("Играем в теннис");
        }
        public override void Use()
        {
            Console.WriteLine("Переопределенный абстрактный теннис");
        }
        //public string GetInfo()
        // {
        //     return "Количество: " + Quantity + "\nЦена: " + Price + "\nКоличество ракеток: " + racket + "\nЦвет стола: " + color;
        // }
        public override string ToString()////////переопределение tostring
        {
            return "Теннис: " +
                "\n Количество: " + Quantity.ToString() +
                "\n Цена: " + Price.ToString() +
                "\n Количество ракеток: " + racket.ToString() +
                "\n Цвет стола: " + color.ToString() + "\n------------------------------------------------";
        }
    }
}
