namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var shop = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                var entity = line[0];
                var entityPrice = decimal.Parse(line[1]);
                if (!shop.ContainsKey(entity))
                {
                    shop[entity] = 0.0m;
                }
                shop[entity] = entityPrice;
            }

            var customersList = new SortedDictionary<string, Dictionary<string, int>>();
            var breakPoint = true;
            while (breakPoint)
            {
                var secondInput = Console.ReadLine();
                if (secondInput == "end of clients")
                {
                    breakPoint = false;
                    continue;
                }
                var line = secondInput.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = line[0];
                var product = line[1];
                var quantity = int.Parse(line[2]);

                if (!shop.ContainsKey(product))
                {
                    continue;
                }
                else if (!customersList.ContainsKey(name))
                {
                    customersList[name] = new Dictionary<string, int>();
                    //customersList[name][product] = 0.0m;
                }
                if (!customersList[name].ContainsKey(product))
                {
                    customersList[name][product] = 0;
                }
                customersList[name][product] += quantity;
            }

            var totalBill = 0.0m;
            foreach (var customer in customersList)
            {
                var customerName = customer.Key;
                var customerOrders = customer.Value;
                var customerBill = 0.0m;

                Console.WriteLine(customerName);

                foreach (var product in customerOrders)
                {
                    var entity = product.Key;
                    Console.WriteLine($"-- {entity} - {product.Value}");
                    customerBill += product.Value * shop[entity];
                }
                Console.WriteLine($"Bill: {customerBill:f2}");
                totalBill += customerBill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
