namespace AbstractAnimals;

public class Parrot: Animals
{
    public Parrot()
    {
        info = "This is a parrot.";
    }

    public override void makeNoise()
    {
        Console.WriteLine("SQUAK!!!");
    }
}