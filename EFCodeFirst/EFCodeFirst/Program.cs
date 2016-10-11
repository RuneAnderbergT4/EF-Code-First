using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBClasses;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdventureContext db = new AdventureContext())
            {
                Equipment swordOfGlory = new Equipment
                {
                    Name = "Sword of Glory",
                    PowerBonus = 3,
                    ToughnessBonus = 2
                };

                Creature kingArthur = new Creature
                {
                    Name = "King Arthur",
                    Power = 5,
                    Toughness = 8,
                    Equipment = new List<Equipment>()
                };
                kingArthur.Equipment.Add(swordOfGlory);

                db.Creatures.Add(kingArthur);
                db.SaveChanges();
            }
        }
    }
}
