namespace MultiplayBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class MultiplayBigNumbers
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            var multiply = int.Parse(Console.ReadLine());
            if (multiply == 0)
            {
                Console.WriteLine(0);
                return;
            }
            number = number.PadLeft(number.Length + 2, '0');
            var arr = number.Select(x => int.Parse(x.ToString())).ToArray();
            var sum = new int[arr.Length];
            var carry = 0;

            for (var i = number.Length - 1; i >= 0; i--)
            {
                var total = arr[i] * multiply + carry;
                sum[i] = total % 10;
                if (total > 9)
                {
                    carry = total / 10;
                }
                else carry = 0;
            }
            Console.WriteLine(string.Join("", sum.SkipWhile(x => x == 0)));
        }
    }
}
