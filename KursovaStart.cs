using System;
using KursovProekt;
namespace KursovProekt
{
    class KursovaStart
    {
        static void Main(string[] args)
        {
            Hero Marin = new Hero("Xiao", Fraction.Knight);
            Hero Emir = new Hero("Ganyu", Fraction.Ranged);
            Marin.LevelUp();
            Marin.LevelUp();
            Marin.LevelUp();
            Marin.LevelUp();
            Marin.LevelUp();
            Emir.LevelUp();
            Emir.Fraction = Fraction.Rogue;
            Item sword = new Item("sword", 0, 0);
            Console.WriteLine("New");
            Console.WriteLine( Marin.GetAttack());
            Console.WriteLine( Emir.GetAttack());
            Console.WriteLine( Marin.GetDeffence());
            Console.WriteLine( Emir.GetDeffence());
            Console.WriteLine("Attack: " + sword.Attack + " Type: "+ sword.Name + " Defence: " + sword.Defence);
            Console.WriteLine($"Info: Level: {Marin.Level}, Name: {Marin.Name}, Health: {Marin.Health}, Mana: {Marin.Mana}, Stamina: {Marin.Stamina}, Fraction: {Marin.Fraction}");
            Console.WriteLine($"Info: Level: {Emir.Level}, Name: {Emir.Name}, Health: {Emir.Health}, Mana: {Emir.Mana}, Stamina: {Emir.Stamina}, Fraction: {Emir.Fraction}");

        }
    }
}
