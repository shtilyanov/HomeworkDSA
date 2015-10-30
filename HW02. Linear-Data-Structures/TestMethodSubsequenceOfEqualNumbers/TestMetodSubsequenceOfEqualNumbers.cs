namespace TestMethodSubsequenceOfEqualNumbers
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _04.LongestSubsequenceEqualNumbers;

    [TestClass]
    public class TestMetodSubsequenceOfEqualNumbers
    {
        [TestMethod]
        public void TestIfMethodSubsequenceOfEqualNumbersReturnsCorrectList()
        {
            var testSequence = new List<int>() { 1, 2, 2, 2, 1, 4, 4, 2, 3, 4, 4, 3 };

            var expectedResult = new List<int>() { 2, 2, 2 };

            var someObject = new LongestSubsequenceOfEqualNumbers();

            CollectionAssert.AreEqual(expectedResult, someObject.SubsequenceOfEqualNumbers(testSequence));
        }

        [TestMethod]
        public void TestIfMethodSubsequenceOfEqualNumbersReturnsCorrectListIfSequenceIsAtTheEnd()
        {
            var testSequence = new List<int>() { 1, 2, 2, 2, 1, 4, 4, 2, 3, 4, 4, 4, 4 };

            var expectedResult = new List<int>() { 4, 4, 4, 4 };

            var someObject = new LongestSubsequenceOfEqualNumbers();

            CollectionAssert.AreEqual(expectedResult, someObject.SubsequenceOfEqualNumbers(testSequence));
        }

        [TestMethod]
        public void TestIfMethodSubsequenceOfEqualNumbersReturnsCorrectListIfSequenceIsAtTheBeginning()
        {
            var testSequence = new List<int>() { 2, 2, 2, 2, 1, 4, 4, 2, 3, 4, 4, 4, 4 };

            var expectedResult = new List<int>() { 2, 2, 2, 2 };

            var someObject = new LongestSubsequenceOfEqualNumbers();

            CollectionAssert.AreEqual(expectedResult, someObject.SubsequenceOfEqualNumbers(testSequence));
        }

        [TestMethod]
        public void TestIfMethodSubsequenceOfEqualNumbersReturnsCorrectListIfSequenceIsEmpty()
        {
            var testSequence = new List<int>();

            var expectedResult = new List<int>();

            var someObject = new LongestSubsequenceOfEqualNumbers();

            CollectionAssert.AreEqual(expectedResult, someObject.SubsequenceOfEqualNumbers(testSequence));
        }

        [TestMethod]
        public void TestIfMethodSubsequenceOfEqualNumbersReturnsFirstElementIfThereIsNoSubsequenceOfEqualNumbers()
        {
            var testSequence = new List<int>() {-1,1,2,3,0,4,77,85,2,55,32,0,3};

            var expectedResult = new List<int>(){-1};

            var someObject = new LongestSubsequenceOfEqualNumbers();

            CollectionAssert.AreEqual(expectedResult, someObject.SubsequenceOfEqualNumbers(testSequence));
        }
    }
}
