namespace ChocolateRoulette
{
    public class Chocolate
    {
        public virtual void Taste()
        {
            Console.WriteLine("This chocolate tastes nice!");
        }
    }
    public class ChilliChocolate : Chocolate
    {
        public override void Taste()
        {
            Console.WriteLine("Ouch, that was spicy... must be the chilli.");
        }
    }

}