using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        List<Word> scriptureWords = new List<Word>();
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            scriptureWords.Add(new Word(word));
        }
        Scripture scripture = new Scripture(reference, scriptureWords);



        Console.WriteLine("Hello! Press enter to start memorizing a scripter verse. Type \"exit\" to quit");

    }
}