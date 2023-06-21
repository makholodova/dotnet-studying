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