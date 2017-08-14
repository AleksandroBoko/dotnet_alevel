using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
  
            
            Console.WriteLine("---------Loop FOR - Create Mark by User---------");
            bool result = false;
            while (!result)
            {
                Console.WriteLine("Write a count of rows:");
                int countRow = int.Parse(Console.ReadLine());
                Console.WriteLine("Write a count of column:");
                int countColumn = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (countRow + countRow - 1 == countColumn)
                {
                    result = true;
                    for (int i = 0; i < countRow; i++)
                    {
                        for (int j = 0; j < countColumn; j++)
                        {
                            if (i == j || (i + j == countColumn - 1))
                                Console.Write("X");
                            else
                                Console.Write("0");
                        }
                        Console.WriteLine();
                    }
                }
            }
            

            Console.ReadKey();
        }
    }
}
