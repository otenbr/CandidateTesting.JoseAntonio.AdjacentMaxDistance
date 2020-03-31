using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CandidateTesting.JoseAntonio.AdjacentMaxDistance.Tests
{
    [TestClass]
    public class AdjacentMaxDistanceTests
    {
        [TestMethod]
        public void MustReturnTheMaxDistance()
        {
            int[] A = new int[] { 0, -3, 3, -12, 5, -3, 7, -1 };
            int result = AdjacentMaxDistance.Solution(A);

            // Max Distance: A[1] - A[3] = -3 - (-12) = 9
            int expectedValue = 9;

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void MustReturnTheMaxDistanceForPositiveValues()
        {
            int[] A = new int[] { 0, 3, 3, 12, 5, 3, 7, 1 };
            int result = AdjacentMaxDistance.Solution(A);

            // Max Distance: A[3] - A[6] = 12 - 5 = 5
            int expectedValue = 5;

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void MustReturnTheMaxDistanceForNegativeValues()
        {
            int[] A = new int[] { 0, -3, -3, -2, -5, -3, -7, -1 };
            int result = AdjacentMaxDistance.Solution(A);

            // Max Distance: A[1] - A[4] = -3 - (-5) = 2
            int expectedValue = 2;

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IfThereIsNoAdjacentIndexes()
        {
            int[] A = new int[] { 1 };

            int result = AdjacentMaxDistance.Solution(A);
            int expectedValue = -2;

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void MustThrowExceptionIfArrayBiggerThen40000Items()
        {
            int[] A = new int[40001];

            Assert.ThrowsException<System.ArgumentException>(() => AdjacentMaxDistance.Solution(A));
        }
    }
}
