using System;
using System.Text;

namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] path = input.ToCharArray();

            int indexOfFullFilename = Array.LastIndexOf(path, '\\');
            string fullFilename = input.Substring(indexOfFullFilename + 1);
            char[] fullFilenameArray = fullFilename.ToCharArray();
            int indexOfFileExtension = Array.LastIndexOf(fullFilenameArray, '.');
            string fileName = fullFilename.Remove(indexOfFileExtension);
            string extensionName = fullFilename.Substring(indexOfFileExtension + 1);

            
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensionName}");

        }
    }
}