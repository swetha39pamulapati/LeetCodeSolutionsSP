using System;

namespace _142.firstMissingPositiveInteger
{
    class Program
    {
		public int FirstMissingPositive(int[] nums)
		{
			var n = nums.Length;
			for (var i = 0; i < n; ++i)
				while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
					Swap(i, nums[i] - 1); //ascending order

			for (var i = 0; i < n; ++i)
				if (nums[i] != i + 1)
					return i + 1;

			return n + 1;

			void Swap(int i, int j)
			{
				var tmp = nums[i];
				nums[i] = nums[j];
				nums[j] = tmp;
			}
		}
		static void Main(string[] args)
        {
			Program p = new Program();
			int[] data = { 3, 4, -1, 1 };
		int result =	p.FirstMissingPositive(data);
            Console.WriteLine(result);
        }
    }
}
