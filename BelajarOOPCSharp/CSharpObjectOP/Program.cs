namespace GameOOP
{
	// Class Person
	public class Person
	{
		// Fields
		private string name = "";
		private int age = 0;

		// Properties
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set
			{
				if (value >= 0)
					age = value;
				else
					throw new ArgumentException("Age cannot be negative");
			}
		}

		// Method
		public void Introduce()
		{
			Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
		}
	}

	// Class Program
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of Person
			Person p1 = new Person();
			p1.Name = "Rangga";
			p1.Age = 37;
			// Call the method
			p1.Introduce();
			Console.ReadLine();

			// Class & Object
			Character hero = new Character("Pahlawan", 100, 20);
			Character monster = new Character("Monster", 100, 15);
			hero.Attack(monster);
			monster.Attack(hero);
			Console.ReadLine();

			// Inheritance and Encapsulation
			Ranger ranger = new Ranger("Archer", 100, 25);
			Villain villain = new Villain("Dark Lord", 100, 30);
			ranger.Attack(villain);
			villain.Attack(ranger);
			Console.ReadLine();

			// Inheritance and Polymorphism
			Figure[] figures = new Figure[]
			{
				new GoodGuy("Hulk", 100, 20),
				new BadGuy("Thanos", 100, 25),
				new BadGuy("Loki", 100, 30)
			};

			// Polymorphic calls (overriding in action)
			foreach (var attacker in figures)
			{
				foreach (var target in figures)
				{
					if (attacker != target)
					{
						attacker.Attack(target);
					}
				}
			}

			Console.WriteLine();

			// Overloading in action
			// GoodGuy attacks BadGuy
			figures[0].Attack(figures[1], 2);
		}
	}
}
