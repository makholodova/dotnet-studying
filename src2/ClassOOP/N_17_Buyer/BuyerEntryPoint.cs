using System;

namespace ClassOOP.N_17_Buyer
{
	public class BuyerEntryPoint : IEntryPoint

	{
		public void Start()
		{
			var buyers = new Buyer[5];
			buyers[0] = new Buyer("Петров", "Иван", "Васильевич", "Чапаева_3", 78541, 125846);
			buyers[1] = new Buyer("Егорова", "Мария", "Кирилловна", "Кирова_15", 12548, 586952);
			buyers[2] = new Buyer("Куделько", "Ирина", "Владиславовна", "Володина_8", 87413, 168786);
			buyers[3] = new Buyer("Холодов", "Дмитрий", "Геннадьевич", "Плехуна_26", 35471, 985147);
			buyers[4] = new Buyer("Пятенко", "Анастасия", "Дмитриевна", "Сормовская_74", 55415, 857413);
			SortByFullName(buyers);

			foreach (var buyer in buyers)
			{
				Console.WriteLine($"{buyer}");
			}

			Console.WriteLine("Cписок покупателей, у которых номер кредитной карточки находится в заданном диапазоне: ");

			RangeByCreditCardNumber(buyers);
		}

		private static void RangeByCreditCardNumber(Buyer[] buyers)
		{
			Console.WriteLine("Введите диапозон номеров кредитных карт: ");
			var num1Str = Console.ReadLine();
			var num1 = int.Parse(num1Str);
			var num2Str = Console.ReadLine();
			var num2 = int.Parse(num2Str);
			for (var i = 0; i < buyers.Length; i++)
			{
				if (buyers[i].CreditCardNumber > num1 && buyers[i].CreditCardNumber < num2)
				{
					Console.WriteLine($"{buyers[i]}");
				}
			}
		}

		private static void SortByFullName(Buyer[] buyers)
		{
			for (var i = 0; i < buyers.Length; i++)
			{
				for (var j = 0; j < buyers.Length - i - 1; j++)
				{
					var buyers1 = buyers[j];
					var fullName1 = buyers1.FullName;
					var buyers2 = buyers[j + 1];
					var fullName2 = buyers2.FullName;
					var isFirstName = string.Compare(fullName1, fullName2);
					if (isFirstName > 0)
					{
						buyers[j] = buyers2;
						buyers[j + 1] = buyers1;
					}
				}
			}
		}
	}
}