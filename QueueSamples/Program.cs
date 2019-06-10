using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Example 1 - Queue.Count Property");
            string[] courses = { "MCA", "MBA", "BCA", "BBA", "BTech", "MTech" };
            Queue<string> queue1 = new Queue<string>();
            queue1 = new Queue<string>(courses);
            Queue<string> queue2 = new Queue<string>(courses);
            Queue<string> queue3 = new Queue<string>(4);
            Console.WriteLine("Number of elements in queue 1:" + queue1.Count());
            Console.WriteLine("Number of elements in queue 2:" + queue2.Count());
            Console.WriteLine("Number of elements in queue 3:" + queue3.Count());
            Console.WriteLine();


            Console.WriteLine("Example 2 - Queue.Enqueue Method");
            Queue<string> queue4 = new Queue<string>();
            queue4.Enqueue("MCA");
            queue4.Enqueue("MBA");
            queue4.Enqueue("BCA");
            queue4.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue4)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();


            Console.WriteLine("Example 3 - Queue.Dequeue method");
            Queue<string> queue5 = new Queue<string>();
            queue5.Enqueue("MCA");
            queue5.Enqueue("MBA");
            queue5.Enqueue("BCA");
            queue5.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue5)
            {
                Console.WriteLine(s);
            }
            queue5.Dequeue(); //Removes the first element that enter in the queue here the first element is MCA  
            queue5.Dequeue(); //Removes MBA  
            Console.WriteLine("After removal the elements in the queue are:");
            foreach (string s in queue5)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Example 4 - Queue.Contain method");
            Queue<string> queue6 = new Queue<string>();
            queue6.Enqueue("MCA");
            queue6.Enqueue("MBA");
            queue6.Enqueue("BCA");
            queue6.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue6)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("The element MCA is contain in the queue:" + queue6.Contains("MCA"));
            Console.WriteLine("The element BCA is contain in the queue:" + queue6.Contains("BCA"));
            Console.WriteLine("The element MTech is contain in the queue:" + queue6.Contains("MTech"));
            Console.WriteLine();


            Console.WriteLine("Example 5 - Queue.Clear method");
            Queue<string> queue7 = new Queue<string>();
            queue7.Enqueue("MCA");
            queue7.Enqueue("MBA");
            queue7.Enqueue("BCA");
            queue7.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:" + queue7.Count());
            queue7.Clear();
            Console.WriteLine("The elements in the queue are after the clear method:" + queue7.Count());
            Console.WriteLine();


            Console.WriteLine("Example 6 - Queue.Peek method");
            Queue<string> queue8 = new Queue<string>();
            queue8.Enqueue("MCA");
            queue8.Enqueue("MBA");
            queue8.Enqueue("BCA");
            queue8.Enqueue("BBA");
            Console.WriteLine("Peek the first item from the queue is:" + queue8.Peek());
            queue8.Dequeue();
            Console.WriteLine("Peek the next item from the queue is:" + queue8.Peek());
            Console.WriteLine();



            Console.WriteLine("Example 7 - Queue.ToArray method");
            Queue<string> queue9 = new Queue<string>();
            queue9.Enqueue("MCA");
            queue9.Enqueue("MBA");
            queue9.Enqueue("BCA");
            queue9.Enqueue("BBA");
            Console.WriteLine("The queue elements are:");
            foreach (string s in queue9)
            {
                Console.WriteLine(s);
            }
            Queue<string> queue10 = new Queue<string>(queue9.ToArray());
            Console.WriteLine("Contents of the copy");
            foreach (string n in queue10)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }
    }
}
