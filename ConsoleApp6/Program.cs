using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args) 
        {
            int number_i;
            int number_i_2;
            double number_a = 0;
            double number_b = 0;
            double number_k = double.Parse(Console.ReadLine());
            double number_n = double.Parse(Console.ReadLine());
            double number_all;
            for (number_i_2 = 0; number_i_2 <= number_n; number_i_2 = number_i_2 + 1)
            {
                number_a = number_a + (Math.Pow(number_n / (number_i_2 + 1) * (number_i_2 + 2), number_i_2));
            }
            for (number_i = 0; number_i <= number_n; number_i = number_i + 1)
            {  
                number_b = number_b + (Math.Pow(-1, number_k)*(Math.Pow((number_n/(number_k+1)*(number_k+2)),number_k)));
            }
            number_all = (number_b + number_a);
            Console.WriteLine(number_all);
            Console.ReadKey();
        }
       
    }

}
    

