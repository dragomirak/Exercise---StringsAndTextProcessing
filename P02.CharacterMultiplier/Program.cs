namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string firstString = input[0];
            string secondString = input[1];

            int result = GetSum(firstString, secondString);
            Console.WriteLine(result);

        }

        private static int GetSum(string firstString, string secondString)
        {
            int sum = 0;
            int counter = Math.Min(firstString.Length, secondString.Length);
            for (int i = 0; i < counter; i++)
            {
                int result = firstString[i] * secondString[i];
                sum += result;
            }

            if (firstString.Length > secondString.Length)
            {

                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }
            else if (firstString.Length < secondString.Length)
            {
                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }

            return sum;
        }
    }
}