namespace GameOOP
{
	// Class & Object
	public class Character
	{
		private string name = "";
		private int health = 0;
		private int attackPower = 0;

		public string Name
		{
			get => name;
			set => name = value;
		}

		public int Health
		{
			get => health;
			set => health = value > 0 ? value : 0;
		}

		public int AttackPower
		{
			get => attackPower;
			set => attackPower = value > 0 ? value : 0;
		}

		public Character(string name, int health, int attackPower)
		{
			Name = name;
			Health = health;
			AttackPower = attackPower;
		}

		public void Attack(Character target)
		{
			Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
			target.Health -= AttackPower;
			Console.WriteLine($"{target.Name} has {target.Health} health left.");
		}
	}
}
