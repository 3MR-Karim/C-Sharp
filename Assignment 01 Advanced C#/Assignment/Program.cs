namespace Assignment
{
    internal class Program
    {
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap the elements
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        // Set the flag to true
                        swapped = true;
                    }
                }

                // If no elements were swapped, the array is sorted
                if (!swapped)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            #region BubbleSort Optimization
            /*The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases,
             *which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
              And implement the code of this optimized bubble sort algorithm
            */
            //int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            //Console.WriteLine("Original array: " + string.Join(", ", array));

            //BubbleSort(array);

            //Console.WriteLine("Sorted array: " + string.Join(", ", array));
            #endregion

            #region Question 2
            //// Example with integers
            //Range<int> intRange = new Range<int>(1, 10);
            //Console.WriteLine($"Is 5 in range: {intRange.IsInRange(5)}");  
            //Console.WriteLine($"Is 15 in range: {intRange.IsInRange(15)}"); 
            //Console.WriteLine($"Length of range: {intRange.Length()}");     

            //// Example with doubles
            //Range<double> doubleRange = new Range<double>(0.5, 5.5);
            //Console.WriteLine($"Is 3.3 in range: {doubleRange.IsInRange(3.3)}");  
            //Console.WriteLine($"Length of range: {doubleRange.Length()}");        

            //// Example with DateTime
            //Range<DateTime> dateRange = new Range<DateTime>(
            //    new DateTime(2023, 1, 1), new DateTime(2023, 12, 31));
            //Console.WriteLine($"Is 2023-06-15 in range: {dateRange.IsInRange(new DateTime(2023, 6, 15))}");  
            //Console.WriteLine($"Is 2024-01-01 in range: {dateRange.IsInRange(new DateTime(2024, 1, 1))}"); 
        }
    }
    #endregion
}
    

