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
    public class ListImplementation <T> :IEnumerable<T>
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
            this.Head.Current =value ;
        }
        public void Clear()
        {
            this.Head = null;
        }
        public void Add(T node)
        {
            
            if (this.Head.Current==null)
            {
                this.Current=node;
            }
            else
            {
                var curNode = this;
                while(curNode.nextNode!=null)
                {
                    curNode=curNode.nextNode;
                }
                curNode.nextNode=new ListImplementation<T>(node);
            }
        }
        public int GetSize()
        {
            var count = 0;
            var node = this;
            while(node != null && node.Current != null)
            {
                count++;
                node = node.nextNode;
            }
            return count;
        }
        public T GetFirst()
        {
            return this.Current;
        }
        public T GetLast()
        {
            var node = this;
            if (node.Current != null)
            {
                while(node != null && node.nextNode!=null)
                {
                    node=node.nextNode;
                }
            }
            return node.Current;
        }
        public void PrintAll()
        {
            var node = this;
            while (node != null && node.Current!=null)
            {
            Console.WriteLine(node.Current);
            node=node.nextNode;
            }
           
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this;
            while (node!= null && node.Current != null)
            {
                yield return node.Current;
                node = node.nextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)nextNode).GetEnumerator();
        }
    }
}
