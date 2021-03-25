using System;

namespace Alistirmalar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2();
            var result = Add2(4);
            Console.WriteLine(result);
            Console.WriteLine("-------------------------");
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);
            Console.WriteLine(result2);


            static void Add()
            {
                Console.WriteLine("Added!");
            }
            static int Add2(int number1=20,int number2=30) // = dersek default parametredir.Parametre girilmezse 30 alınır.
            {
                var result = number1 + number2;
                return result;

            }
            static int Add3(int number1,int number2)
            {
                number1 = 30;
                return number1 + number2;

            }

        }
    }
}
