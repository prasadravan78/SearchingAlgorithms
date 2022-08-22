namespace BinarySearch
{
    public class BinarySearch
    {
        static void Main()
        {
            var array = new int[] { -3,1 };

            if (BinarySearchAlgorithm(array, -3))
            {
                Console.WriteLine("Key is present");
            }
            else
            {
                Console.WriteLine("Could not find.");
            }

            Console.ReadLine();
        }

        public static bool BinarySearchAlgorithm(int[] nums, int key)
        {
            var low = 0;
            var high = nums.Length;
            var isFound = false;

            while (low < high)
            {
                var mid = (low + high) / 2;

                if (nums[mid] == key)
                {
                    isFound = true;
                    break;
                }
                else if (nums[mid] < key)
                {
                    low = mid + 1;
                }
                else if (nums[mid] > key)
                {
                    high = mid;
                }
            }

            return isFound;
        }
    }
}