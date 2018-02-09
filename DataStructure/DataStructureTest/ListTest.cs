using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;

namespace DataStructureTest
{
    [TestClass]
    public class ListTest
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
