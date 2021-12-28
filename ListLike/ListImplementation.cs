using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLike
{
    public class ListImplementation <T> :IEnumerable<T>
    {
        private T? Current;
        private ListImplementation<T> nextNode;
        public T this[int i]
        {
            get {
                int j = 1;
                var node = this;
                while(j<=i)
                {
                    node = node.nextNode;
                    j++;
                }
                return node.Current; 
            
            }
            set {
                int j = 1;
                var node = this;
                while (j <= i)
                {
                    node = node.nextNode;
                    j++;
                }
                node.Current = value;
            }
        }


        public ListImplementation(T curNode)
        {
            this.Current= curNode;
            this.nextNode = null;
        }
        public ListImplementation()
        {

        }
        public void Clear()
        {
            this.Current = default(T);
            this.nextNode = null;
        }
        public void Add(T node)
        {
            
            if (this.Current==null)
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
