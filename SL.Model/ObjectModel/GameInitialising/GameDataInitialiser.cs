using SL.Model.ObjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel.GameInitialising
{
    public abstract class GameDataInitialiser<TKey>
    {
        private IEnumerable<AirStream<TKey>> _airStreams;
        public GameData<TKey> CreateGameData()
        {
            Island<TKey>[,] islands = GenerateMap();
            foreach (Island<TKey> island in islands)
            { 
            }    
            return new GameData<TKey>();
        }

        private Island<TKey>[,] GenerateMap()
        {
            Island<TKey>[,] map = new Island<TKey>[10,10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    map[i,j] =  new Island<TKey> { Location = new Point<TKey>() { X = i * 100 + 100, Y = j * 100 + 100 }};
            return map;
        }

        public abstract TKey GenerateIdForIsland();
    }
}
