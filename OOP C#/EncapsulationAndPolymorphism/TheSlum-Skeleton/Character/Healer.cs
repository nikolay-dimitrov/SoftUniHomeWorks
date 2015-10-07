using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;


namespace TheSlum.Characters
{
    class Healer : Character, IHeal
    {
        public Healer(string id,int x,int y,int healthPoint,int defensePoint,int healingPoints,Team team,int range)
            : base(id, x, y, healthPoint, defensePoint, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets =
                from target in targetsList
                where target.IsAlive && target.Team == this.Team && target != this
                orderby target.HealthPoints
                select target;
                
            return targets.FirstOrDefault();
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }
    }
}
