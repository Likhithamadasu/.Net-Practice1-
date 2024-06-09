using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers1
{
    internal class Program
    {
     

public class CustomStack<T>
        {
            
            private List<T> _elements = new List<T>();

           
            public void Push(T item)
            {
                _elements.Add(item);
            }

           
            public T Pop()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty.");

                T item = _elements[_elements.Count - 1];
                _elements.RemoveAt(_elements.Count - 1);
                return item;
            }

            
            public T Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty.");

                return _elements[_elements.Count - 1];
            }

            
            public bool IsEmpty()
            {
                return _elements.Count == 0;
            }
        }

        public class modifier
        {
            public static void Main()
            {
                
                CustomStack<int> stack = new CustomStack<int>();

                Console.WriteLine("Pushing elements onto the stack:");
                stack.Push(10);
                stack.Push(20);
                stack.Push(30);

                Console.WriteLine("Current top element (Peek): " + stack.Peek());

                Console.WriteLine("Popping elements from the stack:");
                while (!stack.IsEmpty())
                {
                    Console.WriteLine(stack.Pop());
                }
            }
        }


    }
}

