using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;

namespace DataStructureTest
{
    [TestClass]
    public class BinarySearcTreeTest
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
}
