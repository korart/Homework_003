namespace Homework_003
{
	internal class Car
	{
		private readonly Engine engine;

		public int Number { get; set; }

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
		}

		public override string ToString()
		{
			return $"Car No: {Number,-2}, Engine size: {Engine.Size}";
		}
	}
}
