namespace OOP.Flat
{
    public static class FlatBuilder
    {
        public static Flat Build()
        {
            var flat = new Flat();
            flat.Floor = 12;
            flat.Number = 247;
            flat.Area = 56;

            var rooms = GetRooms();
            flat.Rooms = rooms;

            flat.PrintContent();
            return flat;
        }

        private static Room[] GetRooms()
        {
            var room1 = new Room
            {
                Name = "Ванна",
                TypeOfRoom = TypeOfRoom.Bathroom,
                Area = 6,
                WindowsCount = 0,
                DoorsCount = 1,
                Furnitures = GetFurnituresBathroom()
            };
            var room2 = new Room
            {
                Name = "Кухня",
                TypeOfRoom = TypeOfRoom.Kitchen,
                Area = 12,
                WindowsCount = 1,
                DoorsCount = 1,
                Furnitures = GetFurnituresKitchen()
            };
            var room3 = new Room
            {
                Name = "Спальня",
                TypeOfRoom = TypeOfRoom.Bedroom,
                Area = 15,
                WindowsCount = 1,
                DoorsCount = 1,
                Furnitures = GetFurnituresBedroom1()
            };
            var room4 = new Room
            {
                Name = "Коридор",
                TypeOfRoom = TypeOfRoom.Hall,
                Area = 8,
                WindowsCount = 0,
                DoorsCount = 4,
                Furnitures = GetFurnituresHall()
            };

            var rooms = new[] {room1, room2, room3, room4};
            return rooms;
        }

        private static Furniture[] GetFurnituresHall()
        {
            var furniture1 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Cupboard,
                Color = Color.Brown,
                Number = 1,
                Size = null
            };
            var furniture2 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Mirror,
                Color = Color.Undefined,
                Number = 1,
                Size = new Size
                {
                    Wight = 0.2,
                    Height = 2,
                    Length = 1
                }
            };

            var furnitures = new[] {furniture1, furniture2};
            return furnitures;
        }


        private static Furniture[] GetFurnituresBedroom1()
        {
            var furniture1 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Bed,
                Color = Color.Beige,
                Number = 1,
                Size = new Size
                {
                    Wight = 2,
                    Height = 0.6,
                    Length = 2
                }
            };
            var furniture2 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.BedsideTable,
                Color = Color.Beige,
                Size = new Size
                {
                    Wight = 0.6,
                    Height = 0.8,
                    Length = 1
                }
            };

            var furniture3 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Cupboard,
                Color = Color.White,
                Size = new Size
                {
                    Wight = 0.6,
                    Height = 2.5,
                    Length = 3
                }
            };

            var furnitures = new[] {furniture1, furniture2, furniture3};
            return furnitures;
        }

        private static Furniture[] GetFurnituresBathroom()
        {
            var furniture1 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Bath,
                Number = 1,
                Size = new Size
                {
                    Length = 1.5,
                    Wight = 0.6
                },
                Color = Color.White
            };
            var furniture2 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Toilet
            };
            var furniture3 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Mirror
            };

            var furnitures = new[] {furniture1, furniture2, furniture3};
            return furnitures;
        }

        private static Furniture[] GetFurnituresKitchen()
        {
            var furniture1 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Cupboard,
                Color = Color.White,
                Number = 1,
                Size = new Size
                {
                    Wight = 0.6,
                    Height = 2,
                    Length = 2
                }
            };
            var furniture2 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Chair,
                Color = Color.Black,
                Number = 4,
                Size = null
            };
            var furniture3 = new Furniture
            {
                TypeOfFurniture = TypeOfFurniture.Table,
                Color = Color.Brown,
                Number = 1,
                Size = new Size
                {
                    Wight = 1,
                    Height = 1,
                    Length = 2
                }
            };

            var furnitures = new[] {furniture1, furniture2, furniture3};
            return furnitures;
        }
    }
}