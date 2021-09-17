using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DTO
{
    public class TransportFleetDTO<TKey>
    {
        public TKey Id { get; set; }
        public int AmountOfShips { get; set; }
        public TKey HostIslandId { get; set; }
        public TKey LinkedAirStreamId { get; set; }
    }
}
