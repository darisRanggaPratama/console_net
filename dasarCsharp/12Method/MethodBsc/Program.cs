namespace MethodBasic
{
	class Methods
	{
		private static decimal panjang, lebar, sisi, luas, volume;

		static void Main(string[] args)
		{
			// Method. Void Return
			LuasPersegiPanjang();
			// Method. Value Return
			Console.WriteLine(VolumeKubus());
			// Function (Method has parameter and return)
			Console.WriteLine(VolumeBalok(7, 8, 9));
			// Function (Method has parameter and void return)
			LuasPersegi(7);
		}

		private static void LuasPersegiPanjang()
		{
			panjang = 9; lebar = 8;
			luas = panjang * lebar;
			Console.WriteLine($"\nLuas Persegi Panjang:\nPanjang: {panjang} X Lebar: {lebar} = {luas}\n");
		}

		private static string VolumeKubus()
		{
			sisi = 9;
			volume = sisi * sisi * sisi;
			return $"\nVolume Kubus. {sisi}^3 = {volume}\n";
		}

		private static decimal VolumeBalok(decimal panjang, decimal lebar, decimal tinggi)
		{
			volume = panjang * lebar * tinggi;
			Console.Write($"\nVolume Balok.\nPanjang: {panjang} X Lebar: {lebar} X Tinggi: {tinggi} = ");
			return volume;
		}

		private static void LuasPersegi(decimal sisi)
		{
			luas = sisi * sisi;
			Console.WriteLine($"\nLuas Persegi:\nSisi: {sisi}^2 = {luas}\n");
		}
	}
}
