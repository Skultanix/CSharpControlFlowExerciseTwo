namespace ControlFlowExercisesTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric value");
            var numOne = Console.ReadLine();
            Console.WriteLine("Now enter in another numeric value");
            var numTwo = Console.ReadLine();
            var numOneValue = int.Parse(numOne);
            var numTwoValue = int.Parse(numTwo);

            if(numOneValue > numTwoValue)
            {
                Console.WriteLine(string.Format("Of the two values, {0} is greater than {1}.", numOneValue, numTwoValue));
            } else if(numOneValue < numTwoValue)
            {
                Console.WriteLine(string.Format("Of the two values, {0} is greater than {1}.", numTwoValue, numOneValue));
            } else if(numOneValue == numTwoValue)
            {
                Console.WriteLine("The two values are equal.");
            }
        }
    }
}