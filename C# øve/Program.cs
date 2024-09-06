namespace C__øve;

class Program
{
    static void Main(string[] args)
    {

      /*  for (int i = 1; i <= 10; i+= 2)
        {
            Console.WriteLine(i);
        }
      */
        Human Human1 = new Human();
        Human Human2 = new Human();

        Human1.name = "Rick ";
        Human1.age = 65;

        Human2.name = "Leonard ";
        Human2.age = 28;

        Human1.Eat();
        Human1.Sleep();

        Human2.Eat();
        Human2.Sleep();

        Console.ReadKey();
    }
}

 class Human
{
    public String name;
    public int age;

    public void Eat() 
    {
        Console.WriteLine(name + "Is Eating");
    }

    public void Sleep() 
    {
        Console.WriteLine(name + "Is Sleeping");

    }








}
