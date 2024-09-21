﻿
Console.WriteLine("Welcome to Tamagotchi!");

Tamagotchi myTama = new Tamagotchi();

Console.WriteLine("Please choose a name for your Tamagotchi!");
myTama.Name = Console.ReadLine();

Console.WriteLine(myTama.Name + " is a good name!");

while (myTama.GetAlive() == true)
{
  Console.Clear();
  myTama.PrintStats();
  Console.WriteLine();
  Console.WriteLine("Now what do you want to do?");
  Console.WriteLine($"1. Teach {myTama.Name} a new word");
  Console.WriteLine($"2. Talk to {myTama.Name}");
  Console.WriteLine($"3. Feed {myTama.Name}");
  Console.WriteLine($"4. Do nothing");

  string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    myTama.Teach(word);
  }
  if (doWhat == "2")
  {
    myTama.Hi();
  }
  if (doWhat == "3")
  {
    myTama.Feed();
  }
  else
  {
    Console.WriteLine("Doing nothing...");
  }
  myTama.Tick();
  Console.WriteLine("Press enter to continue");
  Console.ReadLine();
}

Console.WriteLine("No! " + myTama.Name + " is dead!");
Console.WriteLine("Press enter to leave");
Console.ReadLine();