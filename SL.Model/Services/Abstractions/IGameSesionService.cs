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
        TKey CreateGameSesion();
        List<TKey> GetListOfSessionAvailableForLoading();
        bool CanLoadGameSesion(TKey id);
        void LoadGameSession(TKey id);
        void SaveGameSession(TKey id);
        void DeleteSavedGameSesion(TKey id);
        ServicesFactory GetServicesForGameSession(TKey id);
    }
}
