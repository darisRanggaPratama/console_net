Imports VBNetObjectOP.GameOOP

Namespace GeneralObject
	Public Class Person
		Private name As String = ""
		Private age As Integer = 0

		Public Property Named As String
			Get
				Return name
			End Get

			Set(value As String)
				name = value
			End Set
		End Property

		Public Property Aging As Integer
			Get
				Return age
			End Get
			Set(value As Integer)
				If value >= 0 Then
					age = value
				Else
					Throw New ArgumentException("Age cannot be negative")
				End If
			End Set
		End Property

		Public Sub Introduce()
			Console.WriteLine($"Hello, my name is {name} and I am {age} years old.")
		End Sub
	End Class

	Public Class Program
		Public Shared Sub Main(args As String())
			Dim p1 As New Person()
			p1.Named = "Tama"
			p1.Aging = 40
			p1.Introduce()
			Console.ReadLine()

			' Class and Object
			Dim hero As New GameOOP.Character("Hero", 100, 20)
			Dim monster As New GameOOP.Character("Monster", 100, 15)
			hero.Attack(monster)
			monster.Attack(hero)
			Console.ReadLine()

			' Inheritance and Encapsulation
			Dim ranger As New GameOOP.Ranger("Ranger", 100, 25)
			Dim villain As New GameOOP.Villain("Villain", 100, 30)
			ranger.Attack(villain)
			villain.Attack(ranger)
			Console.ReadLine()

			' Inheritance and Polymorphism
			Dim figures As Figure() = {
				New GoodGuy("Thor", 100, 20),
				New BadGuy("RedSkull", 100, 25),
				New BadGuy("Thanos", 100, 30)
			}

			' Polymorphic calls (overriding in action)
			For each attacker In figures
				For Each target In figures
					If attacker IsNot target Then
						attacker.Attack(target)
					End If
				Next
			Next

			Console.WriteLine()

			' Overloading in action
			' GoodGuy attacks BadGuy with multiplier
			figures(0).Attack(figures(1), 2)

		End Sub
	End Class
End Namespace
