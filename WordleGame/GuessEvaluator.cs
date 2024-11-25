class GuessEvaluator
{
    public static string Evaluate(string guess, string targetWord)
    {
        char[] feedback = new char[5];
        bool[] usedTargetLetters = new bool[5];

        // Grüne Buchstaben (richtige Position)
        for (int i = 0; i < 5; i++)
        {
            if (guess[i] == targetWord[i])
            {
                feedback[i] = '*'; // '*' für grün
                usedTargetLetters[i] = true;
            }
            else
            {
                feedback[i] = '_'; // '_' für falsch
            }
        }

        // Gelbe Buchstaben (richtiger Buchstabe, falsche Position)
        for (int i = 0; i < 5; i++)
        {
            if (feedback[i] == '*') continue; // Bereits korrekt

            for (int j = 0; j < 5; j++)
            {
                if (!usedTargetLetters[j] && guess[i] == targetWord[j])
                {
                    feedback[i] = '~'; // '~' für gelb
                    usedTargetLetters[j] = true;
                    break;
                }
            }
        }

        return new string(feedback);
    }
}

