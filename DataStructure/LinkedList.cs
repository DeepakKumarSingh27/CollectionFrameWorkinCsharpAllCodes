using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList1
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }

        }
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            } 
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
         public void Display()
         {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty...");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
         }
         public Node InsertParticularPosition(int position, int data)
        {
           if(position < 1)
                Console.WriteLine("Invalid Position");
           if(position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
           else
            {
               while(position-- != 0)
                {
                    if(position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
               if(position != 1)
                    Console.WriteLine("position out of Range..");
            }
            return head;

        }

    }
}
