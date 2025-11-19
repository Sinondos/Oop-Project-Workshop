class Program
{     static void Main()
    {
        bool menuActive = true;
        while (menuActive)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Option 1);
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You selected Option 1.");
                    break;
                case "2":
                    Console.WriteLine("You selected Option 2.");
                    break;
                case "3":
                    menuActive = false;
                    Console.WriteLine("Exiting the menu.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            if (menuActive)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
    
}