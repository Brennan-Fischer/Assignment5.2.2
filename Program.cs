namespace Assignment5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to print 1 to said number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int i= printNumbers(1, userInput);



           static int printNumbers(int start, int end)
                {
                if (start <= end) 
                {
                    Console.WriteLine(start);
                    start++;
                    printNumbers(start, end);
                }
                Console.WriteLine("Program complete");
                return start;

            }
        }
    }
}
