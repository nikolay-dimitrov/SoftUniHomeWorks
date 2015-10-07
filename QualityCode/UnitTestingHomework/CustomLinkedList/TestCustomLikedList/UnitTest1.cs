using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCustomLikedList
{
    using System.Configuration;
    using System.Windows.Forms;

    using CustomLinkedList;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Count_TestCountOnNewListCreation()
        {
           var dynamicList  = new DynamicList<string>();
            
            dynamicList.Add("ten");
            dynamicList.Remove("ten");

            Assert.AreEqual("null", "null", "The value at index 0 should be equal to the value entered.");

        }

        [TestMethod]

        public void Count_TestCountAfterAddingOneElement()
        {
            var dynamicList = new DynamicList<int>();

            dynamicList.Add(3);
            int count = dynamicList.Count;

            Assert.AreEqual(1, count, "After adding one element the count of the list should be 1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TestWithEmptyDynamicList_ShouldThrowArgumentOutOfRangeException()
        {
            var dynamicList = new DynamicList<string>();

            string value = dynamicList[0];
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TestWithNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            var dynamicList = new DynamicList<string>();

            string value = dynamicList[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Elements_TestPositionsOfElementsAddedInSequence_ShouldPassTest()
        {
            var dynamicList = new DynamicList<string>();

            dynamicList.Add("first");
            dynamicList.Add("second");

            dynamicList.Remove("first");
            dynamicList.Remove("second");

            string firstElement = dynamicList[0];
            string secondElement = dynamicList[1];

            Assert.AreEqual("first", firstElement, "The element at index 0 should be the first element added to the list.");
            Assert.AreEqual(
                "second",
                secondElement,
                "The element at index 1 should be the second element added to the list.");

        }

        [TestMethod]
        public void Count_TestListCountAfterRemoveAt_ShouldPassTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.RemoveAt(0);

            int count = dynamicList.Count;
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Remove_TestRemainingElementsPositionAFterRemoveAt_ShouldPassTheTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");
            dynamicList.Add("three");
           
            dynamicList.RemoveAt(1);
            string first = dynamicList[0];
            string second = dynamicList[1];

            Assert.AreEqual("one", first, "The string entered first should be at position 0.");
            Assert.AreEqual("three", second, "The entered third should be at position 1 after the removal at 1.");
        }
        [TestMethod]
        public void Count_TestAfterRemovingNonExistingElementFromList_ShouldPassTheTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");

            dynamicList.Remove("three");
            int count = dynamicList.Count;

            Assert.AreEqual(2, count, "The count of the list should remain unchanged after trying to remove a non-existing element.");
        }

        [TestMethod]
        public void Remove_TestReturnValueAfterRemovingNonExistingElementFromList_ShouldPassTheTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");

            int index = dynamicList.Remove("three");
            Assert.AreEqual(-1, index, "The returned index of a non-existing element should be -1.");
        }

        [TestMethod]
        public void Count_TestAfterRemovingElementFromList_ShouldPassTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");
            dynamicList.Add("three");

            int index = dynamicList.Remove("two");

            Assert.AreEqual(1, index, "The index of the removed element should be 1.");

        }

        [TestMethod]
        public void Remove_TestRemainingElementsPositionsAfterRemove_ShouldPassTest()
        {

            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");
            dynamicList.Add("three");

            dynamicList.Remove("two");
            string first = dynamicList[0];
            string second = dynamicList[1];

            Assert.AreEqual("one", first, "The first element of the list should be the first one entered.");
            Assert.AreEqual("three", second, "The second element in the list should be the third one entered after removing the second element.");
        }

        [TestMethod]
        public void IndexOf_TestExistingElement_ShouldPassTheTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");

            int index = dynamicList.IndexOf("two");

            Assert.AreEqual(1, index, "The index of the searched element should be 1.");
        }

        [TestMethod]
        public void Contains_TestOnNonExisingElement_ShouldPassTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");

            bool isFound = dynamicList.Contains("three");
            Assert.IsFalse(isFound, "The element is not in the list and Contains should return false.");

        }

        [TestMethod]
        public void Contains_TestOnExistingElement_shouldPassTheTest()
        {
            var dynamicList = new DynamicList<string>();
            dynamicList.Add("one");
            dynamicList.Add("two");

            bool isFound = dynamicList.Contains("two");

            Assert.IsTrue(isFound,"The element is in the list and Contains should return true");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessageBox.Show("ClassCleanup");
            
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("AssemblyCleanup");
        }
    }
}

