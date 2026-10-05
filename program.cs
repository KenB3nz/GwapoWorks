class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("This is my branch");
        Console.WriteLine("Contributed by Catacutan");
        Console.Write("What is your favourite restaurant (Jollibee,Mcdonalds,Chowking,Wendys");
        string restaurant = Console.ReadLine();
        switch (restaurant) 
        {
            case "Jollibee":
                Console.WriteLine(" Welcome to Jollibee!");
                break;
            case "Mcdonalds":
                Console.WriteLine("Welcome to Mcdonalds!");
                break;
            case "Chowking":
                Console.WriteLine("Welcome to Chowking!");
                break;
            case "Wendys":
                Console.WriteLine("Welcome to Wendys!");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;

        }

     

    }
}