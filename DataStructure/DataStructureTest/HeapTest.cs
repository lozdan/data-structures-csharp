using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;

namespace DataStructureTest
{
    [TestClass]
    public class HeapTest
    {
        [TestMethod]
        public void SimpleHeapTest()
        {
            HeapMin heap = new HeapMin();
            heap.Push(7);
            heap.Push(1);
            Assert.AreEqual(1, heap.Peek());
        }

        [TestMethod]
        public void ComplexHeapTest()
        {
            HeapMin heap = new HeapMin();
            heap.Push(6);
            heap.Push(9);
            Assert.AreEqual(6, heap.Peek());
            Assert.AreEqual(6, heap.Pop());
            Assert.AreEqual(9, heap.Peek());
            heap.Push(4);
            heap.Push(3);
            heap.Push(5);
            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(4, heap.Peek());
            Assert.AreEqual(3, heap.Length);
            heap.Push(1);
            heap.Push(13);
            heap.Push(78);
            heap.Push(54);
            heap.Push(20);
            heap.Push(20);
            heap.Push(17);
            heap.Push(44);
            Assert.AreEqual(11, heap.Length);
            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(4, heap.Peek());
            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(5, heap.Pop());
            Assert.AreEqual(9, heap.Pop());
            Assert.AreEqual(13, heap.Pop());
            Assert.AreEqual(17, heap.Pop());
            Assert.AreEqual(20, heap.Pop());
            Assert.AreEqual(20, heap.Pop());
            Assert.AreEqual(44, heap.Pop());
            Assert.AreEqual(54, heap.Peek());
            Assert.AreEqual(54, heap.Pop());
            Assert.AreEqual(78, heap.Pop());
        }

        [TestMethod]
        public void TetsHeapBuild()
        {
            int[] list = { 1, 2, 3, 4, 4, 3, 2, 1 };
            HeapMin heap = new HeapMin();
            heap = heap.BuildHeap(list);
            Assert.AreEqual(8, heap.Length);
            Assert.AreEqual(1, heap.Peek());
            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(5, heap.Length);
            heap.Push(0);
            Assert.AreEqual(0, heap.Peek());
            heap.Push(36);
            heap.Push(96);
            heap.Push(1);
            heap.Push(23);
            Assert.AreEqual(0, heap.Pop());
            Assert.AreEqual(1, heap.Pop());
        }
    }
}
