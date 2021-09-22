using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.Entities
{
    public class Island<TKey>
    {
        public TKey Id { get; set; }
        public int Sise { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public float ProductionPerDay { get; set; }
        public Point<TKey> Location { get; set; }
        public IslandProduction<TKey> IslandProduction { get; set; }
        public Country<TKey> Owner { get; set; }
        public IslandSiege<TKey> IslandSiege { get; set; }
        private int _populationGrows;

        public void Update()
        {
            if (Owner != null && IslandSiege == null)
                _populationGrows += 1;
            if (_populationGrows >= 100)
                Population += 1;
            IslandProduction.Update();
        }
    }
}
