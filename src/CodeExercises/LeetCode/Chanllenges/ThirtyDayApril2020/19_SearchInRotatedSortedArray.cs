namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class SearchInRotatedSortedArray
    {
        public int Resolve(int[] nums, int target)
        {
            if (nums?.Length == 0)
                return -1;

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                var current = nums[middle];
                var currentLeft = nums[left];
                var currentRight = nums[right];

                if (current == target)
                    return middle;

                if (current < currentLeft)
                {
                    if (target <= currentRight && target > current)
                        left = middle + 1;
                    else
                        right = middle - 1;
                }
                else if (current > currentRight)
                {
                    if (target >= currentLeft && target < current)
                        right = middle - 1;
                    else
                        left = middle + 1;
                }
                else
                {
                    if (target > current)
                        left = middle + 1;
                    else
                        right = middle - 1;
                }
            }

            return -1;
        }
    }
}
