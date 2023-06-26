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
class Messenger<T, P> 
	where T : Message
	where P: Person
{
	public void SendMessage(P sender, P receiver, T message)
	{
		Console.WriteLine($"Отправитель: {sender.Name}");
		Console.WriteLine($"Получатель: {receiver.Name}");
		Console.WriteLine($"Сообщение: {message.Text}");
	}
}
class Person
{
	public string Name { get;}
	public Person(string name) => Name = name;
}
 
class Message
{
	public string Text { get; } // текст сообщения
	public Message(string text) =>  Text = text;
}