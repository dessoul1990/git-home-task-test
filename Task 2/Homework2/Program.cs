using System;


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLink linkedlist = new LinkedLink();
            linkedlist.AddNodeToFront(5);
            linkedlist.AddNodeToFront(32);
            linkedlist.AddNodeToFront(52);
            linkedlist.AddNodeToFront(15);
            linkedlist.AddNodeToFront(78);
            linkedlist.AddNodeToFront(3);                     
            linkedlist.PrintList();
        }
        
    }
}
