using System.Globalization;
using System.Text.RegularExpressions;
using FirstApp4;

using (ApplicationContext db = new ApplicationContext())
{
	db.Database.EnsureDeleted();
	db.Database.EnsureCreated();
     
	User tom = new User("Tom", 37);
	User bob = new User("Bob", 41);
	db.Users.Add(tom);
	db.Users.Add(bob);
	db.SaveChanges();
}
using (ApplicationContext db = new ApplicationContext())
{
	Console.WriteLine("Получение данных из БД");
	var users = db.Users.ToList();
	foreach(var user in users)
		Console.WriteLine($"{user.Name} - {user.Age}");
}

Messenger<Message, Person> telegram = new Messenger<Message, Person>();
Person tom1 = new Person("Tom");
Person bob1 = new Person("Bob");
Message hello = new Message("Hello, Bob!");
telegram.SendMessage(tom1, bob1, hello);

DateTime now = DateTime.Now;
Console.WriteLine(now.ToString("h:mm:ss tt "));
Console.WriteLine(now.ToString("dd.MM.yy"));
var dateOnly = new DateOnly(2220,02,05,new JapaneseCalendar());
Console.WriteLine(dateOnly);
Console.WriteLine(dateOnly.Year);

List<string> people = new List<string>() {"Eugene", "Tom", "Mike", "Sam", "Bob" };
 
// получаем диапазон со второго по четвертый элемент
var range = people.GetRange(1, 3);
// range = { "Tom", "Mike", "Sam"};
 
// копируем в массив первые три элемента
string[] partOfPeople = new string[3];
people.CopyTo(2,partOfPeople,0,2);
foreach(var a in partOfPeople) Console.WriteLine(a);
// partOfPeople = { "Eugene", "Tom", "Mike"};
string s1= new string('c',6);


string s5 = "apple";
string s6 = "a day";
string s7 = "keeps";
string s8 = "a doctor";
string s9 = "away";
string[] values = new string[] { s5, s6, s7, s8, s9 };
 
string s10 = string.Join(" ",values);
Console.WriteLine(s10); // apple a day keeps a doctor away

string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
//Range teg = new Range("бык");
Regex regex = new Regex(@"туп(\w*)");
MatchCollection matches = regex.Matches(s);
if (matches.Count > 0)
{
	foreach (Match match in matches)
		Console.WriteLine(match.Value);
}
else
{
	Console.WriteLine("Совпадений не найдено");
}
int x = 5;
int y = x / 0;
Console.WriteLine($"Результат: {y}");
Console.WriteLine("Конец программы");