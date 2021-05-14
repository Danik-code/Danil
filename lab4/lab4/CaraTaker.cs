using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class CaraTaker
    {
        public Stack<Memento> myStack;

        public CaraTaker()
        {
            myStack = new Stack<Memento>();
        }

        public void push(Memento memento)
        {
            myStack.Push(memento);
        }

        public bool Empty => myStack.Count == 0;
        
        public Memento pop()
        {
            if (!Empty)
                return myStack.Pop();
            else
                return null;
        }
    }
}