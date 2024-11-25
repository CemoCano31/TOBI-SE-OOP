using System;

class Program
{
    static void Main(string[] args)
    {
        WordleGame game = new WordleGame("salbe", 6); // Zielwort "salbe", max. 6 Versuche
        game.Start();
    }
}
