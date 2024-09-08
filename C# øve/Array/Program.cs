namespace Array;

class Program
{
    static void Main(string[] args)
    {
        string[] myArray = new string[7];
        myArray[0] = "Monday";
        myArray[1] = "Tuesday";
        myArray[2] = "Wednesday";
        myArray[3] = "Thursday";
        myArray[4] = "Friday";
        myArray[5] = "Saturday";
        myArray[6] = "Sunday";

        for (int i = 0; i < myArray.Length; i++) 
        {
            Console.WriteLine(myArray[i]);
        }
        //List<int> List = new List<int>();   
        List<string> List = new List<string>();
        List.Add("Monday");   
        List.Add("Tuesday");   
        List.Add("Wednesday");   
        List.Add("Thurday");   
        List.Add("Friday");   
        List.Add("Saturday");   
        List.Add("Sunday");   

        for (int i = 0; i < List.Count; i++) 
        {
            List[i] = List[i].Substring(0, 3); // Shows the 3 first letters only
            Console.WriteLine(List[i]);
        }

        //Dictionary<Key, value > dictionary = new Dictionary<string, int>();
        //Dictionary<string, int > dictionary = new Dictionary<string, int>();

        Dictionary<int, string > dictionary = new Dictionary<int, string>();
        dictionary[0] = "Monday";
        dictionary[1] = "Tuesday";
        dictionary[2] = "Wednesday";
        dictionary[3] = "Thursday";
        dictionary[4] = "Friday";
        dictionary[5] = "Saturday";
        dictionary[6] = "Sunday";

        for (int i = 0; i < dictionary.Count; i++) 
        {
            dictionary[i] = dictionary[i].Substring(0, 3); // Shows the 3 first letters only
            Console.WriteLine(dictionary[i]);
        }

    }
}
