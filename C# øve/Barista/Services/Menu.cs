namespace Barista
{
    public class Menu
    {
        public List<string> GetMenuItems()
        {
            // Initialize and return the menu list
            List<string> menu = new List<string>
            {
                "1. Svart kaffe : 2 bitcoin",
                "2. Milkshake : 3 bitcoin",
                "3. Is : 10 bitcoin",
                "4. Skillingsbolle : 1 bitcoin",
                "5. Chips : 1 bitcoin"
            };
            return menu;
        }

        public class Price 
        {
            int svartKaffe = 2;
            int Milkshake = 3;
            int Is = 10;
            int Skillingsbolle = 1;
            int Chips = 1;


        }

    }

  

        
    

    
    
}






