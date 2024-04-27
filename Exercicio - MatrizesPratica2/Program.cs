using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___MatrizesPratica2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine().Split(' ');
            int n1 = int.Parse(line[0]);
            int n2 = int.Parse(line[1]);

            int[,] mat = new int[n1, n2];

            for (int i = 0; i < n1; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n2; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int position = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (mat[i, j] == position)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n2 - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < n1 - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
