namespace Homework_003
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FactoryAF factory = new();

			GenerateCustomers(factory, count: 2);
			GenerateCars(factory, count: 3);

			Console.WriteLine("************* BEFORE SaleCar() *************");
			factory.Info();

			factory.SaleCar();

			Console.WriteLine("************** AFTER SaleCar() *************");
			factory.Info();
		}

		
		static void GenerateCustomers(FactoryAF factory, int count)
		{
			List<string> names = GetNamesList();

			for (int i = 0; i < count; i++)
			{
				Customer customer = new Customer();
				customer.FIO = GetRandomName(names);
				factory.Customers.Add(customer);
			}
		}


		static void GenerateCars(FactoryAF factory, int count)
		{
			for (int i = 0;i < count; i++)
			{
				factory.AddCar();
			}
		}


		static string GetRandomName(List<string> names)
		{
			Random random = new();
			return (string)names[random.Next(names.Count)];
		}


		static List<string> GetNamesList()
		{
			List<string> names = [];
			using (StreamReader reader = new StreamReader(@".\names.csv"))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine()!;
					string[] values = line.Split(',');

					names.Add(values[1] + " " + values[2]);
				}
			}
			return names;
		}
	}
}
