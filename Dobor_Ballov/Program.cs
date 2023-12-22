using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobor_Ballov
{
    class Program
    {
        private static bool chek;
        private static int size;

        public static string PrintDiamond(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                Console.WriteLine("Вы ввели четное число или меньше нуля");
                return null;
            }

            string diamond = "";

            for (int i = 1; i <= n; i += 2)
            {
                diamond += new string(' ', (n - i) / 2) + new string('*', i) + "\n";
            }

            for (int i = n - 2; i >= 1; i -= 2)
            {
                diamond += new string(' ', (n - i) / 2) + new string('*', i) + "\n";
            }

            return diamond;
        }

        public static string[] SortStringsByLength(string[] arr)
        {
            return arr.OrderBy(s => s.Length).ToArray();
        }

        static void Main()
        {
            // 1
            do
            {
                Console.WriteLine("Введите нечетное целое число");
                chek = int.TryParse(Console.ReadLine(), out size);
            } while (!chek);
            string result = PrintDiamond(size);
            Console.WriteLine(result);
            // 2
            string[] strings = new string[] { "Telescopes", "Glasses", "Eyes", "Monocles" };
            string[] sortedStrings = SortStringsByLength(strings);

            foreach (string s in sortedStrings)
            {
                Console.WriteLine(s);
            }
            // 3
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Квадрат: " + string.Join(", ", numbers.Square()));
            Console.WriteLine("Куб: " + string.Join(", ", numbers.Cube()));
            Console.WriteLine("Среднее значение: " + numbers.Average());
            Console.WriteLine("Сумма: " + numbers.Sum());
            Console.WriteLine("Четное: " + string.Join(", ", numbers.Even()));
            Console.WriteLine("Нечетное: " + string.Join(", ", numbers.Odd()));
        }
    }
}
