namespace GameOOP
{
	// Inheritance and Encapsulation
	public class Personel
	{
        private string name = "";
        private int health;
        private int attackPower;

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

		public Personel(string name, int health, int attackPower)
		{
			Name = name;
			Health = health;
			AttackPower = attackPower;
		}

		public virtual void Attack(Personel target)
		{			
			target.Health -= AttackPower;
			Console.WriteLine($"{target.Name} has {target.Health} health left.");
		}
	}

	public class Ranger : Personel 
	{
		public Ranger(string name, int health, int attackPower) : base(name, health, attackPower)
		{
		}

		public override void Attack(Personel target)
		{
			Console.WriteLine($"{Name} shoots an arrow at {target.Name} for {AttackPower} damage!");
			base.Attack(target);
		}
	}

	public class Villain : Personel
	{
		public Villain(string name, int health, int attackPower) : base(name, health, attackPower)
		{
		}
		public override void Attack(Personel target)
		{
			Console.WriteLine($"{Name} casts a dark spell on {target.Name} for {AttackPower} damage!");
			base.Attack(target);
		}
	}
}
