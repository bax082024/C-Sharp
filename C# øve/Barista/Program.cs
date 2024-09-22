namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, Welcome to Mr. Blues bakery");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you: " + name);

            Console.WriteLine("Would you like to order from our menu?");
            Console.WriteLine("Type yes or no");
            string order = Console.ReadLine();

            
            if (order.ToLower() == "yes")
            {
                
                Menu menu = new Menu();
                List<string> menuItems = menu.GetMenuItems();


                Console.WriteLine("Menu:");
                foreach (var item in menuItems)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Thank you for visiting!");
                
            }

            Console.WriteLine("What would you like to order? (type the number)");
            string finalOrder = Console.ReadLine();

            switch (operation1)
            {
                case '1':
                Console.WriteLine("Result:");
                break;

                case '2':
                Console.WriteLine("Result:");
                break;

                case '3':
                Console.WriteLine("Result:");
                break;

                case '4':
                Console.WriteLine("Result:");
                break;

                case '5':
                Console.WriteLine("Result:");
                break;
                
            }
            
            

        
           

        }
    }
}

