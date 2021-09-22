using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.Entities.IslandEntity.Event
{
    public class TaskFinishedEventArgs<TKey>
    {
        public Island<TKey> Island { get; set; }
        public ProductionTask<TKey> ProductionTask { get; set; }
    }
}
