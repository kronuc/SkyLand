using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.Entities
{
    public class Fleet<TKey>
    {
        public event EventHandler<Fleet<TKey>> FleetDestroyed;
        public TKey Id { get; set; }
        private int _amountOfShips;
        public int AmountOfShips { get => (int)(TotalHp % HPPerShip) + 1; set => _amountOfShips = value; }
        public int HPPerShip { get; set; }
        public float DemagePerShip { get; set; }
        public float TotalHp { get; set; }
        public Country<TKey> Country { get; private set; }

        public float Atack()
        {
            return AmountOfShips * DemagePerShip;
        }

        public void AddFleet(Fleet<TKey> fleet)
        {
            TotalHp += fleet.TotalHp;

        }

        public void GetDamage(float damage)
        {
            if (damage > TotalHp)
            {
                FleetDestroyed?.Invoke(this, this);
                TotalHp = 0;
            }
            else
            {
                TotalHp -= damage;
            }
        }
    }
}
