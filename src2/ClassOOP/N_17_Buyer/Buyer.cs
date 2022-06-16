namespace ClassOOP.N_17_Buyer
{
	public class Buyer
	{
		public string Surname { get; private set; }
		public string Name { get; private set; }
		public string MiddleName { get; private set; }
		public string FullName { get; private set; }
		public string Address { get; private set; }
		public int CreditCardNumber { get; private set; }
		public int BankAccountNumber { get; private set; }

		public Buyer(string surname, string name, string middleName, string address, int creditCardNumber, int bankAccountNumber)
		{
			Surname = surname;
			Name = name;
			MiddleName = middleName;
			FullName = Surname + " " + Name + " " + MiddleName;
			Address = address;
			CreditCardNumber = creditCardNumber;
			BankAccountNumber = bankAccountNumber;
		}

		public override string ToString()
		{
			return $"ФИО: {FullName}, адрес: {Address}, номер кредитной карточки: {CreditCardNumber},номер банковского счета: {BankAccountNumber}";
		}
	}
}