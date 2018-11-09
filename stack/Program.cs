using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("s");
            st.Push("t");
            st.Push("a");
            for (int i = 0; i < st.Count; i++)
            {
                Console.WriteLine(st.Peek());
            }
            Console.ReadKey();
        }
    }
}
