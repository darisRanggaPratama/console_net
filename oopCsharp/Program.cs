using DeprAngkaThn;
using oopCsharp6;

namespace Program
{
    class DepresiasiHitung
    {
        static void Main(string[] args)
        {
            IDepresiasi dep = new AngkaTahun("mesin", "Angka Tahun");
            dep.Depresiasi();           
        }
    }
}