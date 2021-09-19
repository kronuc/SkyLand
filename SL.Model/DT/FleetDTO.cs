using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DT
{
    public class FleetDTO<TKey>
    {
        public TKey Id { get; set; }
        public int AmountOfShips { get; set; }
        public int HPPerShip { get; set; }
        public int DemagePerShip { get; set; }
        public TKey AirBattleId { get; set; }
        public TKey CountryId { get; set; }
    }
}
