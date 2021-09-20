using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel
{
    public class Country<TKey>
    {
        public TKey Id { get; set; }
        public string Name { get; set; }
        public bool IsPlayer { get; set; }
        public IDictionary<Country<TKey>, DiplomaticRelation<TKey>> RelationWithCountries { get; private set; }
    }
}
