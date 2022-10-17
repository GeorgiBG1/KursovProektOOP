using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovProekt
{
    public class Hero
    {
        private double attackCoef = 15;
        private double defenceCoef = 20;
          

        public string Name { get; private set; }
        public Fraction Fraction { get; set; }
        public int Level { get; set; }
        public double Health { get; set; }
        public double Stamina { get; set; }
        public double Mana { get; set; }
        

        private List<Item> ItemSet { get; }

        public Hero(string Name, Fraction fraction)
        {
            this.Level = 0;
            this.Health = 100;
            this.Stamina = 100;
            this.Mana = 100;
            this.ItemSet = new List<Item>();
            this.Name = Name;
            this.Fraction = fraction;
        }

        public double LevelUp()
        {
            Level += 1;
            Health = 100;
            Stamina = 100;
            Mana = 100;
            return Level;
            
        }
        public double GetAttack()
        {
            double getAttack = this.ItemSet.Sum(i => i.Attack);
            getAttack += this.Level * this.attackCoef;
            return getAttack;
        }
        public double GetDeffence()
        {
            double getDefence = this.ItemSet.Sum(i => i.Defence);
            getDefence += this.Level * this.defenceCoef;
            return getDefence;
        }
        
        
    }
}
