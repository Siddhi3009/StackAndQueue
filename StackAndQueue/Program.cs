using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue demo");
            StackLinkedList StacklinkedList = new StackLinkedList();
            StacklinkedList.Push(70);
            StacklinkedList.Push(30);
            StacklinkedList.Push(56);
            StacklinkedList.Display();
            StacklinkedList.IsEmpty();
            Console.WriteLine("__________________________________________________________________");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
        }
    }
}
