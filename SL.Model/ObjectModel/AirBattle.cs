using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel
{
    public class AirBattle<TKey> 
    {
        public TKey Id { get; set; }
        public TKey IslandId { get; set; }
        public int DateOfStart { get; set; }
        public IDictionary<Country<TKey>, Fleet<TKey>> CountriesFleets { get; private set; }
        public void AddFleet(Fleet<TKey> fleet)
        {
            if (CountriesFleets.Keys.Contains(fleet.Country))
            {
                CountriesFleets[fleet.Country].AddFleet(fleet);
            }
            else
            {
                CountriesFleets[fleet.Country] = fleet;
            }
        }

        public void Update()
        {
            IDictionary<Country<TKey>, float> damagePerCountry = new Dictionary<Country<TKey>, float>();
            foreach (Country<TKey> country in CountriesFleets.Keys)
            {
                int enemiesCount = 0;
                foreach (Country<TKey> enemy in CountriesFleets.Keys)
                {
                    if (country != enemy && country.RelationWithCountries[enemy].Status == DiplomaticRelationStatus.War)
                        enemiesCount++;
                }
                float damageFromCountiFleet = CountriesFleets[country].Atack(); 
                
                if (enemiesCount > 0)
                {
                    foreach (Country<TKey> enemy in CountriesFleets.Keys)
                    {
                        if (country != enemy && country.RelationWithCountries[enemy].Status == DiplomaticRelationStatus.War)
                            damagePerCountry[enemy] += damageFromCountiFleet / enemiesCount;
                    }
                }
                else
                {
                    CountriesFleets.Remove(country);
                }
            }
            foreach(Country<TKey> country in CountriesFleets.Keys)
            {
                CountriesFleets[country].GetDamage(damagePerCountry[country]);
            }
        }
        
    }
}
