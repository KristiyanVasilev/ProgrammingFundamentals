namespace TripleSum
{
    using System;

    class TripleSum
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }

            int temp = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            temp++;
                            Console.WriteLine(arr[a] + " + " + arr[b] + " == " + arr[c]);                            
                            break;
                        }
                    }
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
