using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.Entities.AirBatleEntity.Event
{
    public delegate void AirBattleEndEvent<TKey>(object sender, AirBattleEndEvent<TKey> args);
}
