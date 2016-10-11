using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public int PowerBonus { get; set; }
        public int ToughnessBonus { get; set; }
        public int CreatureId { get; set; }
        public virtual Creature Creature{ get; set; }
    }
}
