using SL.Model.ObjectModel.Entities;

namespace SL.Model.ObjectModel.Events
{
    public delegate void TaskFinishedEvent<TKey>(object sender, ProductionTask<TKey> task);
    
}