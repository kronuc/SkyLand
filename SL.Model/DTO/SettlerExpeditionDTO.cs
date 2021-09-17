using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DTO
{
    public class SettlerMissionDTO<TKey>
    {
        public TKey Id { get; set; }
        public float Cost { get; set; }
        public int SettlersAmount { get; set; }
        public bool IsOnGround { get; set; }
        public int RequiredNumberOfShips { get; set; }
        public TKey LinkedTransportFleetId { get; set; }        
    }
}
