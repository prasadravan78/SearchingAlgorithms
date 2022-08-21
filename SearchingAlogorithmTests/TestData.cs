namespace SearchingAlogorithmTests
{
    public class TestData
    {
        public static Dictionary<int[], int> GetInValidInputs()
        {
            var sampleData = new Dictionary<int[], int>();

            sampleData.Add(new int[] { 3, 1 }, 2);
            sampleData.Add(new int[] { 9, 5, 8, -1, 4 }, -4);
            sampleData.Add(new int[] { 1, 2, 3, 4, 5, 6 }, 9);
            sampleData.Add(new int[] { -1 }, 8);
            sampleData.Add(new int[] { 5, 0, 6, 7, 8, 9, 2 }, 1);

            return sampleData;
        }

        public static Dictionary<int[], int> GetValidInputs()
        {
            var sampleData = new Dictionary<int[], int>();

            sampleData.Add(new int[] { 3, 1 }, 3);
            sampleData.Add(new int[] { 9, 5, 8, -1, 4 }, -1);
            sampleData.Add(new int[] { 1, 2, 3, 4, 5, 6 }, 4);
            sampleData.Add(new int[] { -1 }, -1);
            sampleData.Add(new int[] { 5, 0, 6, 7, 8, 9, 2 }, 0);

            return sampleData;
        }

        public static Dictionary<int[], int> GetValidInputsBinarySearch()
        {
            var sampleData = new Dictionary<int[], int>();

            sampleData.Add(new int[] { -3, 1 }, -3);
            sampleData.Add(new int[] { -9, -5, -8, -1, 4 }, -1);
            sampleData.Add(new int[] { 1, 2, 3, 4, 5, 6 }, 4);
            sampleData.Add(new int[] { -1 }, -1);
            sampleData.Add(new int[] { -5, 0, 6, 7, 8, 9, 22 }, 0);

            return sampleData;
        }

        public static Dictionary<int[], int> GetInValidInputsBinarySearch()
        {
            var sampleData = new Dictionary<int[], int>();

            sampleData.Add(new int[] { -3, 1 }, 3);
            sampleData.Add(new int[] { -9, -5, -8, 1, 4 }, -1);
            sampleData.Add(new int[] { 1, 2, 3, 4, 5, 6 }, 7);
            sampleData.Add(new int[] { -1 }, -2);
            sampleData.Add(new int[] { -5, 0, 6, 7, 8, 9, 22 }, 1);

            return sampleData;
        }
    }
}