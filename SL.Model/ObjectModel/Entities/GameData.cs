using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.Entities
{
    public class GameData<TKey>
    {
        public TKey Id { get; set; }
        public IEnumerable<Island<TKey>> Islands { get; set; }
        public IEnumerable<Fleet<TKey>> Fleets { get; set; }
        public IEnumerable<Country<TKey>> Countries { get; set; }
        public IEnumerable<DiplomaticRelation<TKey>> DiplomaticRelations { get; set; }
        public IEnumerable<AirStream<TKey>> AirStreams { get; set; }
        public IEnumerable<AirBattle<TKey>> AirBattles { get; set; }
        public IEnumerable<IslandSiege<TKey>> IslandSieges { get; set; }
    }
}
