namespace SearchingAlogorithmTests
{
    using System;
    using LinearSearch;

    [TestFixture]
    public class LinearSearchTests : TestData
    {
        [Test]
        public void LinearSearchValidInput()
        {
            RunTestsForLinearSearchValid(LinearSearch.LinearSearchAlgorithm);
        }

        [Test]
        public void LinearSearchInValidInput()
        {
            RunTestsForLinearSearchInvalid(LinearSearch.LinearSearchAlgorithm);
        }

        private void RunTestsForLinearSearchValid(Func<int[], int, bool> linearSearchAlgorithm)
        {
            var inputData = GetValidInputs();

            foreach (var keyValuePair in inputData)
            {
                var result = linearSearchAlgorithm(keyValuePair.Key, keyValuePair.Value);

                Assert.That(result, Is.EqualTo(true));
            }
        }

        private void RunTestsForLinearSearchInvalid(Func<int[], int, bool> linearSearchAlgorithm)
        {
            var inputData = GetInValidInputs();

            foreach (var keyValuePair in inputData)
            {
                var result = linearSearchAlgorithm(keyValuePair.Key, keyValuePair.Value);

                Assert.That(result, Is.EqualTo(false));
            }
        }
    }
}