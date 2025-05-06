Namespace GameOOP
	Public Class Figure
		Private name As String = ""
		Private health As Integer = 0
		Private attackPower As Integer = 0

		Public Property Named As String
			Get
				Return name
			End Get
			Set(value As String)
				name = value
			End Set
		End Property

		Public Property Healths As Integer
			Get
				Return health
			End Get
			Set(value As Integer)
				If value >= 0 Then
					health = value
				Else
					Throw New ArgumentException("Health cannot be negative")
				End If
			End Set
		End Property

		Public Property AttackPowers As Integer
			Get
				Return attackPower
			End Get
			Set(value As Integer)
				If value >= 0 Then
					attackPower = value
				Else
					Throw New ArgumentException("Attack power cannot be negative")
				End If
			End Set
		End Property

		Public Sub New(name As String, health As Integer, attackPower As Integer)
			Named = name
			Healths = health
			AttackPowers = attackPower
		End Sub

		Public Overridable Sub Attack(target As Figure)
			Console.WriteLine($"{Named} attacks {target.Named} for {AttackPowers} damage.")
			target.Healths -= AttackPowers
			Console.WriteLine($"{target.Named} has {target.Healths} health left.")
			Console.WriteLine()
		End Sub

		' Overloaded method
		Public Sub Attack(target As Figure, multiplier As Integer)
			Dim totalDamage As Integer = AttackPowers * multiplier
			Console.WriteLine($"{Named} attacks {target.Named} by multilevel attack (x{multiplier}) Total Damage: {totalDamage}")
			target.Healths -= totalDamage
			Console.WriteLine($"{target.Named} has {target.Healths} health left.")
		End Sub
	End Class

	Public Class GoodGuy
		Inherits Figure
		Public Sub New(name As String, health As Integer, attackPower As Integer)
			MyBase.New(name, health, attackPower)
		End Sub

		Public Overrides Sub Attack(target As Figure)
			Console.WriteLine($"{Named} attacks {target.Named} with a sword for {AttackPowers} damage.")
			MyBase.Attack(target)
		End Sub
	End Class

	Public Class BadGuy
		Inherits Figure
		Public Sub New(name As String, health As Integer, attackPower As Integer)
			MyBase.New(name, health, attackPower)
		End Sub
		Public Overrides Sub Attack(target As Figure)
			Console.WriteLine($"{Named} attacks {target.Named} with a magic spell for {AttackPowers} damage.")
			MyBase.Attack(target)
		End Sub
	End Class
End Namespace