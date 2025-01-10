using PriorityQueueHW;

namespace CoadaPrioritate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priorityQueueInt = new PriorityQueue<int>();

            priorityQueueInt.Enqueue(12, 10);
            priorityQueueInt.Enqueue(31, 11);
            priorityQueueInt.Enqueue(444, 4);


            while (!priorityQueueInt.IsEmpty())
            {
                Console.WriteLine(priorityQueueInt.Dequeue());
            }
            var priorityQueueString = new PriorityQueue<string>();

            priorityQueueString.Enqueue("Task 1", 1);
            priorityQueueString.Enqueue("Task 4", 5);
            priorityQueueString.Enqueue("Task 2", 3);

            while (!priorityQueueString.IsEmpty())
            {
                Console.WriteLine(priorityQueueString.Dequeue());
            }
            Console.WriteLine(priorityQueueInt.Peek());

        }
    }
}
