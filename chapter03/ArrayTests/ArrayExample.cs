using System;

namespace ArrayTests
{
    class ArrayExample
    {
        static void Main() // same concept like in Java, but here I can omit the String [] args if it is not required
        {

            const int ARR_SIZE = 3;
            /*
             * One dimension array
             */
            int[] oneDimension = new int[ARR_SIZE];
            for (int i = 0; i < ARR_SIZE; i++)
            {
                oneDimension[i] = readValue("Type a value", 0, 10);
            }
            for (int i = 0; i < ARR_SIZE; i++)
            {
                Console.WriteLine($"Index: {i} Value: {oneDimension[i]}");
            }

            /*
             * Two dimension array
             */
            int[,] twoDimension = new int[ARR_SIZE, ARR_SIZE];
            for (int i = 0; i < ARR_SIZE; i++)
             {
                for (int j = 0; j < ARR_SIZE; j++)
                {
                    twoDimension[i, j] = readValue($"Row: {i} Column: {j} - Type a value", 0, 10);
                }
            }
            for (int i = 0; i < ARR_SIZE; i++)
            {
                for (int j = 0; j < ARR_SIZE; j++)
                {
                    Console.WriteLine($"Row: {i} Column: {j} Value: {twoDimension[i, j]}");
                }
            }

        }

        static int readValue(string prompt, double low, double high)
        {
            int result;
            do
            {
                Console.WriteLine($"{prompt} between {low} and {high}");
                string resultString = Console.ReadLine();
                result = int.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }
    }
}
