namespace CW_09_12_19
{
    public class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> NextNode { get; set; }
        public Node()
        {
        }
        public Node(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return Value.ToString() + '\n'; 
        }
    }
}
