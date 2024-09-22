/*
Why Use Different using Directives?

Each namespace contains a set of related classes and methods that provide specific functionality. By including different namespaces with using, you gain access to a broad range of features without having to write the full path to each class.

For example:

- System - is for basic features like Console.
- System.Collections.Generic - is for data structures like List.
- System.IO -  is for file handling.


1. using System.Collections.Generic;

- This namespace provides classes for working with collections  like List<T>, Dictionary<TKey, TValue>, and Queue<T>.

Example:
   
   using System.Collections.Generic;

   List<int> numbers = new List<int>();
   numbers.Add(10);

________________________________________________________________

2. using System.Linq;

- Provides LINQ (Language-Integrated Query) functionality, allowing you to perform queries on collections in a declarative way.

Example:

    using System.Linq;

    int[] numbers = { 1, 2, 3, 4 };
    var evenNumbers = numbers.Where(n => n % 2 == 0);

________________________________________________________________

3. using System.Text;

- Contains classes for handling text encoding and manipulation, such as StringBuilder.

Example: 

    using System.Text;

    StringBuilder sb = new StringBuilder();
    sb.Append("Hello");

________________________________________________________________

4. using System.IO;

- Includes classes for working with input and output, such as reading and writing files (File, Stream, StreamReader, etc.).

Example:

    using System.IO;

    File.WriteAllText("example.txt", "Hello, world!");

________________________________________________________________

5. using System.Threading.Tasks;

- Allows you to work with asynchronous programming and tasks using Task and async/await.

Example:

    using System.Threading.Tasks;

    async Task DoWork()
    {
        await Task.Delay(1000);
        Console.WriteLine("Work done after 1 second!");
    }

________________________________________________________________

6. using System.Net.Http;

- Provides classes for HTTP communication (for example, making web requests using HttpClient).

Example:

    using System.Net.Http;

    HttpClient client = new HttpClient();
    string result = await client.GetStringAsync("http://example.com");

________________________________________________________________


Custom Namespaces

You can also define your own namespaces in larger projects to keep your code organized. For example:

namespace MyApp.Utilities
{
    public class Helper
    {
        public static void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }
}

Then, in another file, you can include it with using MyApp.Utilities; to use Helper.DoSomething();

*/



