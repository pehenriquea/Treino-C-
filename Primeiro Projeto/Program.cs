using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val;
            int y, fat;
            Program obj;

            Console.WriteLine("Digite o número desejado: ");
            val = Console.ReadLine();

            if ((int.TryParse(val.ToString(), out y)))
            {
                obj = new Program();
                fat = obj.CalculaFat(y);
                Console.WriteLine($"Resultado: {fat}");
            }

            Console.ReadLine();

        }
        public int CalculaFat(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * CalculaFat(x - 1);
        }
    }
}
