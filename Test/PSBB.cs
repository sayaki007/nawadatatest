using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawaDataTest.Test
{
    public class PSBB
    {
        public static int GetNumberOfFamilies()
        {
            Console.Write("Input the number of families : ");
            return int.Parse(Console.ReadLine());
        }

        public static int[] GetFamilySizes(int numberOfFamilies)
        {
            Console.Write("Input the number of members in the family (separated by a space) : ");
            string[] input = Console.ReadLine().Split();
            return input.Select(int.Parse).ToArray();
        }

        public static int CalculateMinimumBuses(int[] familySizes)
        {
            Array.Sort(familySizes);
            Array.Reverse(familySizes);

            int buses = 0;
            bool[] used = new bool[familySizes.Length];

            for (int i = 0; i < familySizes.Length; i++)
            {
                if (used[i])
                    continue;

                buses++;
                used[i] = true;

                int remainingSeats = 4 - familySizes[i];

                for (int j = familySizes.Length - 1; j > i; j--)
                {
                    if (!used[j] && familySizes[j] <= remainingSeats)
                    {
                        used[j] = true;
                        break;
                    }
                }
            }

            return buses;
        }

        public void Buses()
        {
            int numberOfFamilies = GetNumberOfFamilies();
            int[] familySizes = GetFamilySizes(numberOfFamilies);

            if (familySizes.Length != numberOfFamilies)
            {
                Console.WriteLine("Input must be equal with count of family");
                return;
            }

            int minimumBuses = CalculateMinimumBuses(familySizes);
            Console.WriteLine($"Minimum bus required is : {minimumBuses}");
        }
    }
}
