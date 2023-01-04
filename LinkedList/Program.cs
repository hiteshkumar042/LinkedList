namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================\nWelcome to Linked List.\n=======================");

            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            //Display Data of Linked List
            linkedList.Display();
        }
    }
}