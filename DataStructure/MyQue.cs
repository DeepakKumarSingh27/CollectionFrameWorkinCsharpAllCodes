using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MyQue
    {
        class Node
        {
           public Node next;
           public Object data;
            public Node(Object data)
            { 
            this.data = data;
            }
        }
        Node front;
        Node rear;
       public int capacity = 0;
        public void enQue(Object data)
        {
            Node n = new Node(data);
            capacity++;
            if(front == null)
                front = n;
               else
                rear.next = n;
                rear = n;
        }
        public Object deQue()
        {
            if (front == null)
                return "Queue is Empty";
            Object data = front.data;
            front = front.next;
            if (front == null)
                rear = null;
            capacity--;
            return data;
        }
        public override string ToString()
        {
            string str = "";
            Node temp = front;
            while (temp != null)
            {
                str += temp.data;
                if (temp.next != null)
                    str += " => ";
                temp = temp.next;
            }
            return str;
        }
        public int size()
        {
            return capacity;
        }

    }
}
