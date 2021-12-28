using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLike
{
    internal class Node <T>
    {
        public T Current { get; set; }
        public Node<T> Next;

        public Node(T current)
        {
            this.Current= current;
            this.Next = null;
        }
    }
    public class ListImplementation <T> 
    {
        private Node<T> Head;
        public T this[int i]
        {
            get {
                int j = 1;
                var node = this.Head;
                while(j<=i)
                {
                    node = node.Next;
                    j++;
                }
                return node.Current; 
            
            }
            set {
                int j = 1;
                var node = this.Head;
                while (j <= i)
                {
                    node = node.Next;
                    j++;
                }
                node.Current = value;
            }
        }
        public ListImplementation()
        {

        }

        public ListImplementation(T value)
        {
            this.Head=new Node<T>(value);
        }
        public void Clear()
        {
            this.Head = null;
        }
        public void Add(T value)
        {
            
            if (this.Head==null)
            {
                this.Head = new Node<T>(value);
            }
            else
            {
                var Node = this.Head;
                while(Node.Next!=null)
                {
                    Node=Node.Next;
                }
                Node.Next=new Node<T>(value);
            }
        }
        public int GetSize()
        {
            var count = 0;
            var node = this.Head;
            while(node!= null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }
        public T GetFirst()
        {
            return Head.Current;
        }
        public T GetLast()
        {
            var node = this.Head;
            if (node != null)
            {
                while(node.Next!=null)
                {
                    node=node.Next;
                }
            }
            return node.Current;
        }
        public void PrintAll()
        {
            var node = this.Head;
            while (node!=null)
            {
                Console.WriteLine(node.Current);
                node=node.Next;
            }
           
        }
    }
}
