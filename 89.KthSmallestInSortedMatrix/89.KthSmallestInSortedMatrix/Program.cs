using System;

namespace _89.KthSmallestInSortedMatrix
{
    class Program
    {
		//https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/discuss/1324286/C-Solution
		//https://www.youtube.com/watch?v=oeQlc87HbbQ
		public int KthSmallest(int[][] matrix, int k)
		{
			if (matrix == null) return 0;

			int n = matrix.Length;
			int left = matrix[0][0];
			int right = matrix[n - 1][n - 1];

			while (left < right)
			{
				int mid = left + (right - left) / 2;
				int count = 0;

				for (int i = 0; i < n; i++)
					for (int j = n - 1; j >= 0; j--)
						if (matrix[i][j] <= mid)
							count++;

				if (count < k)
					left = mid + 1;
				else
					right = mid;
			}

			return left;
		}
		static void Main(string[] args)
        {
			int[][] matrix = new int[3][]
	  {
				new int[]{ 1,5,9 },
				 new int[]{ 10,11,13},
				 new int[]{ 12,13,15},

	  };
			Program p = new Program();
			int result = p.KthSmallest(matrix,8);
			Console.WriteLine(result);
		}
    }
}
