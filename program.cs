class Program
{
   
    static void Main(string[] args)
    {

        Console.WriteLine(Ask());
    }

    static string Ask()
    {
        string result = "";

        Console.WriteLine("Please enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        string choice = Console.ReadLine();
   

        switch (choice)
        {
            case "1":
            {
                result= Add(a,b). ToString();

            }
                break;
            case "2":
            {
               result = Subtract(a, b).ToString();
            }
                break;
            case "3":
            {
               result= Multiply(a,b). ToString();
            }
                break;
            case "4":
            { 
               result= Divide(a, b).ToString();
            }
                break;
            default:
                break;
            
        }

        return result;

    }


    static int  Add(int a, int b)
    {
        int result = 0;
        result = a + b;
        return result;
        
    }

    static int Subtract(int a, int b)
    {
        int result = 0;
        result = a - b;
        return result;
    }

    static int Multiply(int a, int b)
    {
        int result = 0;
        result = a * b;
        return result;
    }
    
    static int Divide (int a, int b)
    {
          int result = 0;
          result = a / b;
          return result;
    }
}
