using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MyStack
    {
        public class Node
        {
           public Object data;
           public Node next;
           public Node(Object data)
            {
                this.data = data;
            }
        }
        Node Top;
        int count;
        public void push(Object data)
        {
            Node n = new Node(data);
            n.next = Top;
            Top = n;
            count++;
        }
        public Object pop()
        {
            if(Top == null)
            {
                return "Stack is Under flow....";
            }
            Object data = Top.data;
             Top = Top.next;
            count--;
            return data;
        }
        public Object peek()
        {
            if (Top == null)
            {
                return "Stack is Under flow....";
            } else
            {
                return Top.data;
            }
        }
        public int size()
        {
            return count;
        }
        public override string ToString()
        {
            string str = "";
            Node temp = Top;
            while(temp != null)
            {
                str += temp.data;
                if (temp.next != null)
                    str = str + " <= ";
                temp = temp.next;
            }
            return str;
        }

    }
}
