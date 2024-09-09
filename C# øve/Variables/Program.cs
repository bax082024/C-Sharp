namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        /*type casting = Converting a value to a different data type. Useful when we accept user input (string).
        Different data types can do different things.
        */
        
        /*
        double a = 3.14;
        int b = Convert.ToInt32(a);

        int c = 123;
        double d = Convert.ToDouble(c) + 0.01;

        int e = 321;
        String f = Convert.ToString(e);

        String g = "$";
        char h = Convert.ToChar(g);

        String i = "true";
        bool j = Convert.ToBoolean(i);

        Console.WriteLine(b.GetType());
        Console.WriteLine(d.GetType());
        Console.WriteLine(f.GetType());
        Console.WriteLine(h.GetType());
        Console.WriteLine(j.GetType());
        */
        Console.WriteLine("What is your name?");
        String name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Hello " + name);
        Console.ReadLine("You are " + age + " years old");
    }
}
