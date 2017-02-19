namespace ValidUsername
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ValidUsername
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '(', ')', '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            var pattern = @"\b[A-Za-z]\w{2,24}\b";
            var regex = new Regex(pattern);
            var validUserName = new List<string>();
            var sum = 0;
            var maxSum = 0;            

            foreach (var token in input)
            {
                if (regex.IsMatch(token))
                {
                    validUserName.Add(token);
                }
            }
            var firstMax = string.Empty;
            var secondMax = string.Empty;
            for (int i = 1; i < validUserName.Count; i++)
            {
                var previousNumCount = validUserName[i - 1].Count();
                var currentNumCount = validUserName[i].Count();
                sum = previousNumCount + currentNumCount;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    firstMax = validUserName[i - 1];
                    secondMax = validUserName[i];
                }
            }
            Console.WriteLine(firstMax);
            Console.WriteLine(secondMax);
        }
    }
}
