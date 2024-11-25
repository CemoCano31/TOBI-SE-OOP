using System;
using System.Collections.Generic;
 
class WordleGame
{
    private readonly string targetWord;
    private readonly int maxAttempts;
    private List<string> attempts;
 
    public WordleGame(string targetWord, int maxAttempts)
    {
        this.targetWord = targetWord.ToLower();
        this.maxAttempts = maxAttempts;
        this.attempts = new List<string>();
    }
 
    public void Start()
    {
        Console.WriteLine($"Willkommen bei Wordle! Du hast {maxAttempts} Versuche, das Wort zu erraten.");
        Console.WriteLine("Das Wort hat genau 5 Buchstaben.");
 
        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.Write($"\nVersuch {attempt}/{maxAttempts}: ");
            string guess = Console.ReadLine() .ToLower();
 
            // Validierung der Eingabe
            if (!InputValidator.ValidateInput(guess))
            {
                Console.WriteLine("Das Wort muss genau 5 Buchstaben haben. Versuche es erneut.");
                attempt--;
                continue;
            }
 
            // Bewertung des Versuchs
            GuessEvaluator.EvaluateAndDisplay(guess, targetWord);
 
            // Speichere den Versuch
            attempts.Add(guess);
 
            // Gewinnüberprüfung
            if (guess == targetWord)
            {
                Console.WriteLine("\nGlückwunsch! Du hast das Wort erraten!");
                return;
            }
        }
 
        // Spiel verloren
        Console.WriteLine($"\nSchade! Du hast das Wort nicht erraten. Das gesuchte Wort war: {targetWord}");
    }
}