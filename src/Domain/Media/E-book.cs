class EBook : IReadable
{
    string ISBN;
    int numberOfPages;
    string language;
    string author;

    void Read()
    {
        Console.WriteLine("You are reading the E-book");
    }
}