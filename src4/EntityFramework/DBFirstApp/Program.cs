﻿using DBFirstApp;
 
using (HelloappContext db = new HelloappContext())
{
	// получаем объекты из бд и выводим на консоль
	var users = db.Users.ToList();
	Console.WriteLine("Список объектов:");
	foreach (User u in users)
	{
		Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
	}
}

