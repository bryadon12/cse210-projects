using System.IO; 
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        Menu menu = new Menu(journal);
        menu.openMenu();
    }
}
