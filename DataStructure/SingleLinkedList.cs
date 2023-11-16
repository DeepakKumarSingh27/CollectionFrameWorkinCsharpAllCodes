using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SingleLinkedList
    {
        class Node
        {
           public Object data;
           public Node next;
            public Node(Object data)
            {
                this.data = data;
            }
        }
        Node head;
        public void add(Object data)
        {
            Node n = new Node(data);
            if(head == null)
            {
                head = n;
                return;
            }
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = n;
        }
        public override string ToString()
        {
            string str = "";
            Node temp = head;
            while (temp != null)
            {
                str = str + temp.data;
                if (temp.next != null)
                    str = str + " -> ";
                temp = temp.next;
            }
            return str;
        }
       public void addFirst(Object data)
        {
            Node n = new Node(data);
            n.next = head;
            head = n;
        }
        public void add(Object data, int index)
        {
            if(index == 0)
            {
                addFirst(data);
                return;
            }
            Node temp = head;
            while(temp != null && index > 1)
            {
                temp = temp.next;
                index--;
            }
            if(temp == null)
            {
                Console.WriteLine("Index not in Range!!");
                return;
            }
            Node n = new Node(data);
            n.next = temp.next;
            temp.next = n;
        }
        public Object deleteFirst()
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty!!");
                return null;
            }
            Object data = head.data;
            head = head.next;
            return data;
        }
        public Object deleteLast()
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty!!");
                return null;
            }
            Node temp = head;
            Node prev = null;
            while(temp.next != null)
            {
                prev = temp;
                temp = temp.next;
            }
            if (prev == null)
                head = null;
            else
                prev.next = null;
            return temp.data;
        }
        public Object delete(int index)
        {
            if(index == 0)
               return deleteFirst();

            Node temp = head;
            while (temp.next != null && index > 1)
            {
                temp = temp.next;
                index--;
            }
            if (temp.next == null)
            {
                // Console.WriteLine();
                return "Index not in the range";
            }
            else
            {
                Object data = temp.next.data;
                temp.next = temp.next.next;
                return data;
            }
        }
    }
}
