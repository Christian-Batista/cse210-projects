using System;

class Program
{
        /// <summary>
        /// Entry point for the Scripture Memorizer program.
        /// 
        /// This program will display a scripture and randomly hide a word.
        /// The user is prompted to press enter to continue or type 'quit' to finish.
        /// 
        /// Exceeding Requirements:
        /// The program will keep track of the user's progress and let them know
        /// 
        /// when they have memorized the scripture.
        /// </summary>
    static void Main(string[] args)
    {   
        Reference reference = new Reference("1 Nephi", 3, 1, 3);
        string scriptureText = "1 And it came to pass that I, Nephi, returned from speaking with the Lord, to the tent of my father. 2 And it came to pass that he spake unto me, saying: Behold I have dreamed a dream, in the which the Lord hath commanded me that thou and thy brethren shall return to Jerusalem. 3 For behold, Laban hath the record of the Jews and also a genealogy of my forefathers, and they are engraven upon plates of brass.";
        // string scriptureText = "1 Nephi 3:1-3";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        { 
            // clear the console
            Console.Clear();
            // display the scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n" + scripture.GetProgressText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            // get user input
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                // hide a random word
                scripture.HideRandomWord();

                // check if the scripture is completely hidden
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nYou have memorized the scripture!.");
                    break;
                }
            }
        }

    }
    
}