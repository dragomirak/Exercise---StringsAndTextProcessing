namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = bigNumber[i] - '0';
                remainder += digit * multiplier;
                if (remainder > 9)
                {
                    int digitToAdd = remainder % 10;
                    remainder = remainder / 10;
                    result.Add(digitToAdd.ToString());
                }
                else
                {
                    result.Add(remainder.ToString());
                    remainder = 0;
                }
            }

            if (remainder > 0)
            {
                result.Add(remainder.ToString());
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}