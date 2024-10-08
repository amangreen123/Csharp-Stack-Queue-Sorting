﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queues_Sorting
{
    internal class AaronQueue
    {
        Node front;
        Node tail;

        public AaronQueue() {

            front = null;
            tail = null;
        }

        //Creates linked list Node 
        public Node GetNode(string data)
        {
            Node node = new Node(data);
            return node;
        }

        public void Enqueue(string data) { 

            Node newNode = new Node(data);

            if (front == null)
            {
                front = tail = newNode;
                return;
            }

            tail.next = newNode;
            tail = newNode;  
        }

        public string Dequeue() {

            if (isEmpty())
            {
                return null;
            }
            
            string value = front.value;
            front = front.next;

            if (front == null)
            {
                tail = null; // If the queue is now empty, update the tail
            }

            return value;

        }

        public int Size()
        {
            if (isEmpty())
            {
                return 0;
            }

            int count = 0;
            Node current = front;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }


        public bool isEmpty()
        {
            if (front == null)
            {
                return true;

            } else {
                
                return false;
            } 
        }

        public string Peek()
        {
            if (isEmpty())
            {
                return null;
            }

            return front.value;
        }

    }
}
