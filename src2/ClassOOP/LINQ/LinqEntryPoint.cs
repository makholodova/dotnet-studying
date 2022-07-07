using System.Collections.Generic;
using System.Linq;

namespace ClassOOP.LINQ
{
	public class LinqEntryPoint : IEntryPoint
	{
		public void Start()
		{
			string[] people = {"Tom", "Bob", "Sam", "Tim", "Tomas", "Bill"};

			/*var selectedPeople = new List<string>();
			foreach (var person in people)
			{
				if (person.ToUpper().StartsWith("T"))
				{
					selectedPeople.Add(person);
				}
				
			}
			selectedPeople.Sort();*/

			var selectedPeople = from p in people
				where p.ToUpper().StartsWith("T") 
				orderby p 
				select p;




		}
	}
}