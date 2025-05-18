namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
            Console.WriteLine("Please enter the word you desire.");
            string wordfind = Console.ReadLine();
            for (int i = 0; i < fruits.Length; i++)
            {
                if (wordfind == fruits[i])
                {
                    Console.WriteLine("True");
                    break;
                }
                else if (wordfind != fruits[i])
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
