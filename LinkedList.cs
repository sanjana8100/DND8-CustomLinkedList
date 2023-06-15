using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DND8_CustomLinkedList
{
    internal class LinkedList<T> 
    {
        Node<T> head;
        Node<T> tail;

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        public bool AddAfter(T searchData, T addData)
        {
            Node<T> newNode = new Node<T>(addData);
            Node<T> searchedNode = null;

            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(searchData))
                {
                    searchedNode = temp;
                }
                temp = temp.next;
            }
            
            if (searchedNode != null)
            {
                newNode.next = searchedNode.next;
                searchedNode.next = newNode;
                return true;
            }
            Console.WriteLine($"{searchData} does not exist in the Linked List!!!");
            return false;
        }

        public T DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is empty!!!");
                return default(T);
            }
            T popData = head.data;
            head = head.next;
            return popData;
        }

        public T DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is empty!!!");
                return default(T);
            }
            T popData = tail.data;
            if (head == tail)
            {
                head = null;
                return popData;
            }
            Node<T> temp = head;
            while (temp.next != tail)
                temp = temp.next;
            temp.next = null;
            tail = temp;
            return popData;
        }

        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
