using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHunterBusinessLogic
{
    public class EnemiesPool
    {

        private static EnemiesPool instance;
        private static List<Enemy> enemiesList = new List<Enemy>();

        private EnemiesPool() { }

        public static EnemiesPool GetInstance()
        {
            if (instance == null)
            {
                if (instance == null)
                {
                    instance = new EnemiesPool();
                }
            }
            return instance;
        }

        public static Enemy GetEnemy(int id)
        {
            if (enemiesList[id] != null)
            {
                return enemiesList[id];
            }
            return new Enemy(id);
        }
    }
}
