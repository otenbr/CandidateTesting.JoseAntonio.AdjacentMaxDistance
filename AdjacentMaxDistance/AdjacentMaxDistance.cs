using System;

namespace CandidateTesting.JoseAntonio.AdjacentMaxDistance
{
	public class AdjacentMaxDistance
	{
		/// <summary>
		/// Method the return the max distance between the adjancents indexes under the array given.
		/// </summary>
		/// <param name="A">Array of numbers</param>
		/// <returns>Max distance. If there is not adjacents index the returned value is -2.</returns>
		public static int Solution(int[] A)
		{
			// Throw exception if the length of array be greater than 40000 items.
			if (A.Length > 40000)
				throw new ArgumentException("The array A can contain up to 40000 items.", nameof(A));

			// Variable that store the max distance.
			int maxAdjacentDistance = -2;

			// Iterate to the array of numbers with indexes P=i and Q=i+1. Following the rule 0 ≤ P < Q < N.
			for (int i = 0; i < A.Length; i++)
			{
				for (int j = i + 1; j < A.Length; j++)
				{
					if (AreIndexesAdjacents(A, i, j))
					{
						int distance = Math.Abs(A[i] - A[j]);

						// Update maxAdjacentDistance, if distance is greater than previous value of maxAdjacentDistance
						maxAdjacentDistance = distance > maxAdjacentDistance ? distance : maxAdjacentDistance;
					}
				}
			}

			return maxAdjacentDistance;
		}

		/// <summary>
		/// Method that verify if two indexes are adjacents under the array of numbers given
		/// </summary>
		/// <param name="numbers">Array of numbers</param>
		/// <param name="firstIndex">First index to verify</param>
		/// <param name="lastIndex">Last index to verify</param>
		/// <returns>True/False</returns>
		private static bool AreIndexesAdjacents(int[] numbers, int firstIndex, int lastIndex)
		{
			// Get the values for the first e last indexes
			int firstValue = numbers[firstIndex];
			int lastValue = numbers[lastIndex];

			return !Array.Exists(numbers, x => (firstValue < x && x < lastValue) || (firstValue > x && x > lastValue));
		}
	}
}
