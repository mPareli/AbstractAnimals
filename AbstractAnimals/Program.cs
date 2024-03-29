﻿namespace AbstractAnimals;

class Program
{
    static void Main(string[] args)
    {
        List<Animals> myHouse = new List<Animals>();
        myHouse.Add(new Cat());
        myHouse.Add(new Mouse());
        myHouse.Add(new Parrot());
        myHouse.Add(new Rat());
        myHouse.Add(new Dog());

        foreach (Animals animals in myHouse)
        {
            animals.getInfo();
            animals.makeNoise();
        }
    }
}