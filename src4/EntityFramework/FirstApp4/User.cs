namespace FirstApp4;

public class User
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Age { get; set; }
 
	public User(string name, int age)
	{
		Name = name;
		Age = age;
		Console.WriteLine($"Вызов конструктора для объекта {name}");
	}
}