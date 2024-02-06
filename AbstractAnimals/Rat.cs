namespace AbstractAnimals;

public class Rat: Animals
{
    public Rat()
    {
        info = "This is a rat.";
    }

    public override void makeNoise()
    {
        Console.WriteLine("I HECKIN LOVE LINUX BAAAAAAAT");
    }
}