using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DTO
{
    public class BattleFleet<TKey>
    {
        public TKey Id { get; set; }
        public int AmountOfWarriors { get; set; }
        public int HPPerShip { get; set; }
        public int DemagePerShip { get; set; }
        public TKey AirBattleId { get; set; }
        public TKey CountryId { get; set; }
    }
}
