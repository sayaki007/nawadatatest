using NawaDataTest.Test;


class Program
{
    public static void Main()
    {
        var sc = new SortCharacter();
        var psbb = new PSBB();
        bool run = true;

        while (run)
        {
            Console.WriteLine(".: Menu :.");
            Console.WriteLine("1. Sort Character");
            Console.WriteLine("2. PSBB");
            Console.WriteLine("3. Exit");
            Console.Write("Insert Menu Number : ");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    sc.Sorting();
                    break;

                case "2":
                    psbb.Buses(); 
                    break;

                case "3":
                default:
                    run = false;
                    break;
            }
        }
    }
}