using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace QueueStackTest
{
    [TestClass]
    public class StackTest 
    {
        [TestMethod]
        public void StackUsePeek()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Assert.AreEqual(6, stack.Peek());
        }

        [TestMethod]
        public void StackUseContains()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Assert.IsTrue(stack.Contains(5));
        }

        [TestMethod]
        public void StackUseToArray()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            var array = stack.ToArray();
            stack.Pop();

            Assert.AreEqual(6, array[0]);
            Assert.AreEqual(6, array.Length);
            Assert.AreEqual(5, stack.Count);
        }

        [TestMethod]
        public void StackUseClear()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Clear();

            Assert.AreEqual(0, stack.Count);
        }
    }
}
