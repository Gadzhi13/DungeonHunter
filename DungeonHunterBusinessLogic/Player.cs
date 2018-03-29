using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHunterBusinessLogic
{
    public class Player : BaseUnit, IPlayer
    {

        private static Player instance;

        public static Player GetInstance()
        {
            if (instance == null)
            {
                if (instance == null)
                {
                    instance = new Player();
                }
            }
            return instance;
        }

        Map map;
        private int xPos = 10;
        private int yPos = 10;
        private int xp;
        private int dex;
        private int str;
        private int fov;

        private Player()
        {
            this.map =  Map.GetInstance();
            this.xp = 0;
            this.str = 1;
            this.dex = 1;
            this.fov = 3;
            this.hp = 20 + this.str * 4;
            this.atk = 3 + this.str + this.dex;
        }

        public int[] GetCurrentPosition() {
            return new int[2] { xPos, yPos };
        }

        public void MoveUp()
        {
            if (map.CheckTileFree(this.xPos, this.yPos - 1)) {
                this.yPos = this.yPos - 1;
            }

        }

        public void MoveDown()
        {
            if (map.CheckTileFree(this.xPos, this.yPos + 1))
            {
                this.yPos = this.yPos + 1;
            }
        }

        public void MoveLeft()
        {
            if (map.CheckTileFree(this.xPos - 1, this.yPos))
            {
                this.xPos = this.xPos - 1;
            }
        }

        public void MoveRight()
        {
            if (map.CheckTileFree(this.xPos + 1, this.yPos))
            {
                this.xPos = this.xPos + 1;
            }
        }

        public int GetHealth()
        {
            return this.hp;
        }
    }
}
