using System;
using KursovProekt;
namespace KursovProekt
{
    class KursovaStart
    {
        static void Main(string[] args)
        {
            Item weapon1 = new Item("sword", 674, 0);            
            Item weapon2 = new Item("bow", 608, 0);
            Item weapon3 = new Item("spear", 608, 20);
            Item weapon4 = new Item("claymore", 542, 24);
            Item weapon5 = new Item("magicbook", 304, 40);
            Item armor1 = new Item("helmet", 6, 105);
            Item armor2 = new Item("chestplate", 15, 200);
            Item armor3 = new Item("leggings", 20 ,180);
            Item armor4 = new Item("boots",9, 30);

            Hero Marin = new ("Xiao", Fraction.Knight);
            Marin.LevelUp();
            Marin.LevelUp();
            Marin.LevelUp();
            Marin.LevelUp();

            Marin.ItemSet.Add(weapon3);
            Marin.ItemSet.Add(armor1);
            Marin.ItemSet.Add(armor2);
            Marin.ItemSet.Add(armor3);
            Marin.ItemSet.Add(armor4);
            Hero Emir = new ("Ganyu", Fraction.Rogue);
            Emir.Fraction = Fraction.Ranged; //Тестване
            Emir.LevelUp();
            Emir.LevelUp();

            Emir.ItemSet.Add(weapon2);
            Emir.ItemSet.Add(armor1);
            Emir.ItemSet.Add(armor2);
            Emir.ItemSet.Add(armor3);
            Emir.ItemSet.Add(armor4);

            Console.WriteLine();
            Console.WriteLine("Weapon1:\nAttack: " + weapon1.Attack + "\nDefence: " + weapon1.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon2:\nAttack: " + weapon2.Attack + "\nDefence: " + weapon2.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon3:\nAttack: " + weapon3.Attack + "\nDefence: " + weapon3.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon4:\nAttack: " + weapon4.Attack + "\nDefence: " + weapon4.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon5:\nAttack: " + weapon5.Attack + "\nDefence: " + weapon5.Defence);
            Console.WriteLine();
            Console.WriteLine($"\tPlayer1\nLevel: {Marin.Level},\nHero name: {Marin.Name},\nHealth: {Marin.Health},\nMana: {Marin.Mana},\nStamina: {Marin.Stamina},\nFraction: {Marin.Fraction},\nDamage: {Marin.GetAttack()},\nDefence: {Marin.GetDeffence()}");
            Console.WriteLine();
            Console.WriteLine($"\tPlayer2\nLevel: {Emir.Level},\nHero name: {Emir.Name},\nHealth: {Emir.Health},\nMana: {Emir.Mana},\nStamina: {Emir.Stamina},\nFraction: {Emir.Fraction},\nDamage: {Emir.GetAttack()},\nDefence: {Emir.GetDeffence()}");

        }
    }
}
