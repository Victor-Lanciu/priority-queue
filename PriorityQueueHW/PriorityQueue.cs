using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueHW
{
    public class PriorityQueue<T>
    {
        private class PriorityQueueItem<T>
        {
            public T Element { get; set; }
            public int Priority { get; set; }
            public PriorityQueueItem(T element, int priority)
            {
                Element = element;
                Priority = priority;
            }
        }
        private List<PriorityQueueItem<T>> elements = new List<PriorityQueueItem<T>>();

        public void Enqueue(T element, int priority)
        {
            var queueItem = new PriorityQueueItem<T>(element, priority);
            elements.Add(queueItem);
            Console.WriteLine($"A fost adaugat elementul {element} cu prioritatea {priority}");
            elements = elements.OrderByDescending(e => e.Priority).ToList();
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Coada este goala");
            }
            var highestPriorityItem = elements[0];
            elements.RemoveAt(0);
            return highestPriorityItem.Element;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Coada este goala");
            }
            return elements[0].Element;
        }

        public bool IsEmpty()
        {
            return elements.Count == 0;
        }

    }
}
