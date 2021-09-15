using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StacksAndQueuesExercises
{
    class FastFood
    {
        static void FastFoo()
        {
            int quantityFood = int.Parse(Console.ReadLine());
            string[] ordersString = Console.ReadLine().Split(' ');
            Queue<int> orders = new Queue<int>();

            foreach (var item in ordersString)
            {
                orders.Enqueue(int.Parse(item));
            }

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (quantityFood < orders.Peek())
                {
                    if (orders.Count > 1)
                    {
                        int sum = 0;
                        int index = orders.Count;
                        for (int i = 0; i < index; i++)
                        {
                            sum += orders.Dequeue();
                        }
                        Console.WriteLine($"Orders left: {sum}");
                    }
                    else
                    {
                        Console.WriteLine($"Orders left: {orders.Peek()}");
                        break;
                    }
                }
                else
                {
                    quantityFood -= orders.Dequeue();
                    if (orders.Count == 0)
                    {
                        Console.WriteLine("Orders complete");
                    }
                }
            }
        }
    }
}
