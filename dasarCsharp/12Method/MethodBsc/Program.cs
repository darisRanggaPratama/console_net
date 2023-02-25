namespace MethodBasic
{
    class Methods
    {
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

            // Default Parameter
            DefaultParameter("rangga");
            DefaultParameter("tama", 3);

            // Named Arguments
            Lingkaran(nama: "tabung", jari: 14, tinggi: 10);
            Lingkaran(nama: "kerucut", tinggi: 20, jari: 21);
            Lingkaran(jari: 14);

            // Overloading
            Console.WriteLine(PersegiPanjang(12, 5));
            Console.WriteLine(PersegiPanjang(12, 5, 10));
        }

        // Method tidak memiliki parameter dan kembalian (return)
        private static void LuasPersegiPanjang()
        {
            decimal panjang = 9;
            decimal lebar = 8;
            decimal luas = panjang * lebar;
            Console.WriteLine($"\nLuas Persegi Panjang:\nPanjang: {panjang} X Lebar: {lebar} = {luas}\n");
        }

        // Method tidak memiliki parameter tapi memiliki kembalian (return)
        private static string VolumeKubus()
        {
            decimal sisi = 9;
            decimal volume = sisi * sisi * sisi;
            return $"\nVolume Kubus. {sisi}^3 = {volume}\n";
        }

        // Method memiliki parameter dan return
        private static decimal VolumeBalok(decimal panjang, decimal lebar, decimal tinggi)
        {
            decimal volume = panjang * lebar * tinggi;
            Console.Write($"\nVolume Balok.\nPanjang: {panjang} X Lebar: {lebar} X Tinggi: {tinggi} = ");
            return volume;
        }

        // Method memiliki parameter dan tanpa return
        private static void LuasPersegi(decimal sisi)
        {
            decimal luas = sisi * sisi;
            Console.WriteLine($"\nLuas Persegi:\nSisi: {sisi}^2 = {luas}\n");
        }

        // Default Parameter
        private static void DefaultParameter(string text, int loop = 1)
        {
            for (int x = 0; x < loop; x++)
            {
                Console.WriteLine($"{text}");
            }
        }

        // Named Arguments
        private static void Lingkaran(double jari, double tinggi = 1, string nama = "lingkaran")
        {
            decimal pi = Convert.ToDecimal(22.0 / 7.0);
            decimal sepertiga = Convert.ToDecimal(1.0 / 3.0);
            decimal Jari = Convert.ToDecimal(jari);
            decimal Tinggi = Convert.ToDecimal(tinggi);

            if (nama == "lingkaran")
            {
                decimal lingkaran = pi * Jari * Jari;
                Console.WriteLine($"\nLuas Lingkaran:\nJari-jari: {jari} itu {lingkaran}");
            }
            else if (nama == "tabung")
            {
                decimal tabung = pi * Jari * Jari * Tinggi;
                Console.WriteLine($"\nVolume Tabung:\nJari-jari: {jari}. Tinggi: {tinggi} itu {tabung}");
            }
            else if (nama == "kerucut")
            {
                decimal kerucut = pi * sepertiga * Jari * Jari * Tinggi;
                Console.WriteLine($"\nVolume Kerucut:\nJari-jari: {jari}. Tinggi: {tinggi} itu {kerucut}");
            }
        }

        // Method overloading
        private static string PersegiPanjang(int panjang, int lebar)
        {
            int persegiPanjang = panjang * lebar;
            return
                $"\nLuas Persegi Panjang.\nPanjang: {panjang.ToString()} Lebar: {lebar.ToString()} itu {persegiPanjang}\n";
        }

        private static string PersegiPanjang(double panjang, double lebar, double tinggi)
        {
            double balok = panjang * lebar * tinggi;
            return
                $"\nVolume Balok.\nPanjang: {panjang.ToString()} Lebar: {lebar.ToString()} Tinggi: {tinggi.ToString()} itu {balok}\n";
        }
    }
}