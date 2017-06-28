namespace Task_01
{
    public static class SumArray
    {
        public static int Sum(this int[] arr, int n, int sum)
        {
            sum = 0;
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
