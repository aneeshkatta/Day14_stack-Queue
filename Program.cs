using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue_assgnmnet_uc3
{
    
        //creating a node
        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
    internal class Deque_assignment_uc4
    {

        internal void Enqueue(int data)
        {
            Node node = new Node(data);//creating a node of Node type
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;//to make temp.next to zero and assign node ref to temp node


            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }
        //creating a dequeue class 
   
        internal Node head ;
        internal void Dequeu(int data)
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("The  element dequed is : " + head.data);
                head = head.next;

            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;

            }
            while (temp != null)//to display all elements
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    
    }
   class program
    { 
    
        public static void Main()
        {
            Console.WriteLine("Enqueu elements :");
            Deque_assignment_uc4 LLQueue = new Deque_assignment_uc4();
            LLQueue.Enqueue(56);
            LLQueue.Enqueue(30);
            LLQueue.Enqueue(70);
            LLQueue.Display();
            LLQueue.Dequeu(56);
            LLQueue.Dequeu(30);
            LLQueue.Dequeu(70);
            LLQueue.Display();
            Console.ReadKey();
        }
    }
}

