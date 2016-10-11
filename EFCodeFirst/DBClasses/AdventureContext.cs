using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses
{
    public class AdventureContext : DbContext
    {   
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
    }
}
