namespace AbstractAnimals;

public class Mouse : Animals
{
    public Mouse()
    {
        info = "This is a mouse.";
    }

    public override void makeNoise()
    {
        Console.WriteLine("Squeak");
    }
}





/*
{
    public String info = "This is a mouse.";

    public Mouse()
    {
        //nothing here
    }
    
    public void makeNoise()
    {
        Console.WriteLine("Squeak"); 
    }

    public void getInfo()
    {
        Console.WriteLine(info);
    }
}
*/