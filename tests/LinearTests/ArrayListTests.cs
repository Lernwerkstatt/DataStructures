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
      
            foreach (int i in Enumerable.Range(1, 1000))
            {
                Assert.IsTrue(target.Contains(i), string.Format("Failed at {0}", i));
            }
        }
    }
}
