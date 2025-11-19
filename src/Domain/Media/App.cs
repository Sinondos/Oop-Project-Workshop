using Oop-Project-Workshop.src.Domain.Interfaces;

class App : IExecuteable
{
    string publisher;
    string version;
    string[] supportedPlatforms;
    string fileSize;

    void Execute()
    {
        Console.WriteLine("App has been executed and is now playing");
    }
}