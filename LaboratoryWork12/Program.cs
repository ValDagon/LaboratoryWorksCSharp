using System;

namespace LaboratoryWork12
{
    class Program
    {

        static void Main()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double x) == true)
                {
                    double result = 0;
                    for (int n = 1; n <= 10; n++)
                        result += n / Math.Pow(x, n);

                    Console.WriteLine(result.ToString());
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели недопустимые данные\n");
                }
            }
            Console.Read();
        }
    }
}