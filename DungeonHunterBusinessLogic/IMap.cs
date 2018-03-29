using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHunterBusinessLogic
{
    public interface IMap
    {
        bool CheckTileFree(int xPos, int yPos);
    }
}
