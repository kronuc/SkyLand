using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel
{
    public class Fleet<TKey>
    {
        public event EventHandler<Fleet<TKey>> FleetDestroyed;
        public TKey Id { get; set; }
        public int AmountOfShips { get; set; }
        public int HPPerShip { get; set; }
        public int DemagePerShip { get; set; }
        public float TotalHp { get; set; }
        public Country<TKey> Country { get; private set; }

        public float Atack()
        {
            return 1.0f;
        }

        public void AddFleet(Fleet<TKey> fleet)
        { }

        public void GetDamage(float damage)
        {
            if (damage > TotalHp)
                FleetDestroyed?.Invoke(this, this);
            else
            {
                TotalHp -= damage;
                AmountOfShips = (int)(TotalHp % HPPerShip) + 1; s
            }
        }
    }
}
