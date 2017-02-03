namespace LastNumbersSumsSequence
{
    using System;

    class LastNumbersSumsSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var numbers = new long[n];
            numbers[0] = 1;
            

            for (int i = 1; i < numbers.Length; i++)
            {
                int start = Math.Max(0, i - k);
                int end = i - 1;
                long temp = 0;
                for (int s = start; s <= end; s++)
                {
                    temp += numbers[s];
                }
                numbers[i] = temp;
            }
            Console.WriteLine(string.Join(" ",numbers));
            
        }
    }
}
