using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.ObjectModel
{
    public class DiplomaticRelation<TKey>
    {
        public TKey Id { get; set; }
        public int DayToGetAbilitiToDeclerWar { get; set; }
        public DiplomaticRelationStatus Status { get; private set; }
        public void DeclareWar()
        {
            if (Status != DiplomaticRelationStatus.War & DayToGetAbilitiToDeclerWar == 0)
                Status = DiplomaticRelationStatus.War;
        }
        public void DeclarePeace()
        {
            if (Status != DiplomaticRelationStatus.Peace)
                Status = DiplomaticRelationStatus.Peace;
        }

        public void Update()
        {
            if (DayToGetAbilitiToDeclerWar > 0)
                DayToGetAbilitiToDeclerWar--;
        }

    }
}
