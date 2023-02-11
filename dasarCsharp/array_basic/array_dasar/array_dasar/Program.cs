using System;

namespace array_dasar
{
	class Program
	{
		// Membuat array dengan 5 elemen
		// Array integer
		private static int[] numbers = new int[5];
		// Array string
		private static string[] words = new string[5];

		static void Main(string[] args)
		{
			valueArray();

			ShowArrayNumber();

			ArrayNumberShow();

			// ArrayStringShow();

			// EditArrayString(4, "kontras");

			// ArrayStringAscending();

			// ArrayStringDescending();

			GetItemArrayNumber(2);

			ArrayNumberDelete(3);

			ArrayNumberDeleteAll();

			Console.ReadLine();
		}

		private static void valueArray()
		{
			// Mengisi elemen array (angka) dengan nilai
			numbers[0] = 1;
			numbers[1] = 200;
			numbers[2] = 30;
			numbers[3] = 4000;
			numbers[4] = 15;

			// Array (string)
			words[0] = "rangga";
			words[1] = "antika";
			words[2] = "nizham";
			words[3] = "haifa";
			words[4] = "oyen";
		}

		private static void ShowArrayNumber()
		{
			// Menampilkan elemen array satu per satu
			Console.WriteLine("\nMenampilkan elemen array satu per satu:");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine($"{i}  {numbers[i]}");
			}
		}

		private static void ArrayNumberShow()
		{
			// Cara lain (foreach)
			Console.WriteLine("\nMenampilkan elemen array satu per satu (foreach): ");
			foreach (int number in numbers)
			{
				Console.WriteLine($"  {number}");
			}
		}

		private static void ArrayStringShow()
		{
			System.Console.WriteLine("\nTampilkan item array string(foreach):");
			foreach (string word in words)
			{
				Console.WriteLine(word);
			}
		}

		private static void ShowArrayString()
		{
			Console.WriteLine("\nTampilkan item array string:");
			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine($" {i} {words[i]}");
			}
		}

		private static void EditArrayString(int index, string word)
		{
			ShowArrayString();

			words[index] = word;
			Console.WriteLine($"\nEdit index: {index}. Value: {word}");

			ShowArrayString();
		}

		private static void ArrayStringAscending()
		{
			ShowArrayString();

			Array.Sort(words);
			Console.WriteLine($"\nSort Ascending");

			ShowArrayString();
		}

		private static void ArrayStringDescending()
		{
			ShowArrayString();

			Array.Reverse(words);
			Console.WriteLine($"\nSort Descending");

			ShowArrayString();
		}

		private static void GetItemArrayNumber(int item)
		{
			Console.WriteLine($"\nAmbilkan item di index {item}: {numbers[item]}");
		}

		private static void ArrayNumberDelete(int item)
		{
			ShowArrayNumber();

			numbers = numbers.Where((source, index) => index != item).ToArray();
			System.Console.WriteLine($"\nHapus index ke: {item}");

			ShowArrayNumber();
		}

		private static void ArrayNumberDeleteAll()
		{
			ShowArrayNumber();

			Array.Clear(numbers, 0, numbers.Length);
			System.Console.WriteLine($"\nHapus semua item di array");

			ShowArrayNumber();
		}
	}
}