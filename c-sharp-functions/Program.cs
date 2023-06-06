internal class Program
{
    private static void Main(string[] args)
    {
        bioData("omran", "aljabri", 27);
    }

    static void bioData(string name,string lastname,int age )
    {
        Console.WriteLine("name is" + name);
        Console.WriteLine("last name is "+  lastname);
        Console.WriteLine("age is " + age);

    }
}