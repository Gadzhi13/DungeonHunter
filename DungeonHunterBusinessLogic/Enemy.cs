using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHunterBusinessLogic
{
    public class Enemy : BaseUnit, IEnemy
    {

        public Enemy(int id)
        {
            this.hp = id / 2;
            this.atk = id / 7;
        }

        public int Hp { get => hp; set => hp = value; }
        public int Atk { get => atk; set => atk = value; }
    }
}
