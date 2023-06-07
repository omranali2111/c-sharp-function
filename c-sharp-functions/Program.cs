internal class Program
{
    private static void Main(string[] args)
    {
        bioData("omran", "aljabri", 27);

        //switch
        int day;

        Console.WriteLine("enter number of a day: ");
         day= int.Parse(Console.ReadLine());
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
    static void bioData(string name,string lastname,int age )
    {
        Console.WriteLine("name is" + name);
        Console.WriteLine("last name is "+  lastname);
        Console.WriteLine("age is " + age);

    }

  

                 


}