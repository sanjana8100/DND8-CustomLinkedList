﻿using System;
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