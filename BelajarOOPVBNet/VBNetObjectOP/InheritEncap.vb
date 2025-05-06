Namespace GameOOP
	Public Class Personel
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

		Public sub New(name As String, health As Integer, attackPower As Integer)
			Named = name
			Healths = health
			AttackPowers = attackPower
		End sub

		Public Overridable Sub Attack(target As Personel)
			target.Healths -= AttackPowers
			Console.WriteLine($"{target.Named} has {target.Healths} health left.")
		End Sub
	End Class

	Public Class Ranger
		Inherits Personel

		Public Sub New(name As String, health As Integer, attackPower As Integer)
			MyBase.New(name, health, attackPower)
		End Sub

		Public Overrides Sub Attack(target As Personel)
			Console.WriteLine($"{Named} shoots an arrow at {target.Named} for {AttackPowers}")
			MyBase.Attack(target)
		End Sub
	End Class

	Public Class Villain
		Inherits Personel

		Public Sub New(name As String, health As Integer, attackPower As Integer)
			MyBase.New(name, health, attackPower)
		End Sub

		Public Overrides Sub Attack(target As Personel)
			Console.WriteLine($"{Named} casts a spell on {target.Named} for {AttackPowers}")
			MyBase.Attack(target)
		End Sub
	End Class
End Namespace
