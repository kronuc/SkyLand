using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DT
{
    public class AirStreamDTO<TKey>
    {
        public TKey Id { get; set; }
        public TKey StartIslandId { get; set; }
        public TKey EndIslandId { get; set; }
        public int Speed { get; set; }

    }
}
