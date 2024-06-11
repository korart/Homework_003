namespace Homework_003
{
	internal class FactoryAF
	{
		private readonly Stack<Car> Cars = [];
		public List<Customer>? Customers;


		public void AddCar()
		{
			Cars.Push(new Car());
		}

		public void SaleCar()
		{
			foreach (Customer customer in Customers ?? ([]))
			{
				if (Cars.Count != 0)
				{
					customer.Car = Cars.Pop();
				}
				else
				{
					break;
				}
			}
			Cars.Clear();
		}

		public void Info()
		{
			printList(title: "CARS LIST", Cars.ToList());
			printList(title: "CUSTOMERS LIST", Customers ?? ([]));
		}


		private void printList<T>(string title, List<T> list)
		{
			Console.WriteLine(title.ToUpper());
			Console.WriteLine("_____________________________________________________________");
			if (list.Count > 0)
			{
				list.ForEach(x => Console.WriteLine(x));
			}
			else
			{
				Console.WriteLine("There are no items in the list");
			}
			Console.WriteLine();
		}
	}
}
