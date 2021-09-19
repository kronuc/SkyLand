using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DT
{
    public class AirBattleDTO<TKey>
    {
        public TKey Id { get; set; }
        public TKey IslandId { get; set; }
        public int DateOfStart { get; set; }
    }
}
