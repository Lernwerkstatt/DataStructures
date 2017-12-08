using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linear;

namespace LinearTests
{
    [TestClass]
    public class ArrayListTests
    {
        [TestMethod]
        public void Add()
        {
            ArrayList target = new ArrayList();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add(i);
            }
      
            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target.Contains(i), string.Format("Failed at {0}", i));
            }
        }
        [TestMethod]
        public void Clear()
        {
            ArrayList target = new ArrayList();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add(i);
            }

            target.Clear();

            Assert.IsTrue(target.Count == 0, string.Format("Failed ArrayList is not empty"));
        }
        [TestMethod]
        public void Remove()
        {
            ArrayList target = new ArrayList();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add(i);
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target.Remove(i) != -1, string.Format("Failed {0} not existing", i));
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target.Count == 0, string.Format("Failed ArrayList is not empty", i));
            }
        }
        [TestMethod]
        public void Insert()
        {
            ArrayList target = new ArrayList();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add(i);
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Insert(i - 1, 42);
            }

            target.Insert(0, 666);

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target[i - 1] == 42, string.Format("Failed ArrayList item {0} didnt answer the Ultimate Question of Life, the Universe, and Everything", i));
            }
        }
    }
}
