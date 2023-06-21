using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp3;

[NotMapped] //исключить сущность из модели (Аннотации)
public class Company
{
	public int Id { get; set; }
	public string? Name { get; set; }
}