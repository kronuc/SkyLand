using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.Services.Abstractions
{
    public interface IGameSesionService<TKey>
    {
        TKey CreateGameSesion(GameSesionSettings settings);
        List<TKey> GetListOfSessionAvailableForLoading();
        bool CanLoadSesion(TKey id);
        void LoadGameSession(TKey id);
        void SaveGameSession(TKey id);
    }
}
