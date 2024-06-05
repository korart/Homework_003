namespace Homework_003
{
	internal class FactoryAF
	{
		private Stack<Car> cars = [];
		public List<Customer> Customers = [];


		public void AddCar()
		{
			cars.Push(new Car());
		}

		public void SaleCar()
		{
			foreach (Customer customer in Customers)
			{
				if (cars.Count != 0)
				{
					customer.Car = cars.Pop();
				}
				else
				{
					break;
				}
			}
			cars.Clear();
		}

		public void Info()
		{
            Console.WriteLine("CARS LIST");
			Console.WriteLine("_________");
			if (cars.Count > 0)
			{
				cars.ToList().ForEach(car => Console.WriteLine(car));
			}
			else
			{
				Console.WriteLine("There are no items in the list");
			}
			Console.WriteLine();


			Console.WriteLine("CUSTOMERS LIST");
			Console.WriteLine("______________");
			if (Customers.Count > 0)
			{
				Customers.ForEach(customer => Console.WriteLine(customer));
			}
			else
			{
				Console.WriteLine("There are no items in the list");
			}
			Console.WriteLine();

		}
	}
}
