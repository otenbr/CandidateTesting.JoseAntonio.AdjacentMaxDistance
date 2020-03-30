using System;
using System.Collections.Generic;
using System.Diagnostics;

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
			List<int[]> indexes = new List<int[]>();
			List<int> distanceIndexes = new List<int>();

			int maxAdjacentDistance = -2;

			// Walk to the array of numbers with indexes P=i and Q=i+1. Following the rule 0 ≤ P < Q < N.
			for (int i = 0; i < A.Length; i++)
			{
				for (int j = i + 1; j < A.Length; j++)
				{
					if (AreIndexesAdjacents(A, i, j))
					{
						int distance = Math.Abs(A[i] - A[j]);

						Debug.WriteLine($"( {i}, {j} ) => ( {A[i]}, {A[j]} ) = {distance}");

						indexes.Add(new int[] { i, j, A[i], A[j], distance });
						distanceIndexes.Add(distance);

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

			if (firstValue < lastValue)
			{
				return Array.FindAll(numbers, x => (firstValue < x && x < lastValue)).Length == 0;
			}

			if (firstValue > lastValue)
			{
				return Array.FindAll(numbers, x => (firstValue > x && x > lastValue)).Length == 0;
			}

			return false;
		}
	}
}
