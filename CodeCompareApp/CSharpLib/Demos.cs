namespace CSharpLib
{
	public class Demos : IDemos
	{
		// C# code: Method to load file
		public List<string> LoadFile()
		{
			List<string> output = new();
			var lines = File.ReadAllLines(path: @"D:\up2github\console_net\CodeCompareApp\test.txt").ToList();

			for (var i = 0; i < lines.Count; i++)
			{
				if (i % 2 == 0)
				{
					output.Add(lines[i]);
				}
			}
			return output;
		}

		public void PrintFullName(string firstName, string lastName)
		{
			Console.WriteLine($"{firstName} {lastName}");
		}
	}
}
