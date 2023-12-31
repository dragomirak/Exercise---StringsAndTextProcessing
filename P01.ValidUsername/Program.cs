﻿namespace P01.ValidUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                if (IsValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValidUsername(string username)
        {
            return username.All(ch => char.IsLetterOrDigit(ch) || ch == '-' || ch == '_');
        }
    }
}