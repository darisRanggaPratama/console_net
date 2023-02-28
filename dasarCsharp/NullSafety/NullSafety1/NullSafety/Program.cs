namespace Nullable
{
    class NullSafety
    {
        static void Main(string[] args)
        {
            string name = "Jhon Doe";
            string? nullName = null;

            // 1. Cek nilai null
            if (nullName != null)
            {
                Console.WriteLine($"Name: {nullName}");
            }
            else
            {
                Console.WriteLine("Name is Null");
            }

            // 2. Cek Null (null coalescing)
            string defaultOrName = nullName ?? "DefaultName";
            Console.WriteLine($"Name: {defaultOrName}");
            
            // 3. Menggunakan null propagation operator untuk menghindari NullReferenceException
            int? panjang = nullName?.Length;
            Console.WriteLine($"Name Length: {(panjang.HasValue ? panjang.ToString() : "null")}");


        }
    }
}