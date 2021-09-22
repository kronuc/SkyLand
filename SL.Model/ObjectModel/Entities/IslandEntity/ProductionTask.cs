using SL.Model.ObjectModel.Events;

namespace SL.Model.ObjectModel.Entities
{
    public class ProductionTask<TKey>
    {
        public TKey Id { get; set; }
        public float NecessaryAmounOfProduction { get; private set; }
        public float CurretnAmountOfProduction { get; private set; }
        public event TaskFinishedEvent<TKey> TaskFinished;
        public Island<TKey> Owner { get; set; }
        public void PutProduction(float production)
        {
            CurretnAmountOfProduction += production;
            if (CurretnAmountOfProduction >= NecessaryAmounOfProduction)
                TaskFinished(this, this);
        }
    }
}