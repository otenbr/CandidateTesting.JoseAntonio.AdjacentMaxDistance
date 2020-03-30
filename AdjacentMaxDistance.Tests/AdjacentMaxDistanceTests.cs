using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CandidateTesting.JoseAntonio.AdjacentMaxDistance.Tests
{
    [TestClass]
    public class AdjacentMaxDistanceTests
    {
        [TestMethod]
        public void ShouldReturnTheMaxDistanceBetweenAdjacentIndexes()
        {
            int[] numbers = new int[] { 0, 3, 3, 12, 5, 3, 7, 1 };
            int result = AdjacentMaxDistance.Solution(numbers);
            int expectedValue = 5;

            Assert.AreEqual(expectedValue, result);


            numbers = new int[] { 0, 3, 3, 7, 5, 3, 11, 1 };
            result = AdjacentMaxDistance.Solution(numbers);
            expectedValue = 4;

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ShouldReturnTheMaxDistanceForNegativeValues()
        {
            int[] numbers = new int[] { 0, 3, 3, -2, 5, 3, 7, 1 };

            int result = AdjacentMaxDistance.Solution(numbers);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void IfThereAreNoAdjacentIndexes()
        {
            int[] numbers = new int[] { 0, 1, 2 };

            int result = AdjacentMaxDistance.Solution(numbers);

            Assert.AreEqual(1, result);
        }
    }
}
