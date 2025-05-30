﻿namespace ConsoleLingo;

class Program
{
    static string[] wordlist = {"appel", "actie", "breed", "blind", "cadet", "creme",
                                "deren", "dweil", "elven", "engel", "feest", "flora", "grote",
                                "gebak", "hamer", "hoofd", "index", "icoon", "jawel", "japon",
                                "kraan", "kleur", "licht", "laser", "motor", "markt", "nodig", "neven",
                                "oases", "onwel", "polis", "preek", "quota", "quark", "ruzie", "schat",
                                "treur", "typen", "uniek", "ultra", "vloer", "vorst", "wreed", "wazig",
                                "xenon", "yacht", "yucca", "zomer", "zagen"};

    const int MAX_WORD_LENGTH = 5;
    const int MAX_ATTEMPTS = 5;

    static void Main(string[] args)
    {
        // TODO 1: Put the word generation in a function that returns the word.
        // Call the function here
        string wordToBeGuessed = GenerateWord();
#if DEBUG
        Console.WriteLine(wordToBeGuessed);
#endif
        int attempt;
        for (attempt = 1; attempt <= MAX_ATTEMPTS; attempt++)
        {
            // TODO 2: Create a function to handle the user input
            string? guess = AskWord(attempt);
            // TODO 3: Create a function to validate the input
            if (!IsValidInput(guess)) continue;
            // TODO 4: Create a function to check if the words are equal
            if (AreEqual(guess, wordToBeGuessed))
            {
                Console.WriteLine("Geraden");
                break;
            }
            else
            {
                Console.WriteLine("Niet juist");
            }
        }
        // TODO 5: Create a function that shows the IQ level
        ShowIQ(attempt);

        Console.ReadLine();
    }

     static void ShowIQ(int attempt)
    {
        switch (attempt)
        {
            case 1:
                Console.WriteLine("Your IQ level is brilliant");
                break;
            case 2:
                Console.WriteLine("Your IQ level is bright");
                break;
            case 3:
                Console.WriteLine("Your IQ level is average");
                break;
            case 4:
                Console.WriteLine("Your IQ level is mediocre");
                break;
            case 5:
                Console.WriteLine("Your IQ level is stupid");
                break;
            default:
                Console.WriteLine("Your IQ level is so low that it cannot be expressed ");
                break;
        }
    }

     static bool AreEqual(string? guess, string wordToBeGuessed)
    {
        return guess == wordToBeGuessed;
        //if (guess == wordToBeGuessed)
        //{
        //    return true;
        //}
        //return false;
    }

     static bool IsValidInput(string? guess)
    {
        if (guess == null || guess.Length != MAX_WORD_LENGTH)
        {
            Console.WriteLine("Ongeldig woord");
            return false;
        }
        return true;
    }

     static string? AskWord(int attempt)
    {
        Console.WriteLine($"{attempt}e beurt. Geef een woord");
        return Console.ReadLine();
    }

    static string GenerateWord()
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        int idx = rnd.Next(0, wordlist.Length);
        return wordlist[idx];
    }
}