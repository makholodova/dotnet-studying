using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp3;

public class User
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public int Age { get; set; }
	// навигационное свойство
	public Company? Company { get; set; }
	/*[NotMapped]*/ //исключить определенное свойство, чтобы для него не создавался столбец в таблице (Аннотации)
	public string? Address { get; set; }
}