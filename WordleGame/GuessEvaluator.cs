using System;
 
class GuessEvaluator
{
    public static void EvaluateAndDisplay(string guess, string targetWord)
    {
        bool[] usedTargetLetters = new bool[5];
 
        // Zuerst grüne Buchstaben (richtige Position)
        for (int i = 0; i < 5; i++)
        {
            if (guess[i] == targetWord[i])
            {
                SetConsoleColor(ConsoleColor.Green);
                Console.Write(guess[i]);
                Console.ResetColor();
                usedTargetLetters[i] = true;
            }
            else
            {
                Console.Write("_"); // Platzhalter für falsche Buchstaben
            }
        }
        Console.WriteLine();
 
        // Gelbe Buchstaben (richtiger Buchstabe, falsche Position)
        for (int i = 0; i < 5; i++)
        {
            if (guess[i] != targetWord[i]) // Nur falsche Buchstaben prüfen
            {
                bool found = false;
                for (int j = 0; j < 5; j++)
                {
                    if (!usedTargetLetters[j] && guess[i] == targetWord[j])
                    {
                        found = true;
                        usedTargetLetters[j] = true;
                        break;
                    }
                }
 
                if (found)
                {
                    SetConsoleColor(ConsoleColor.Yellow);
                    Console.Write(guess[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(guess[i]); // Keine Färbung für falsche Buchstaben
                }
            }
        }
        Console.WriteLine();
    }
 
    private static void SetConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }
}

