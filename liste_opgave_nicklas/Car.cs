using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_opgave_nicklas
{
    class Car
    {

        public int Id { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }
        public string Color { get; set; }

        public Car(int id, string model, string brand, int year, int price, string color)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
            Price = price;
            Color = color;
        }
        public Car()
        {

        }

        public override string ToString()
        {
            return $"Id: {Id} Model: {Model} Brand: {Brand} Year: {Year} Price: {Price} Color: {Color}";
        }

    }
}
