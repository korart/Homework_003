namespace Homework_003
{
	internal class Customer
	{
		public string FIO { get; set; } = "";
		public Car? Car { get; set; }

		public override string ToString()
		{
			string carData = "Car: NONE";
			if (Car is not null)
			{
				carData = Car.ToString();
			}
			return $"Customer: {FIO,-20} | {carData}";
		}
	}
}
