namespace StackHeapRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3,4,5 };
            CustomResize(ref numbers, 15,20,25);

            Console.WriteLine("New array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static void CustomResize(ref int[] arr, params int[] numbers)
        {
            int newSize = arr.Length + numbers.Length;
            int[] newArr = new int[newSize];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                newArr[arr.Length + i] = numbers[i];
            }

            arr = newArr;
        }
    }
}