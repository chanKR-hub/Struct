using System.Collections;

namespace Struct
{
    class Stack<T>
    {
        public T Value { get; set; }
        public static List<T> values = new List<T>();

        public Stack(T value)
        {
        
            this.Value = value;
        }

        public void Push()
        {
            values.Add(Value);
        } 
        public T Pop()
        {
            values.RemoveAt(values.Count - 1);
             return Value;
        }
        public T Peek()
        {
            return Value;
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>("오리지널 감자칩");
            stack.Push();
            Stack<string> stack2 = new Stack<string>("상큼한 레몬녹차");
            stack2.Push();

            List<string> values = Stack<string>.values;

            Console.WriteLine(values[0]);



        }
    }
}