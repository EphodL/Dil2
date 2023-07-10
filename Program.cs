using System; 

namespace Methods_2
{
    class Program
    {
        static int[] RandomArray(int arrayLen)
        {
            Random random = new Random();
            int[] myArray = new int[arrayLen];
            for (int i = 0; i < arrayLen; i++)
            {
                myArray[i] = random.Next(10, 51);
            }
            return myArray;
        }
        static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 5 and 15");
            int input = int.Parse(Console.ReadLine());

            if (input >= 5 && input <= 15)
            {
                int[] myArray = RandomArray(input);
                Console.WriteLine("The elements in the random array are: ");
                foreach (int i in myArray)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();

                Console.WriteLine("The sum is: " + Sum(myArray));
            }
            else
            {
                Console.WriteLine("Invalid input. Number should be between 5 and 15.");
            }
        }
    }
}

