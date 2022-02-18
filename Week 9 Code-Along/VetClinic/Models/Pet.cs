namespace VetClinic.Models;

public class Pet
{
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public void Eat()
        {
            Console.WriteLine("Om Nom");
        }
}