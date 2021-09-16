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

        internal TKey Id { get; private set; }
        internal ServicesFactory ServicesFactory { get; private set; }
        internal GameSesionSettings Settings { get; set; }
    }
}
