using SL.Time.Services;
using SL.Time.Services.Abstracion;

namespace SL.Model.Services.Abstractions
{
    public sealed class ServicesFactory
    {
        GameSession<int> _gameSession;
        private ITimeService _timeService;

        internal ServicesFactory(GameSession<int> gameSession)
        {
            _gameSession = gameSession;
        }

        public ITimeService TimeService 
        {
            get
            {
                return _timeService ??= TimeServiceFactory.GetTimeService();
            }
            private set
            {
                _timeService = value;
            }
        }
    }
}