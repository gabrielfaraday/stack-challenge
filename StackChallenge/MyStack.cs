using System;
using System.Collections.Generic;
using System.Linq;

namespace StackChallenge
{
    public class MyStack
    {
        Stack<int> _myStack;
        Stack<int> _minStack;

        public MyStack()
        {
            _myStack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int x)
        {
            _myStack.Push(x);

            if (MinStackIsEmpty() || x <= _minStack.First())
                _minStack.Push(x);
        }

        public void Pop()
        {
            if (MinStackIsEmpty())
                throw new Exception("Stack is empty :(");

            if (_myStack.First() == Min())
                _minStack.Pop();

            _myStack.Pop();
        }

        public int Min()
        {
            if (MinStackIsEmpty())
                throw new Exception("Stack is empty :(");

            return _minStack.First();
        }

        bool MinStackIsEmpty()
        {
            return !_minStack.Any();
        }
    }
}
