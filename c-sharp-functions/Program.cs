internal class Program
{
    
    private static void Main(string[] args)
    {
        int fact, num;
        bioData("omran", "aljabri", 27);

        
        Console.Write("Enter a number: ");

        
        num = Convert.ToInt32(Console.ReadLine());

         Program obj = new Program();

       
       fact=obj.factorial(num);

        Console.WriteLine("Factorial of "+ num +" is "+ fact);

        //switch
        int day;

        Console.WriteLine("enter number of a day: ");
        day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("monday");
                break;
            case 3:
                Console.WriteLine("tuesday");
                break;
            case 4:
                Console.WriteLine("wednesday");
                break;
            case 5:
                Console.WriteLine("thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("saturday");
                break;
        }
    }
    //<modifiers> <return-type> <method-name> <parameter-list>
    // types of modifiers:
    //async
    //unsafe
    //static A static local function can't capture local variables or instance state.
    //extern An external local function must be static.
    static void bioData(string name, string lastname, int age)
    {
        Console.WriteLine("name is" + name);
        Console.WriteLine("last name is " + lastname);
        Console.WriteLine("age is " + age);

    }


    // recursive function 
    public int factorial(int num)
    {
        // termination condition
        if (num == 0)
            return 1;
        else
            // recursive call
            return num * factorial(num - 1);



    }
}