namespace CodeCompare
{
	class Program
	{
		private static void Main()
		{
			var vb = new VBLib.Demos();

			var vbResult = vb.LoadFile();

			Console.WriteLine("VB.Net Call");
			foreach (var item in vbResult)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();
			Console.WriteLine();

			var csharp = new CSharpLib.Demos();
			var csharpResult = csharp.LoadFile();
			Console.WriteLine("C# Call");
			foreach (var item in csharpResult)
			{
				Console.WriteLine(item);
			}
		}
	}
}

