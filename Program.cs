namespace C_;

class Program
{
    static void Main(string[] args)
    {
        string helloWorld = "hello , world";
        
        int myNumber = 10;

        double myDecimal = 10.25;
        
        Console.WriteLine(helloWorld);
        Console.WriteLine(myNumber);
        Console.WriteLine(myDecimal);
        // skriver ut en melding
        Console.WriteLine("Hei, hva heter du?");
        //string variabel, nav holder på verdien vi gir.
        string? navn = Console.ReadLine();
        Console.WriteLine("Hei"  + navn);

        //char typen, tar en bestemt bokstav
        char a = '@';
        
        Console.WriteLine(a);

        
    

    }
}
