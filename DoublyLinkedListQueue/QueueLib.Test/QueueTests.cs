using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib.Tests
{
    [TestClass()]
    public class QueueTests
    {
        [TestMethod()]
        public void AddLast_Node_Should_Become_Tail_int()
        {
            // arrange
            var start_node_value = 1;
            IQueue<int> TestQueue = new LinkedQueue<int>(start_node_value);
            var node = 12;
            //act
            TestQueue.Enqueue(node);
            //TestQueue.GetEnumerator();
            //assert
            Assert.AreEqual(TestQueue.Last(), node);
            Assert.AreEqual(TestQueue.First(), start_node_value);

        }


        [TestMethod()]
        public void AddLast_Node_Should_Become_Tail_string()
        {
            // arrange
            var start_node_value = "abc";
            IQueue<string> TestQueue = new LinkedQueue<string>(start_node_value);
            var node = "def";
            //act
            TestQueue.Enqueue(node);
            //assert
            Assert.AreEqual(TestQueue.Last(), node);
            Assert.AreEqual(TestQueue.First(), start_node_value);

        }

        [TestMethod()]
        public void AddLast_Node_Should_Become_Tail_bool()
        {
            // arrange
            var start_node_value = false;
            IQueue<bool> TestQueue = new LinkedQueue<bool>(start_node_value);
            var node = false;
            //act
            TestQueue.Enqueue(node);
            //assert
            Assert.AreEqual(TestQueue.Last(), node);
            Assert.AreEqual(TestQueue.First(), start_node_value);
        }

        [TestMethod()]
        public void RemoveFirst_Node_Should_Become_Head_int()
        {
            // arrange
            var start_node_value = 1;
            var node = 2;
            IQueue<int> TestQueue = new LinkedQueue<int>(start_node_value);
            TestQueue.Enqueue(node);
            // act
            // assert
            Assert.AreEqual(start_node_value, TestQueue.Dequeue());
            Assert.AreEqual(node, TestQueue.First());
        }

        [TestMethod()]
        public void RemoveFirst_Node_Should_Become_Head_string()
        {
            // arrange
            var start_node_value = "abc";
            var node = "def";
            IQueue<string> TestQueue = new LinkedQueue<string>(start_node_value);
            TestQueue.Enqueue(node);
            // act
            // assert
            Assert.AreEqual(start_node_value, TestQueue.Dequeue());
            Assert.AreEqual(node, TestQueue.First());
        }

        [TestMethod()]
        public void RemoveFirst_Node_Should_Become_Head_bool()
        {
            // arrange
            var start_node_value = true;
            var node = false;
            IQueue<bool> TestQueue = new LinkedQueue<bool>(start_node_value);
            TestQueue.Enqueue(node);
            // act
            // assert
            Assert.AreEqual(start_node_value, TestQueue.Dequeue());
            Assert.AreEqual(node, TestQueue.First());
        }

        [TestMethod()]
        public void ClearQueue_Queue_Should_Be_Empty()
        {
            // arrange
            var start_node_value = 1;
            var node = 2;
            IQueue<int> TestQueue = new LinkedQueue<int>(start_node_value);
            TestQueue.Enqueue(node);
            // act
            TestQueue.Clear();
            // assert
            Assert.IsTrue(TestQueue.IsEmpty());
            //Assert.AreEqual(null, TestQueue.First());
        }

        [TestMethod()]
        public void GetData_Should_Return_Tail()
        {   
            // arrange
            var start_node_value = 1;
            var node = 2;
            IQueue<int> TestQueue = new LinkedQueue<int>(start_node_value);
            TestQueue.Enqueue(node);
            // act
            var get_node = TestQueue.Peek();
            // assert
            Assert.AreEqual(node, get_node);
        }

        [TestMethod()]
        public void Enqueue_Empty_Test()
        {
            // arrange
            IQueue<string> TestQueue = new LinkedQueue<string>();
            // act
            // assert
            Assert.AreEqual(null, TestQueue.Dequeue());
        }
    }
}