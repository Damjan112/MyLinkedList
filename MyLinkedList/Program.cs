using CustomLinkedList;
using System;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ll = new LinkedList<string>();
            Node<string> a = new Node<string>("aaa");
            ll.AddFirst(a);

            Node<string> b = new Node<string>("bbb");
            ll.AddFirst(b);

            Node<string> c = new Node<string>("ccc");
            ll.AddFirst(c);

            Node<string> d = new Node<string>("ddd");
            ll.AddFirst(d);

            Node<string> e = new Node<string>("eee");
            ll.AddLast(e);

            Console.WriteLine("Add after a");
            ll.AddAfter(new Node<string>("xxx"), a);

            Console.WriteLine("Add after e");
            ll.AddAfter(new Node<string>("zzz"), e);

            ll.Traverse();

            Node<string> target = ll.Find("ddd");
            if(target != null)
            {
                Console.WriteLine("found: " + target.Data);
                Console.WriteLine("\nremoving " + target.Data);
                ll.Remove(target);
            }
            else
            {
                Console.WriteLine("target not found");
            }
            ll.Traverse();

        }
    }
}
