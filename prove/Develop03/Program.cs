using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        bool _continueProgram = true;

        while (_continueProgram)
        {
            Reference _reference = new Reference("2 Nephi", 31, 19, 20);
            Scripture _scripture = new Scripture(_reference, "And now, my beloved brethren, after ye have gotten into this strait "+
            "and narrow path, I would ask if all is done? Behold, I say unto you, Nay; for ye have not come thus far save it were by the "+
            "word of Christ with unshaken faith in him, relying wholly upon the merits of him who is mighty to save. "+
            "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God "+
            "and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus "+
            "saith the Father: Ye shall have eternal life.");

            Console.Clear();
            Console.WriteLine(_reference.GetReferenceText());
            Console.WriteLine();
            Console.WriteLine(_scripture.GetRenderedText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string _choice = Console.ReadLine();

            if (_choice.ToLower() == "quit")
            {
                _continueProgram = false;
            }
            else
            {
                while (_scripture.HasWordsToHide())
                {
                    _scripture.HideRandomWords();
                    Console.Clear();
                    Console.WriteLine(_reference.GetReferenceText());
                    Console.WriteLine();
                    Console.WriteLine(_scripture.GetRenderedText());

                    if (!_scripture.HasWordsToHide())
                    {
                        Console.WriteLine();
                        Console.WriteLine("No more words to hide.");
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
                    _choice = Console.ReadLine();

                    if (_choice.ToLower() == "quit")
                    {
                        _continueProgram = false;
                        break;
                    }
                }

                if (!_scripture.HasWordsToHide())
                {
                    Console.WriteLine("Great job!");
                    _continueProgram = false;
                }
            }
        }

        Console.WriteLine("Thanks for playing. Come back.");
        Console.WriteLine();
    }
}