Namespace GameOOP
	Public Class Character
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
				health = If(value >= 0, value, 0)
			End Set
		End Property

		Public Property AttackPowers As Integer
			Get
				Return attackPower
			End Get
			Set(value As Integer)
				attackPower = If(value >= 0, value, 0)
			End Set
		End Property

		Public Sub New(name As String, health As Integer, attackPower As Integer)
			Named = name
			Healths = health
			AttackPowers = attackPower
		End Sub

		Public Sub Attack(target As Character)
			Console.WriteLine($"{Named} attacks {target.Named} for {AttackPowers} damage!")
			target.Healths -= attackPower
			Console.WriteLine($"{target.Named} has {target.Healths} health left.")
		End Sub

	End Class
End Namespace
