namespace HotBeverages
{
    internal class Program
    {
        static void Main(string[] args)
        {
          


            DrinkOfChoice Person1 = new DrinkOfChoice("coffee", 2, false);
            Console.WriteLine("Iced " + Person1.GetBeverageType());
            Console.WriteLine("How many sugars: " + Person1.GetSugar());
            if (Person1.GetMilkOrNoMilk())
            {
                Console.WriteLine("This drink has milk in");
            }
            else
            {
                Console.WriteLine("This drink has no milk in");
            }

            DrinkOfChoice Person2 = new DrinkOfChoice("tea", 4, true);
            Console.WriteLine(Person2.GetBeverageType() + " " + "is hot");
            Console.WriteLine("How many sugars: " + Person2.GetSugar());
            if(Person2.GetMilkOrNoMilk())
            {
                Console.WriteLine("This drink has  milk in");
            }
            else 
            {
                Console.WriteLine("This drink has no milk in ");
            }
    }
    }
}
