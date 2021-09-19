using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DT
{
    public class IslandSiegeDT<TKey>
    {
        public TKey Id { get; set; }
        public TKey IslandId { get; set; }
    }
}
