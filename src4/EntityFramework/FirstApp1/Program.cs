using FirstApp1;

using (var db = new ApplicationContext())
{
	var users = db.Users.ToList();
	Console.WriteLine("Список пользователей:");
	foreach (var u in users) Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
}