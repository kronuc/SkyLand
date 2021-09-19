using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.DT
{
    public class IslandDTO<TKey>
    {
        public TKey Id { get; set; }
        public int Sise { get; set; }
        public string Name { get; set; }
        public float Population { get; set; }
        public float ProductionPerDay { get; set; }
    }
}
