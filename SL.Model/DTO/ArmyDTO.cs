using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DTO
{
    public class ArmyDTO<TKey>
    {
        public TKey Id { get; set; }
        public int AmountOfWarriors { get; set; }
        public int HPPerWarrior { get; set; }
        public int DemagePerWarrior { get; set; }
        public TKey GroundBattleId { get; set; }
        public TKey CountryId { get; set; }

    }
}
