using SL.Model.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.Services.Abstractions
{
    public interface IAirBattleService<TKey>
    {
        AirBattleDTO<TKey> GetAirBattleData(TKey airBattleId);
        void EscapeFromeBattle(TKey fleetId);
        IEnumerable<FleetDTO<TKey>> GetBattleParticipant(TKey AirBattleId);
    } 
}
