using FirstApp;

using (var db = new ApplicationContext())

{
	db.Database.EnsureDeleted();
	//db.Database.EnsureCreated();
}

using (var db = new ApplicationContext())

{
	var tom = new User { Name = "Tom", Age = 33 };
	var alice = new User { Name = "Alice", Age = 26 };

	// Добавление
	db.Users.Add(tom);
	db.Users.Add(alice);
	db.SaveChanges();
}

// получение
using (var db = new ApplicationContext())
{
	// получаем объекты из бд и выводим на консоль
	var users = db.Users.ToList();
	Console.WriteLine("Данные после добавления:");
	foreach (var u in users) Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
}

// Редактирование
using (var db = new ApplicationContext())
{
	// получаем первый объект
	var user = db.Users.FirstOrDefault();
	if (user != null)
	{
		user.Name = "Bob";
		user.Age = 44;
		//обновляем объект
		//db.Users.Update(user);
		db.SaveChanges();
	}

	// выводим данные после обновления
	Console.WriteLine("\nДанные после редактирования:");
	var users = db.Users.ToList();
	foreach (var u in users) Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
}

// Удаление
using (var db = new ApplicationContext())
{
	// получаем первый объект
	var user = db.Users.FirstOrDefault();
	if (user != null)
	{
		//удаляем объект
		db.Users.Remove(user);
		db.SaveChanges();
	}

	// выводим данные после обновления
	Console.WriteLine("\nДанные после удаления:");
	var users = db.Users.ToList();
	foreach (var u in users) Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
}