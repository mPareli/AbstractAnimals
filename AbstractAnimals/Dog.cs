namespace AbstractAnimals;

public class Dog: Animals
{
    public Dog()
    {
        info = "This is a dog.";
    }

    public override void makeNoise()
    {
        Console.WriteLine("I love One Piece");
    }
}