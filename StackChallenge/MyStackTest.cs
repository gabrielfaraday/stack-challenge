using NUnit.Framework;
using System;

namespace StackChallenge
{
    [TestFixture]
    public class MyStackTest
    {
        MyStack _myStack;

        public MyStackTest()
        {
            _myStack = new MyStack();
        }

        [Test]
        public void MyStack_CompleteTest()
        {
            _myStack.Push(5);
            _myStack.Push(3);
            _myStack.Push(4);
            _myStack.Push(2);

            Assert.That(_myStack.Min(), Is.EqualTo(2));

            _myStack.Pop();
            _myStack.Pop();
            _myStack.Push(7);
            _myStack.Push(1);
            _myStack.Push(2);

            Assert.That(_myStack.Min(), Is.EqualTo(1));

            _myStack.Pop();
            _myStack.Pop();
            _myStack.Pop();
            _myStack.Pop();
            _myStack.Pop();

            Assert.Throws<Exception>(() => _myStack.Pop(), "Stack is empty :(");
            Assert.Throws<Exception>(() => _myStack.Min(), "Stack is empty :(");
        }
    }
}
