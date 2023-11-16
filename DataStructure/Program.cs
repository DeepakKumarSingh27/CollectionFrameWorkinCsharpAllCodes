using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The option Number");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
             case 1:
            SingleLinkedList list = new SingleLinkedList();
            list.add(1);
            list.add(2);
            list.add(3);
            list.addFirst(4);
            list.add(20, 2);

            Console.WriteLine(list);
            Console.WriteLine(list.deleteFirst());
            Console.WriteLine(list.deleteLast());
            Console.WriteLine(list.delete(2));
            break;
            case 2:
             MyStack stack = new MyStack();
                    stack.push(1);
                    stack.push(2);
                    stack.push(3);
                    stack.push(4);
                    Console.WriteLine(stack);
                    Console.WriteLine("Size is: "+stack.size());
                    Console.WriteLine(stack.pop());
                    Console.WriteLine(stack.peek());
                    break;
                case 3:
                    MyQue mq = new MyQue();
                    mq.enQue(1);
                    mq.enQue(2);    
                    mq.enQue(3);
                    mq.enQue(4);
                    Console.WriteLine(mq);
                    Console.WriteLine(mq.size());
                    Console.WriteLine(mq.deQue());
                    Console.WriteLine(mq.size());
                    break;
                case 4:
                    var student = new List<string>();
                    student.Add("Aman");
                    student.Add("RAman"); 
                    student.Add("chAman"); 
                    student.Add("jhAman");
                    student.Add("Aman");
                    student.Remove("Aman");
                    foreach (var sname in student)
                    {
                        Console.WriteLine(sname);
                    }
                    break;
                case 5:
                    Stack<int> i = new Stack<int>();
                    i.Push(1);
                    i.Push(2);
                    i.Push(3);
                    i.Push(4);
                    foreach(var j in i)
                    {
                        Console.Write(j+" ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(i.Pop());
                    Console.WriteLine(i.Peek());
                    break;
                case 6:
                   Queue<int> queue = new Queue<int>();
                    queue.Enqueue(1);
                    queue.Enqueue(2);
                    queue.Enqueue(3);
                    queue.Enqueue(4);
                    foreach (var item in queue)
                    Console.Write(item+" ");
                    Console.WriteLine();
                    Console.WriteLine(queue.Dequeue());
                    break;
                    case 7:
                    var student1 = new HashSet<string>();
                    student1.Add("Ram");
                    student1.Add("shyRam"); 
                    student1.Add("shriRam");
                    student1.Add("Raj");
                    foreach (var name in student1)
                    {
                        Console.Write(name+" ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enter the Student name");
                     string s = Console.ReadLine();
                    student1.Remove(s);
                     foreach (var name in student1)
                    {
                        Console.Write(name + " ");
                    }
                    break;
                case 8:
                    var student2 = new SortedSet<string>();
                    student2.Add("Ram");
                    student2.Add("shyRam");
                    student2.Add("shriRam");
                    student2.Add("Raj");
                    student2.Add("Raj");
                    foreach (var name in student2)
                    {
                        Console.Write(name + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enter the Student name");
                    string s1 = Console.ReadLine();
                    student2.Remove(s1);
                    foreach (var name in student2)
                    {
                        Console.Write(name + " ");
                    }
                    break;
                case 9:
                    var student3 = new LinkedList<string>();
                    student3.AddLast("E");
                    student3.AddLast("F");
                    student3.AddFirst("D");
                    LinkedListNode<string> node = student3.Find("F");
                    student3.AddAfter(node, "G");
                    student3.AddBefore(node, "B");
                    foreach (var item in student3)
                    {
                        Console.Write(item+" ");
                    }

                    break;

            default:
            Console.WriteLine("case dont match");
            break;
            }
           
            Console.ReadLine();
        }
    }
}
