namespace arr_linq_bsc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Ciptakan array dengan kapasitas 10 elemen yang berisi angka random dari 0 sampai dengan 100
			int[] numbers = new int[10];
			Random random = new Random();

			// Ciptakan array dengan kapasitas 10 elemen yang berisi tipe data string, seperti: rangga, antika, oyen, nizham, mochi, haifa, panther, mikasa ackerman, levi ackerman, eren jeager, armin
			string[] names = new string[] { "rangga", "antika", "oyen", "nizham", "mochi", "haifa", "panther", "mikasa ackerman", "levi ackerman", "eren jeager", "armin" };


			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = random.Next(0, 101);
			}

			// Ambil elemen array yang bernilai kurang dari 50 menggunakan LINQ
			var lessThan50 = from number in numbers
							 where number < 50
							 select number;
			Console.WriteLine("Less than 50:");
			foreach (var item in lessThan50)
			{
				Console.WriteLine(item);
			}

			// Ambil elemen array yang bernilai lebih dari 50 dan bernilai ganjil
			var greaterThan50AndOdd = from number in numbers
									  where number > 50 && number % 2 != 0
									  select number;
			Console.WriteLine("\nGreater than 50 and odd:");
			foreach (var item in greaterThan50AndOdd)
			{
				Console.WriteLine(item);
			}

			// Ambil 1 elemen array yang bernilai 10 jika ada
			var ten = numbers.FirstOrDefault(x => x == 10);
			if (ten != 0)
			{
				Console.WriteLine("\nThe first element with the value of 10 is: " + ten);
			}
			else
			{
				Console.WriteLine("\nThere is no element with the value of 10 in the array.");
			}

			/*
			 STRING DATA TYPE
			 */

			// Ambil elemen array yang memiliki 2 kata
			var twoWords = from name in names
						   where name.Split().Length == 2
						   select name;
			Console.WriteLine("Names with 2 words:");
			foreach (var item in twoWords)
			{
				Console.WriteLine(item);
			}

			// Ambil elemen array yang berawalan huruf a
			var startsWithA = from name in names
							  where name.StartsWith("a")
							  select name;
			Console.WriteLine("\nNames starting with the letter 'a':");
			foreach (var item in startsWithA)
			{
				Console.WriteLine(item);
			}

			// Ambil 1 elemen array yang bernilai rangga
			var rangga = names.FirstOrDefault(x => x == "rangga");
			if (rangga != null)
			{
				Console.WriteLine("\nThe first element with the value of 'rangga' is: " + rangga);
			}
			else
			{
				Console.WriteLine("\nThere is no element with the value of 'rangga' in the array.");
			}

			Console.ReadLine();
		}
	}
}