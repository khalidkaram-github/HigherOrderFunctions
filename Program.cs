namespace HigherOrderFunctions
{
    public class Program
    {
        //Example 1: Using Func<> to Pass Functions as Arguments
        static int Double(int x) => x * 2;
        static int Square(int x) => x * x;

        static void Main()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Items :  " + string.Join(", ", numbers));

            var doubledNumbers = ProcessNumbers(numbers, Double);
            Console.WriteLine("Doubled: " + string.Join(", ", doubledNumbers));

            var squaredNumbers = ProcessNumbers(numbers, Square);
            Console.WriteLine("Squared: " + string.Join(", ", squaredNumbers));
        }
        static List<int> ProcessNumbers(List<int> numbers, Func<int, int> operation)
        {
            var result = new List<int>();
            foreach (int number in numbers)
            {
                result.Add(operation(number));
            }
            return result;
        }
    }
}

