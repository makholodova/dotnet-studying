namespace OOP.Bag
{
	public static class BagBuilder
	{
		public static Bag Build()
		{
			// инициализация статических полей
			Bag.SlingsCount = 2;
			Bag.PrintStaticContent();

			// работа с нестатическими полями/свойствами
			var bag = new Bag();
			bag.Volume = 40;
			bag.PocketsCount = 3;
			bag.Color = Color.Black;

			var books = GetBooks();
			bag.Books = books;

			var notebooks = GetNotebooks();
			bag.Notebooks = notebooks;

			var pens = GetPens();
			bag.Pens = pens;

			var pencil = GetPencil();
			bag.Pencils = pencil;


			bag.PrintContent();
			return bag;
		}

		private static Book[] GetBooks()
		{
			var book1 = new Book
			{
				Name = "букварь",
				PageCount = 50,
				Size = new Size
				{
					Height = 30,
					Wight = 40
				}
			};
			var book2 = new Book
			{
				Name = "русский",
				PageCount = 100,
				Size = new Size
				{
					Height = 35,
					Wight = 45
				}
			};
			var books = new Book[2];
			books[0] = book1;
			books[1] = book2;
			return books;
		}

		private static Pen[] GetPens()
		{
			var pen1 = new Pen
			{
				Color = Color.Black,
				Length = 12
			};

			var pen2 = new Pen
			{
				Color = Color.Blue,
				Length = 13
			};
			var pen3 = new Pen
			{
				Color = Color.Red,
				Length = 15
			};
			var pens = new[] {pen1, pen2, pen3};

			return pens;
		}

		private static Pencil[] GetPencil()
		{
			var pencil1 = new Pencil
			{
				Color = Color.Green,
				Length = 10
			};
			var pencil2 = new Pencil
			{
				Color = Color.Orange,
				Length = 11
			};
			var pencil3 = new Pencil
			{
				Color = Color.Purple,
				Length = 12
			};
			var pencil4 = new Pencil
			{
				Color = Color.Yellow,
				Length = 5
			};
			var pencil5 = new Pencil
			{
				Color = Color.Blue,
				Length = 7
			};

			var pencils = new[] {pencil1, pencil2, pencil3, pencil4, pencil5};
			return pencils;
		}

		private static Notebook[] GetNotebooks()
		{
			var notebook1 = new Notebook
			{
				Name = "Русский",
				PageType = PageType.Line,
				PageCount = 12,
				Size = new Size
				{
					Wight = 15,
					Height = 20
				}
			};
			var notebook2 = new Notebook
			{
				Name = "Математика",
				PageType = PageType.Cell,
				PageCount = 24,
				Size = new Size
				{
					Wight = 15,
					Height = 20
				}
			};


			var notebooks = new[] {notebook1, notebook2};
			return notebooks;
		}
	}
}