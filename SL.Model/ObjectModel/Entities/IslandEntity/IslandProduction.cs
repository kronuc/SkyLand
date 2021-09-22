using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.Entities
{
    public class IslandProduction<Tkey>
    {
        public int IslandPopulation { get; set; }
        public Queue<ProductionTask<Tkey>> Tasks { get; set; } 
        public void Update()
        {
            Tasks.Peek()?.PutProduction(IslandPopulation);
        }
    }
}
