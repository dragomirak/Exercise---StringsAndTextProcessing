using System.Text;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = (char)(input[i] + 3);
                output = sb.Append(currentSymbol).ToString();

            }

            Console.WriteLine(output);
        }
    }
}