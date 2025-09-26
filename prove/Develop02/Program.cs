using System;

class Program
{
    static void Main(string[] args)
    {
        string filename = "prompts.txt";
        Journal journal = new Journal();
        Menu menu = new Menu();
        String[] prompts = System.IO.File.ReadAllLines(filename);

        menu.displayMenu();
        
    }
}