﻿using System;
namespace Lab5
{
    abstract class Inventory
    {
        private int quantity; //Количество элементов данного класса в инвентаре
        protected int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        private int price; //общая цена элементов данного класса в инвентаре
        protected int Price
        {
            get => price;
            set => price = value;
        }
        public abstract void Use();
    }
}
