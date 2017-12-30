using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linear;
using System;

namespace Test
{
    [TestClass]
    public class ArrayListTests
    {
        [TestMethod]
        public void AddInt()
        {
            ArrayList<int> target = new ArrayList<int>();
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
        public void AddChar()
        {
            ArrayList<char> target = new ArrayList<char>();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add((char)i);
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target.Contains((char)i), string.Format("Failed at {0}", i));
            }
        }

        [TestMethod]
        public void AddBool()
        {
            ArrayList<bool> target = new ArrayList<bool>();
            Random rand = new Random();

            foreach (int i in Enumerable.Range(1, 999))
            {
                int temp = rand.Next(2, 4);
                if (temp % 2 == 0)
                {
                    target.Add(true);
                }
                else
                {
                    target.Add(false);
                }
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target[i].GetType().Name == "Boolean", string.Format("Failed at {0}", i));
            }
        }

        [TestMethod]
        public void ClearInt()
        {
            ArrayList<int> target = new ArrayList<int>();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add(i);
            }
            target.Clear();

            Assert.IsTrue(target.Count == 0, string.Format("Failed ArrayList is not empty"));
        }

        [TestMethod]
        public void ClearChar()
        {
            ArrayList<int> target = new ArrayList<int>();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add((char)i);
            }

            target.Clear();

            Assert.IsTrue(target.Count == 0, string.Format("Failed ArrayList is not empty"));
        }

        [TestMethod]
        public void ClearBool()
        {
            ArrayList<bool> target = new ArrayList<bool>();
            Random rand = new Random();

            foreach (int i in Enumerable.Range(1, 999))
            {
                int temp = rand.Next(2, 4);
                if (temp % 2 == 0)
                {
                    target.Add(true);
                }
                else
                {
                    target.Add(false);
                }

            }
            target.Clear();

            Assert.IsTrue(target.Count == 0, string.Format("Failed ArrayList is not empty"));
        }

        [TestMethod]
        public void RemoveInt()
        {
            ArrayList<int> target = new ArrayList<int>();
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
        public void RemoveChar()
        {
            ArrayList<char> target = new ArrayList<char>();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add((char)i);
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target.Remove((char)i) != -1, string.Format("Failed {0} not existing", i));
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target.Count == 0, string.Format("Failed ArrayList is not empty", i));
            }
        }

        [TestMethod]
        public void InsertInt()
        {
            ArrayList<int> target = new ArrayList<int>();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add(i);
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Insert(i - 1, 42);
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target[i - 1] == 42, string.Format("Failed ArrayList item {0} didnt answer the Ultimate Question of Life, the Universe, and Everything", i));
            }
        }

        [TestMethod]
        public void InsertChar()
        {
            ArrayList<char> target = new ArrayList<char>();
            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Add((char)i);
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                target.Insert(i - 1, 'x');
            }

            foreach (int i in Enumerable.Range(1, 999))
            {
                Assert.IsTrue(target[i - 1] == 'x', string.Format("Failed ArrayList item {0} didnt answer the Ultimate Question of Life, the Universe, and Everything", i));
            }
        }

        [TestMethod]
        public void CheckForIntEquality()
        {
            ArrayList<int> targetOne = new ArrayList<int>();
            ArrayList<int> targetTwo = new ArrayList<int>();
            targetOne.Add(1);
            targetOne.Add(2);
            targetTwo.Add(1);
            targetTwo.Add(2);

            for (int i = 0; i < targetOne.Count; i++)
            {
                Assert.AreEqual(targetOne[i], targetTwo[i], string.Format("Failed Lists are not equal."));
            }

        }

        [TestMethod]
        public void CheckForCharEquality()
        {
            ArrayList<char> targetOne = new ArrayList<char>();
            ArrayList<char> targetTwo = new ArrayList<char>();
            targetOne.Add('a');
            targetOne.Add('b');
            targetTwo.Add('a');
            targetTwo.Add('b');

            for (int i = 0; i < targetOne.Count; i++)
            {
                Assert.AreEqual(targetOne[i], targetTwo[i], string.Format("Failed Lists are not equal."));
            }

        }

        [TestMethod]
        public void CheckForIntInequality()
        {
            ArrayList<int> targetOne = new ArrayList<int>();
            ArrayList<int> targetTwo = new ArrayList<int>();
            targetOne.Add(1);
            targetOne.Add(2);
            targetTwo.Add(1);
            targetTwo.Add(3);
            targetTwo.Add(4);

            if (targetOne.Count != targetTwo.Count)
            {
                Assert.AreNotEqual(targetOne, targetTwo, string.Format("Failed Lists are equal."));
            }
            else
            {
                for (int i = 0; i < targetOne.Count; i++)
                {
                    if (targetOne[i] == targetTwo[i])
                    {
                        Assert.AreEqual(targetOne[i], targetTwo[i], string.Format("Failed Lists are not equal."));
                    }
                    else
                    {
                        Assert.AreNotEqual(targetOne, targetTwo, string.Format("Failed Lists are equal."));
                    }
                }
            }
        }

        [TestMethod]
        public void CheckForCharInequality()
        {
            ArrayList<char> targetOne = new ArrayList<char>();
            ArrayList<char> targetTwo = new ArrayList<char>();
            targetOne.Add('a');
            targetOne.Add('b');
            targetOne.Add('c');
            targetTwo.Add('a');
            targetTwo.Add('b');

            if (targetOne.Count != targetTwo.Count)
            {
                Assert.AreNotEqual(targetOne, targetTwo, string.Format("Failed Lists are equal."));
            }
            else
            {
                for (int i = 0; i < targetOne.Count; i++)
                {
                    if (targetOne[i] == targetTwo[i])
                    {
                        Assert.AreEqual(targetOne[i], targetTwo[i], string.Format("Failed Lists are not equal."));
                    }
                    else
                    {
                        Assert.AreNotEqual(targetOne, targetTwo, string.Format("Failed Lists are equal."));
                    }
                }
            }
        }

        [TestMethod]
        public void checkTestClass()
        {
            TestClass testCaseOne = new TestClass { Id = 1, Value = "alpha" };
            TestClass testCaseTwo = new TestClass { Id = 2, Value = "beta" };
            TestClass testCaseThree = new TestClass { Id = 3, Value = "gamma" };

            ArrayList<TestClass> target = new ArrayList<TestClass>();

            target.Add(testCaseOne);
            target.Add(testCaseTwo);
            target.Add(testCaseThree);

            for (int i = 0; i < 3; i++)
            {
                Assert.IsTrue(target[i].Id == i + 1, string.Format("Failed at {0}", i));
            }
        }
    }
}
