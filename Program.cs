namespace Assignment5_2_1
{
    internal class Program
    {
        // Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.
        static void Main(string[] args)
        {
            string word = "This is a sentence";
            Console.WriteLine($"Last word legnth: {ReturnSubstringLength(word)}");
            Console.WriteLine($"Last word legnth: {ReturnSubstringLengthWhile(word)}");
            Console.WriteLine($"Last word legnth: {ReturnSubstringLengthSplit(word)}");
        }

        // <========Issues Found=========>
        // Trailing white space, single char strings, and one word senetnce with no white space.
        // Split method + trim is one solution for these issues

        // Find Length of the Last word in a sentence with a for loop
        static int ReturnSubstringLength(string word)
        {
            word = word.Trim();
            int n = word.Length;

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (word[n - i - 1] == ' ')
                {
                    break;
                }
                count++;
            }
            return count;
        }

        // Find Length of the Last word in a sentence with a while loop
        static int ReturnSubstringLengthWhile(string word)
        {
            word = word.Trim();
            int n = word.Length;
            int count = 0;
            int i = 0;
            while (word[n - i - 1] != ' ')
            {
                i++;
                count++;

            }
            return count;
        }

        // Find Length of the last word in a sentence with a string.split(' ')
        static int ReturnSubstringLengthSplit(string word)
        {
            word = word.Trim();
            string[] subStrings = word.Split(" ");

            return subStrings[subStrings.Length - 1].Length;
        }
    }
}
