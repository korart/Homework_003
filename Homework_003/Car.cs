namespace Homework_003
{
	internal class Car
	{
		private static int carCounter;

		private readonly int number;
		private readonly Engine engine;

		public int Number
		{
			get
			{
				return number;
			}
		}

		public Engine Engine
		{
			get
			{
				return engine;
			}
		}

		public Car()
		{
			engine = new();
			engine.Size = new Random().Next(1, 11);
			carCounter++;
			number = carCounter;
		}

		public override string ToString()
		{
			return $"Car No: {Number,-2}, Engine size: {Engine.Size}";
		}
	}
}
