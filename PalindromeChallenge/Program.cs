// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;

string userInput;

// Introduction
Console.WriteLine("\nEnter a word or phrase and I will tell you if it's a palindrome and the letter count!");
Console.WriteLine("--> Type 'exit' to quit.");
Console.WriteLine("\nLet's begin!");

// Program Logic
do
{
    Console.Write("Enter a word or phrase: ");
    userInput = Console.ReadLine().ToLower();

    if (userInput != "exit")
    {
        (bool, int) result = IsPalindrome(userInput);
        Console.WriteLine($"Palindrome: {result.Item1}, Character count: {result.Item2}");
    }
    else
    {
        Console.WriteLine("\nGoodbye!\n");
    }
} while (userInput != "exit");


static (bool, int) IsPalindrome(string input)
{
    // strip out numbers, spaces, and special characters
    string testWord = Regex.Replace(input, "[^a-zA-Z]", "");
    Console.WriteLine(testWord);

    // loop through the string, comparing each index to it's opposite index
    for (int i = 0; i < testWord.Length; i++)
    {
        if (testWord[i] != testWord[^(i + 1)])
        {
            return (false, testWord.Length);
        }
    }
    return (true, testWord.Length);
}


// Tuple function
/*static (bool, int) IsPalindrome(string input)
{
    bool isPalindrome = false;
    string inputFormatted;
    string inputReversed;
    int stringLength = input.Length;

    // Create a new string without any puncuation or spaces
    StringBuilder sb = new();
    foreach (char c in input)
    {
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) { sb.Append(c); }
    }

    inputFormatted = sb.ToString();
    sb.Clear();

    // Reverse the input and check for equality
    for (int i = inputFormatted.Length - 1; i >= 0; i--)
    {
        sb.Append(inputFormatted[i]);
    }
    inputReversed = sb.ToString();
    Console.WriteLine(inputReversed);

    isPalindrome = inputReversed == inputFormatted ? true : false;

    Console.WriteLine($"Input formatted: {inputFormatted}");
    Console.WriteLine($"Input reversed: {inputReversed}");

    return (isPalindrome, stringLength);
}*/

