namespace dag2;

class Program
{
    static void Main(string[] args)
    {
        string morning = "Good morning all!";
        Console.WriteLine(morning);

        int myNumber = 10;
        Console.WriteLine(myNumber);

        double myDecimal = 10.25;
        Console.WriteLine(myDecimal);
        //Char
        char ch = 'a';
        Console.WriteLine(ch);
        // Strings
        string[]myStringArray = {"1,2,3,4,5"};
        for(int i = 0; i < myStringArray.Length; i = i + 1)
        Console.WriteLine(myStringArray);

        string[]mySecondArray = {"rødbeter, hodekål, banan"};
        foreach(string i in mySecondArray)
        Console.WriteLine(mySecondArray);

        // Liste

          List<int> myNumbers = new List<int>();
         myNumbers.Add(1);
         myNumbers.Add(2);
         myNumbers.Add(3);
         myNumbers.Add(4);
         for(int i = 0; i < myNumbers.Count(); i++) 
         {
             Console.WriteLine(myNumbers[i]);
         }

        // prøve.
        Console.WriteLine("God Morgen! hva heter du?");
        string? navn = Console.ReadLine();

        Console.WriteLine("God Morgen " + navn);


  
       
    }
}
