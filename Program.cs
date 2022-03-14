using Observer;

namespace PatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Observer
            //
            Central chief = new Central();
            Outpost zoloo = new Outpost("Zoloo");
            Outpost bravo = new Outpost("Bravo");

            chief.Subscribe(zoloo);
            chief.Subscribe(bravo);
            chief.MyValue = 2;
            chief.MyValue = 5;

            
        }
    }
}