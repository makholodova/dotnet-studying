using System;

namespace OOP.Flat
{
    public class Flat
    {
        public int Floor { get; set; }
        public int Number { get; set; }
        public int Area { get; set; }
        public Room[] Rooms { get; set; }


        public void PrintContent()

        {
            Console.WriteLine($"Квартира на {Floor} этаже, номер {Number}, площадью {Area}(м2)," +
                              $" количество комнат {Rooms.Length}");

            foreach (var room in Rooms) room.PrintContent();
        }
    }
}