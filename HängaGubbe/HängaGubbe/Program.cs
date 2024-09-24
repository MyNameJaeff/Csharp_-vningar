using HängaGubbe;

void HandleGame()
{
    Console.WriteLine("Hänga gubbe! Här kör vi:");
    Ord ord = GenerateWord(); // Generate the word to guess
    int guesses = 7;          // Number of allowed wrong guesses
    char[] guessedWord = new string('_', ord.Word.Length).ToCharArray(); // Mask of the word with underscores
    HashSet<char> guessedLetters = new HashSet<char>(); // Track guessed letters

    while (guesses > 0 && !string.Equals(new string(guessedWord), ord.Word, StringComparison.OrdinalIgnoreCase))
    {
        // Display the current state of the word (with unguessed letters as underscores)
        Console.WriteLine($"\n{guesses} gissningar kvar: {new string(guessedWord)}");
        Console.Write("Skriv bokstav: ");
        string input = Console.ReadLine()?.ToLower();
        
        if (string.IsNullOrEmpty(input) || input.Length != 1)
        {
            Console.WriteLine("Ogiltig input, försök igen.");
            continue; // Ask for input again if it's not valid
        }

        char guess = input[0];

        // If the user has already guessed this letter, notify them
        if (guessedLetters.Contains(guess))
        {
            Console.WriteLine("Du har redan gissat den bokstaven!");
            continue; // Skip the rest of the loop and ask for a new guess
        }

        guessedLetters.Add(guess); // Add the letter to the set of guessed letters

        // Check if the guessed letter is in the word
        if (ord.Word.ToLower().Contains(guess))
        {
            Console.WriteLine("Korrekt!");

            // Reveal the correct guesses in the word
            for (int i = 0; i < ord.Word.Length; i++)
            {
                if (Char.ToLower(ord.Word[i]) == guess)
                {
                    guessedWord[i] = guess; // Replace underscore with the correct letter
                }
            }
        }
        else
        {
            Console.WriteLine($"FEL! {guesses - 1} gissningar kvar.");
            guesses--; // Decrement the guess counter if the letter is wrong
        }
    }

    // End of game: check if the user won or lost
    if (string.Equals(new string(guessedWord), ord.Word, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Grattis! Du gissade rätt! Ordet var: {ord.Word}");
    }
    else
    {
        Console.WriteLine($"Tyvärr, du förlorade. Ordet var: {ord.Word}");
    }
}


Ord GenerateWord()
{
    string[] wordList = { "Exakt", "Varmkorv", "Gyros", "Jordgubbe", "Salami" };
    Random random = new Random();
    Ord ord = new Ord(wordList[random.Next(1, wordList.Length - 1)]);
    return ord;
}

bool AskRestart()
{
    Console.WriteLine("Vill du köra igen? (y/n)");
    return Console.ReadLine() == "y";
}

do
{
    Console.Clear();
    HandleGame();
} while (AskRestart());