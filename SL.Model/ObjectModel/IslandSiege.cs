using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel
{
    public class IslandSiege<TKey>
    {
        public TKey Id { get; set; }
        public Island<TKey> Island { get; set; }
    }
}
