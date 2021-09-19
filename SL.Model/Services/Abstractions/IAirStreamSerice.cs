using SL.Model.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.Services.Abstractions
{
    public interface IAirStreamSerice<TKey>
    {
        AirStreamDTO<TKey> GetAirStreamData(TKey id);
        IEnumerable<AirStreamDTO<TKey>> GetAirStreamsStartedFromIsland(TKey IslandId); 
    }
}
