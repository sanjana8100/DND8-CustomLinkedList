namespace DND8_CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList1 = new LinkedList<int>();

            linkedList1.AddFirst(70);
            linkedList1.AddFirst(30);
            linkedList1.AddFirst(56);

            linkedList1.Display();

            linkedList1.AddLast(66);
            linkedList1.AddLast(27);

            linkedList1.Display();

            linkedList1.AddAfter(30, 49);
            linkedList1.AddAfter(20, 87);

            linkedList1.Display();

            linkedList1.DeleteFirst();

            linkedList1.Display();

            linkedList1.DeleteLast();   

            linkedList1.Display();
        }
    }
}