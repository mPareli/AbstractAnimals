namespace AbstractAnimals;

public class Cat : Animals
{
    public Cat()
    {
        info = "This is a cat.";
    }

    public override void makeNoise()
    {
        Console.WriteLine("Meow");
    }
}





/*
{
    private String info = "This is a cat.";

    public Cat()
    {
        //nothing here
    }
    
    public void makeNoise()
    {
        Console.WriteLine("Meow"); 
    }

    public void getInfo()
    {
        Console.WriteLine(info);
    }
}
*/