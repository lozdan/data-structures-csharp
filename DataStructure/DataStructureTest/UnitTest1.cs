using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;

namespace DataStructureTest
{
    [TestClass]
    public class UnitTestTree
    {
        [TestMethod]
        public void SimpleHeightTest()
        {
            BinarySearchTree tree = new BinarySearchTree(8);
            Assert.AreEqual(0, tree.Height);
        }

        [TestMethod]
        public void ComplexHeightTest()
        {
            BinarySearchTree tree = new BinarySearchTree(8);
            tree.Add(5);
            tree.Add(1);
            tree.Add(10);
            tree.Add(11);
            tree.Add(9);
            Assert.AreEqual(2, tree.Height);
        }
    }
    [TestClass]
    public class UnitTestHeap
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

    [TestClass]
    public class UnitTestList
    {
        [TestMethod]
        public void ComplexListTest()
        {
            MyList<int> list = new MyList<int>();
            list.Add(5);
            list.Add(9);
            list.Remove(1);
            Assert.AreEqual(5, list[0]);
            list.Add(2);
            list.Add(3);
            list[-1] = 22;
            Assert.AreEqual(22, list[-1]);
            Assert.AreEqual(5, list[-3]);
            Assert.AreEqual(3, list.Length);
            int[] moreNumb = { 6, 8, 66, 34, 333, 987, 77, 20, 88 };
            list.AddRange(moreNumb);
            Assert.AreEqual(12, list.Length);
            Assert.AreEqual(88, list[-1]);
            Assert.AreEqual(20, list[-2]);
            Assert.AreEqual(true, list.Contains(333));
            Assert.AreEqual(false, list.Contains(1234));
            list.RemoveAll(88);
            Assert.AreEqual(20, list[-1]);
            Assert.AreEqual(11, list.Length);
            int[] fives = { 5, 5, 5, 5, 5 };
            list.AddRange(fives);
            Assert.AreEqual(16, list.Length);
            list.RemoveAll(5);
            Assert.AreEqual(10, list.Length);
            Assert.AreEqual(77, list[-2]);
        }
    }
}
