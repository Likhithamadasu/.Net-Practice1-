using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Operations
{
    internal class Program
    {
     

public class CustomStack<T>
        {
            private List<T> _stack;

            public CustomStack()
            {
                _stack = new List<T>();
            }

           
            public void Push(T item)
            {
                _stack.Add(item);
            }

          
            public T Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty.");
                }

                T item = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count - 1);
                return item;
            }

            
            public T Peek()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty.");
                }

                return _stack[_stack.Count - 1];
            }

            
            public bool IsEmpty()
            {
                return _stack.Count == 0;
            }
        }

        class operations
        {
            static void Main()
            {
                CustomStack<int> stack = new CustomStack<int>();
                bool running = true;

                while (running)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Push an integer onto the stack");
                    Console.WriteLine("2. Pop an integer from the stack");
                    Console.WriteLine("3. Peek at the top element of the stack");
                    Console.WriteLine("4. Check if the stack is empty");
                    Console.WriteLine("5. Quit");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter an integer to push onto the stack: ");
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out int number))
                            {
                                stack.Push(number);
                                Console.WriteLine($"{number} pushed onto the stack.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            }
                            break;

                        case "2":
                            try
                            {
                                int poppedNumber = stack.Pop();
                                Console.WriteLine($"{poppedNumber} popped from the stack.");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case "3":
                            try
                            {
                                int topNumber = stack.Peek();
                                Console.WriteLine($"Top element is: {topNumber}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case "4":
                            if (stack.IsEmpty())
                            {
                                Console.WriteLine("The stack is empty.");
                            }
                            else
                            {
                                Console.WriteLine("The stack is not empty.");
                            }
                            break;

                        case "5":
                            running = false;
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
            }
        }

    }
}

