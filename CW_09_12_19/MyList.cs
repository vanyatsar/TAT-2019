using System.Collections;
using System.Text;

namespace CW_09_12_19
{
    public class MyList<T> : IEnumerable
    {
        public Node<T> HeadNode { get; private set; }
    
        public MyList()
        {
        }

        public void AddHead(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (HeadNode == null)
            {
                HeadNode = newNode;
                HeadNode.NextNode = null;
            }
            else
            {
                newNode.NextNode = HeadNode;
                HeadNode = newNode;
            }
        }

        public void AddTail(T value)
        {
            Node<T> newNode = new Node<T>(value);
            Node<T> tempNode = HeadNode;

            if (HeadNode == null)
            {
                HeadNode = newNode;
                HeadNode.NextNode = null;
                //return;
            }
            else
            {
                while (tempNode.NextNode != null)
                {
                    tempNode = tempNode.NextNode;
                }
                tempNode.NextNode = newNode;
                newNode.NextNode = null;
            }  
        }
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Node<T> tempNode = HeadNode;
            do
            {
                stringBuilder.Append(tempNode.Value.ToString() + '\n');
                tempNode = tempNode.NextNode;
            } while (tempNode != null);

            return stringBuilder.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator<T>(this);
        }
    }
}