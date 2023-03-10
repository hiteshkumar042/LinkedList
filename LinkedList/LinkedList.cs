using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        //Instance
        internal Node head;
        //Adding Data to LinkedList
        internal void Add(int data)
        {
            //Object of Node
            Node node = new Node(data);
            //Add Data
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //Display LinkedList Data
            Console.WriteLine("{0} inserted into the Linked List", node.data);
        }
        //Display LinkedList Data through Method
        public void Display()
        {
            //Head is Null then List is empty
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Linked List Data is : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
