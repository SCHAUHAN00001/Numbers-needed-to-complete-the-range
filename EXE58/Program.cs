using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 1, 3, 7, 15, 100 };
            int Max = numbers[0];
            int Min = numbers[0];
            foreach (int number in numbers)
            {
                if (number < Min)

                    Min = number;

                if (number > Max)

                    Max = number;
            }
                
            int count = 0;
                for(int i = Min + 1; i < Max; i++)
                {
                    if (!numbers.Contains(i))
                    
                        count++;
                    

                }
                Console.WriteLine(count);
                Console.ReadLine();

            
        }
    }
}
