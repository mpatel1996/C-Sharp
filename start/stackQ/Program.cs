using System.Collections.Generic;

namespace StacksAndQueue
{
    class StacksQ
    {
        public static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            Queue<int> q = new Queue<int>();

            myStack.Push(55);
            myStack.Push(12);
            Console.WriteLine($"{myStack.Peek()}"); // 12
            myStack.Pop();
            Console.WriteLine($"{myStack.Peek()}"); // 55

            q.Enqueue(2);
            q.Enqueue(25);
            Console.WriteLine($"{q.Peek()}"); // 2
            q.Enqueue(22);
            q.Dequeue();
            Console.WriteLine($"{q.Peek()}"); // 25
        }
    }
}
