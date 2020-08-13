using System;
namespace Exercise {
    public class LinkedList {

        Node head = null;
        public class Node {
            public int data;
            public Node next;
        }

        public void AddTop(int data) {
            Node tempNode = new Node();
            tempNode.data = data;
            tempNode.next = head;
            head = tempNode;
        }
        public void AddBottom(int data) {
            Node tempNode = new Node();
            tempNode.data = data;
            Node temp = head;
            while (temp.next != null) {
                temp = temp.next;
            }
            temp.next = tempNode;
            
        }

        public void PrintList() {
            Node temp = head;

            if (head == null) {
                Console.WriteLine("list is empty ");
            }

            while (temp != null) {
                Console.WriteLine("val :"+temp.data);
                temp = temp.next;
            }
        }

        public void DeleteTop() {
            Node temp = head;
            head = temp.next;
        }

        public void DeleteBottom() {
            Node temp = head;
            Node secLast = null;
            while (temp.next.next != null) {
                
                temp = temp.next;
            }
            secLast = temp;
            secLast.next = null;
        }

        public void DeleteAt(int val) {
            Node temp = head;
            Node prev = head;
            int count = 1;
            if (head == null) {
                Console.WriteLine("empty list");
                return;
            }
            while (temp!=null && count != val) {
                prev = temp;
                temp = temp.next;
                count++;
            }
            if (count < val) {
                Console.WriteLine("not enough items");
                return;
            }
            if(count == 1 && temp.next==null) {
                head = null; 
            }
            else if (count == 1 && temp.next != null) {
                head = head.next;
            }else if(count > 1 && temp.next == null) {
                prev.next = null;
            }
            else {
                prev.next = temp.next;
            }

        }

        public void DeleteByValue(int val) {
            Node temp = head;
            Node prev = head;
            int count = 1;
            if (head == null) {
                Console.WriteLine("empty list");
                return;
            }
            while (temp != null && temp.data != val) {
                prev = temp;
                temp = temp.next;
                count++;
            }
            
            if (count == 1 && temp.next == null) {
                head = null;
            }
            else if (count == 1 && temp.next != null) {
                head = head.next;
            }
            else if (count > 1 && temp.next == null) {
                prev.next = null;
            }
            else {
                prev.next = temp.next;
            }
        }

        public static void Main() {
            LinkedList list = new LinkedList();
            list.AddTop(1);
            list.AddTop(2);
            list.AddTop(3);
            list.AddTop(4);
            list.PrintList();
            Console.WriteLine("===============");
            list.AddBottom(5);
            list.AddBottom(6);
            list.AddBottom(7);
            list.AddBottom(8);
            list.AddBottom(9);
            list.PrintList();
            Console.WriteLine("===============");
            list.DeleteTop();
            list.PrintList();
            Console.WriteLine("===============");
            list.DeleteBottom();
            list.PrintList();
            Console.WriteLine("===============");
            list.DeleteAt(4);
            list.PrintList();
            list.DeleteByValue(3);
            list.PrintList();
        }
    }
}
