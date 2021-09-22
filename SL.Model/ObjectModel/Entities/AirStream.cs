using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.Entities
{
    public class AirStream<TKey>
    {
        public TKey Id { get; set; }
        public Island<TKey> StartIslandId { get; set; }
        public Island<TKey> EndIslandId { get; set; }
        public int Speed { get; set; }
    }
}
