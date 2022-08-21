namespace LinearSearch
{
    public class LinearSearch
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 6, 2, 9, 8 };

            if (LinearSearchAlgorithm(array, 6))
            {
                Console.WriteLine("Key is present");
            }
            else
            {
                Console.WriteLine("Could not find.");
            }

            Console.ReadLine();
        }

        public static bool LinearSearchAlgorithm(int[] nums, int key)
        {
            var isFound = false;

            foreach (var num in nums)
            {
                if (num == key)
                {
                    isFound = true;

                    break;
                }
            }

            return isFound;
        }
    }
}