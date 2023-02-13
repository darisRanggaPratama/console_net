namespace arr_linq_bsc
{
    class Program
    {
        // Ciptakan array dengan kapasitas 10 elemen yang berisi angka random dari 0 sampai dengan 100
        private static int[] numbers = new int[10];
        private static Random random = new Random();

        // Ciptakan array yang berisi tipe data string
        private static string[] names = new string[11];

        static void Main(string[] args)
        {
            SetArrayValue();
            GetNumberUnder(40);
            GetNumberOverAndOdd(70);
            GetNumberValue(10);

            GetMoreWords(3);
            GetFirstWord("e");
            GetName("mochi");

            Console.ReadLine();
        }

        private static void SetArrayValue()
        {
            // Array: integer
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 101);
            }

            // Array: string
            names[0] = "raden rangga pratama";
            names[1] = "antika";
            names[2] = "oyen indra praja";
            names[3] = "nizham";
            names[4] = "mochi";
            names[5] = "haifa";
            names[6] = "panther";
            names[7] = "mikasa ackerman";
            names[8] = "eren jeager";
            names[9] = "levi ackerman";
            names[10] = "armin";
        }

        // Ambil elemen array yang bernilai kurang dari, misal 50 menggunakan LINQ
        private static void GetNumberUnder(int value)
        {
            IEnumerable<int> lessThan = from number in numbers where number < value select number;
            Console.WriteLine($"\nLess than {value}: ");
            foreach (int item in lessThan)
            {
                Console.WriteLine($"{item} ");
            }
        }

        // Ambil elemen array yang bernilai lebih dari 50 dan bernilai ganjil
        private static void GetNumberOverAndOdd(int value)
        {
            IEnumerable<int> overThanNodd =
                from number in numbers where number > value && number % 2 != 0 select number;
            Console.WriteLine($"\nGreater than {value} and odd: ");
            foreach (int item in overThanNodd)
            {
                Console.WriteLine($"{item} ");
            }
        }

        // Ambil 1 elemen array yang bernilai tertentu jika ada
        private static void GetNumberValue(int value)
        {
            int getValue = numbers.FirstOrDefault(x => x == value);
            if (getValue != 0)
            {
                Console.WriteLine($"\nThe first item with the value of {value} is: {getValue}");
            }
            else
            {
                Console.WriteLine($"\nThere is no element with the value of {value} in the array.");
            }
        }

        // Ambil elemen array yang memiliki suku kata tertentu
        private static void GetMoreWords(int value)
        {
            IEnumerable<string> moreWords = from name in names where name.Split().Length == value select name;
            Console.WriteLine($"\nNames with {value} words: ");
            foreach (string item in moreWords)
            {
                Console.WriteLine($"{item} ");
            }
        }

        // Ambil elemen array yang berawalan huruf tertentu
        private static void GetFirstWord(string value)
        {
            IEnumerable<string> startWith = from name in names where name.StartsWith(value) select name;

            Console.WriteLine($"\nNames starting with the letter {value}: ");
            foreach (string item in startWith)
            {
                Console.WriteLine($"{item} ");
            }
        }

        // Ambil 1 elemen array yang bernilai tertentu
        private static void GetName(string value)
        {
            string? name = names.FirstOrDefault(x => x == value);
            if (name != null)
            {
                Console.WriteLine($"\nThe first element with the value of {value} is: {name}");
            }
            else
            {
                Console.WriteLine($"\nThere is no item with the value of {value} in the array");
            }
        }
    }
}