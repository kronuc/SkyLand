using SL.Model.ObjectModel;
using SL.Model.ObjectModel.Entities;
using SL.Model.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model
{
    internal class GameSession<TKey>
    {
        internal GameSession(TKey id, GameSesionSettings settings)
        {
            Id = id;
            Settings = settings;
        }

        public GameData<TKey> GameData { get; private set; }
        internal TKey Id { get; private set; }
        internal ServicesFactory ServicesFactory { get; private set; }
        internal GameSesionSettings Settings { get; set; }
    }
}
