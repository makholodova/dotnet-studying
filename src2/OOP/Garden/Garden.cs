namespace OOP.Garden;

public class Garden
{
	public int Area { get; set; }
	public string Address { get; set; }
	public Size Size { get; set; }
	public Animal[] Animals { get; set; }
	public Plant[] Plants { get; set; }
	public Flower[] Flowers { get; set; }
	

	public override string ToString()
	{
		var result = $"Garden area is {Area},Address: {Address}, {Size}," +
		             $"\r\n Count type of Animals : {Animals.Length} ";
		foreach (var animal in Animals)
		{
			result += $"\r\n{animal.ToString()}";
		}

		result += $"\r\n Count type of Plants : {Plants.Length}";
		foreach (var plant in Plants)
		{
			result +=$"\r\n{plant.ToString()}";
		}

		result += $" \r\n Count type of Flowers : {Flowers.Length}";
		foreach (var flower in Flowers)
		{
			result += $"\r\n{flower.ToString()}";
		}
		return result;
	}
}