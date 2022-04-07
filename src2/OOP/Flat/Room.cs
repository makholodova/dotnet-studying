using System;

namespace OOP.Flat
{
    public class Room
    {
        public string Name { get; set; }
        public TypeOfRoom TypeOfRoom { get; set; }
        public int Area { get; set; }
        public int WindowsCount { get; set; }
        public int DoorsCount { get; set; }
        public Furniture[] Furnitures { get; set; }


        public void PrintContent()
        {
            Console.WriteLine($"Название комнты {Name}, тип комнаты {TypeOfRoom}, площадью {Area}(м2)," +
                              $" количество окон {WindowsCount}, количество дверей {DoorsCount}");
            foreach (var furniture in Furnitures)
            {
                furniture.PrintContent();
            }
        }
    }
}