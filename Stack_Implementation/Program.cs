using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push(1);
            s.Push(7);
            s.Push(4);
            s.Push(9);
            s.Push(5);

            while (!s.IsEmpty())
            {
                Console.WriteLine(s.Peek());
                s.Pop();
            }

        }
    }
}
