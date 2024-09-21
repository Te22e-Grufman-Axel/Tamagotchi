
using System;
using System.Collections.Generic;

public class Tamagotchi
{
    public string Name;
    private bool IsAlive;
    private int Hunger;
    private int Boredom;
    private List<string> words = new List<string>() { "Hellu" };



    public Tamagotchi()
    {
        IsAlive = true;
    }

    public void Feed()
    {
        Console.WriteLine(Name + " eats and becomes less hungry");
        Hunger -= 3;
        if (Hunger < 0)
        {
            Hunger = 0;
        }
    }

    public void Hi()
    {
        int wordNum = Random.Shared.Next(words.Count);
        Console.WriteLine(Name + " says: " + words[wordNum]);
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine(Name + " learns: " + word);
        words.Add(word);
        Boredom++;
    }

    public void Tick()
    {
        Hunger++;
        Boredom++;
        if (Hunger > 15 || Boredom > 15)
        {
            IsAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine("My name is: " + Name);
        Console.WriteLine("My hunger is: " + Hunger);
        Console.WriteLine("My bordome is: " + Boredom);
        Console.WriteLine("I can: " + words.Count + " Words");
    }

    public bool GetAlive()
    {
        return IsAlive;
    }

    public void ReduceBoredom()
    {
        Console.WriteLine(Name + " is now less bored!");

        Boredom -= 2;
        if (Boredom < 0)
        {
            Boredom = 0;
        }
    }
}
