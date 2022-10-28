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
    //creating a enqueue class 
    class Enque_assg_uc3
    {
        Node head = null;

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
        //creating display method  of enqueu elements

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
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enqueu Elements are:");
            Enque_assg_uc3 LLQueue = new Enque_assg_uc3();//creation of enqueu object
            LLQueue.Enqueue(56);//method call 
            LLQueue.Enqueue(30);
            LLQueue.Enqueue(70);
            LLQueue.Display();
            Console.ReadKey();//To wait to close output window
        }
    }
}