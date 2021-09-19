using SL.Model.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.Services.Abstractions
{
    public interface IFleetService<TKey>
    {
        FleetDTO<TKey> GetFleetData(TKey id);
        void MoveFleet(TKey battleFleetId, TKey targetIslandId);
        void DeleteFleet(TKey battleFleetId);
        void AddShipToFleet(TKey fleetId, int shipsAmount);
        void SeparateFleet(TKey fleetId, int shipsInNewFleet);
        void SettleOnIsland(TKey fleetId, int amount);
        void SettleOnIsland(TKey fleetId);
        void BuildNewFlee(TKey islandId, int amountOfShips);
        FleetDTO<TKey> GetFleetsNearIsland(TKey islandId);
        FleetDTO<TKey> GetFleetOnAirStreem(TKey airStreemId);
    }
}
