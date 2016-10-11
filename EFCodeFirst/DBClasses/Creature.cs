using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses
{
    public class Creature
    {
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
