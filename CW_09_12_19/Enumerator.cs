using System;
using System.Collections;

namespace CW_09_12_19
{
    public class Enumerator<T> : IEnumerator
    {
        private MyList<T> List { get;}
        private Node<T> current;
        public object Current { get => current.Value; } 

        public Enumerator(MyList<T> list)
        {
            List = list;    
            current = null;
        }

        public bool MoveNext()
        {
            if (current == null)
            {
                current = List.HeadNode;
            }
            else
            {
                current = current.NextNode;
            }
         
            return (current != null);
        }

        void IEnumerator.Reset()
        {
        }
    }
}
