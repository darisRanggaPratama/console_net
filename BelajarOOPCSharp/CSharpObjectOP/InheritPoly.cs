namespace GameOOP
{
	public class Figure
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

		public Figure(string name, int health, int attackPower)
		{
			Name = name;
			Health = health;
			AttackPower = attackPower;
		}

		public virtual void Attack(Figure target)
		{
			Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
			target.Health -= AttackPower;
			Console.WriteLine($"{target.Name} has {target.Health} health left.");
			Console.WriteLine();
		}

		// Overloaded method
		public void Attack(Figure target, int multiplier)
		{
			int totalDamage = AttackPower * multiplier;
			Console.WriteLine($"{Name} attacks {target.Name} by multilevel attack (x{multiplier}) Total Damage: {totalDamage}");
			target.Health -= totalDamage;
			Console.WriteLine($"{target.Name} has {target.Health} health left.");			
		}
	}

	public class GoodGuy : Figure
	{
		public GoodGuy(string name, int health, int attackPower) : base(name, health, attackPower)
		{
		}
		public override void Attack(Figure target)
		{
			Console.WriteLine($"{Name} attacks {target.Name} with a sword for {AttackPower} damage!");
			base.Attack(target);
		}
	}

	public class  BadGuy : Figure 
	{
		public BadGuy(string name, int health, int attackPower) : base(name, health, attackPower)
		{
		}

		public override void Attack(Figure target)
		{
			Console.WriteLine($"{Name} attacks {target.Name} with a magic spell for {AttackPower} damage!");
			base.Attack(target);
		}
	}
}
