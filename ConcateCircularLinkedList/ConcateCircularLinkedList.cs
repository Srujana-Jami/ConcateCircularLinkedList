using System;
using System.Collections.Generic;
using System.Text;

namespace ConcateCircularLinkedList
{
    class ConcateCircularLinkedList
    {
        private Node last;

        public ConcateCircularLinkedList()
        {
            last = null;
        }

        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine(" List is Empty ");
                return;
            }

            Node p = last.link;
            do
            {
                Console.Write(p.info + " ");
                p = p.link;
            } while (p != last.link);
            Console.WriteLine();

        }

        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            Console.Write("enter the element to be  inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            last.link = last;

        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
        }

   public void Concate(ConcateCircularLinkedList list)
        {
            if(last == null)
            {
                last = list.last;
                return;
            }
            if (list.last == null)
                return;
            Node p = last.link;
            last.link = list.last.link;
            list.last.link = p;
            last = list.last;
        
        
        }
    
    
    }
}
