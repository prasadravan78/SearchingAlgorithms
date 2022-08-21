namespace SearchingAlogorithmTests
{
    using System;
    using BinarySearch;

    public class BinarySearchTests : TestData
    {
        [Test]
        public void BinarySearchValidInput()
        {
            RunTestsForBinarySearchValid(BinarySearch.BinarySearchAlgorithm);
        }

        [Test]
        public void BinarySearchInValidInput()
        {
            RunTestsForBinarySearchInvalid(BinarySearch.BinarySearchAlgorithm);
        }

        private void RunTestsForBinarySearchValid(Func<int[], int, bool> binarySearchAlgorithm)
        {
            var inputData = GetValidInputsBinarySearch();

            foreach (var keyValuePair in inputData)
            {
                var result = binarySearchAlgorithm(keyValuePair.Key, keyValuePair.Value);

                Assert.That(result, Is.EqualTo(true));
            }
        }

        private void RunTestsForBinarySearchInvalid(Func<int[], int, bool> binarySearchAlgorithm)
        {
            var inputData = GetInValidInputsBinarySearch();

            foreach (var keyValuePair in inputData)
            {
                var result = binarySearchAlgorithm(keyValuePair.Key, keyValuePair.Value);

                Assert.That(result, Is.EqualTo(false));
            }
        }
    }
}