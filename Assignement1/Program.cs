using System;

namespace Assignement1
{
    class Program
    {
        static void Main(string[] args)
        {
            //assignment1
            var array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please write a number between 1 and 100: ");
                var input = Console.ReadLine();
                var x = int.Parse(input);
                array[i] = x;

            }
            AfiseazaStringCuSeparator('*', array);
        }
        public static void AfiseazaStringCuSeparator(char x, int[] sir)
        {
            for (int i = 0; i < sir.Length; i++)
            {
                Console.Write($"{sir[i]}{x} ");
            }
            Console.WriteLine("");
        }
    }
}
