class Program
{
    static void Main(string[] args)
    {   
        string word = "";
        Console.WriteLine("Hi enter number here ");
        int x = int.Parse(Console.ReadLine());

        if (x % 2 == 0)
        {
            word="even";
        }
        else
        {
            word="odd";
        }
    }
}
