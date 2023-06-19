namespace FirstApp3;

public class User
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public int Age { get; set; }
	// навигационное свойство
	public Company? Company { get; set; }
}