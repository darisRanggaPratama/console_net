using oopCsharp6;

namespace DeprAngkaThn
{
    class AngkaTahun : DepresiasiAktiva
    {
        // Enkapsulasi: Private variable
        private string nama, metode;

        public AngkaTahun(string nama, string metode)
        {
            // Constructor
            this.nama = nama;
            this.metode = metode;
        }

        // Enkapsulasi: getter
        public string name
        {
            get { return nama; }
        }

        public string method
        {
            get { return metode; }
        }

        // Polymorphism: Overriding
        public override double Depresiasi()
        {
            Console.WriteLine($"\nCode: C#\nAset: {name}");
            Console.WriteLine($"Metode: {method}");
            Console.Write("Nilai Aset: ");
            double aset = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai Akhir: ");
            double nilaiSisa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Umur Ekonomis: ");
            int umur = Convert.ToInt16(Console.ReadLine());
            Depresiasi(aset, nilaiSisa, umur);
            return 0;
        }

        // Polymorphism: Overloading
        void Depresiasi(double nominal, double residu, int masa)
        {
            if (nominal < 1 || residu < 0 || masa < 1)
            {
                Console.WriteLine($"Input Salah. Nominal {nominal}. Residu {residu}. Masa {masa}");
            }
            else
            {
                double aset = Math.Abs(nominal);
                double saldo = Math.Abs(residu);
                double dsrHitung = aset - saldo;
                int waktu = Math.Abs(masa);

                double angka = ((1.0 + Convert.ToDouble(waktu)) / 2.0) * waktu;
                int x;
                int y = 0;
                Console.WriteLine("\n\nThn  Hitung                Depresiasi/Thn  Beban Depresiasi\n");

                for (x = waktu; x > 0; x--)
                {
                    y++;
                    double rate = Convert.ToDouble(x) / angka;

                    double susut = rate * dsrHitung;
                    double sisa = dsrHitung - susut;

                    // Format output string
                    string dasarHit = String.Format("{0,12:N2}", dsrHitung);
                    string txtSusut = String.Format("{0,12:N2}", susut);
                    string txtSisa = String.Format("{0,12:N2}", sisa);

                    string text = String.Format("{0}.  {1} / {2} x {3} = {4} | {5} ", y, x, angka, dasarHit, txtSusut,
                        txtSisa);
                    Console.WriteLine(text);
                }
            }
        }
    }
}