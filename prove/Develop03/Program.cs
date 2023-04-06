class Program
{
    static void Main(string[] args)
    {
        // Create a scripture library
        ScriptureLibrary library = new ScriptureLibrary();

        // Get a random scripture from the library
        Scripture scripture = library.GetRandomScripture();

        // Display the scripture
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");

        // Hide words until the scripture is completely hidden
        while (!scripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideWords();
            Console.WriteLine(scripture.GetRenderedText());
        }
    }
}