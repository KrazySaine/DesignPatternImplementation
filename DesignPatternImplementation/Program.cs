//using https://dotnettutorials.net/lesson/prototype-design-pattern/ as reference.
//I saw this pattern as the one to be used when creating new players in a game, if all starting stats
//would be the same, you could enter your name and class and be off on your adventure.  That is what I 
//saw would be a good example of what this pattern good be used for.  The example given showed creating employees
//and grouping them by department, and that is what led me to think of player creation for a game.

//Design pattern used is the Prototype Design Pattern.
//This pattern is Creational

using System;
namespace DesignPatternImplementation;


class Program
{
    static void Main(string[] args)
    {
        
        Player plr1 = new Player();
        plr1.Name = "Kai Zenku";
        plr1.Class = "Monk";
        
        Player plr2 = plr1;
        
        plr2.Name = "Ota Senku";
        Console.WriteLine("Player 1: ");
        Console.WriteLine("Name: " + plr1.Name + ", Class: " + plr1.Class);
        Console.WriteLine("Player 2: ");
        Console.WriteLine("Name: " + plr2.Name + ", Class: " + plr2.Class);
        Console.Read();
    }
}
public class Player
{
    public string Name { get; set; }
    public string Class { get; set; }
}
