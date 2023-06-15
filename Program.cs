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
        }
    }
}