using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHunterBusinessLogic
{
    public class Map : IMap
    {
        private static Map instance;

        public static Map GetInstance()
        {
            if (instance == null)
            {
                if (instance == null)
                {
                    instance = new Map();
                }
            }
            return instance;
        }
        
        int[][] mapData = new int[30][];

        private Map()
        {
            this.InitializeMap();
        }

        private void InitializeMap()
        {
            for (int i = 0; i < 30; i++)
            {
                mapData[i] = new int[30];
                for (int l = 0; l < 30; l++)
                {
                    mapData[i][l] = 0;
                }
            }
        }

        public void PopulateTile(int xPos, int yPos, int value)
        {
            if (this.CheckTileFree(xPos, yPos))
            {
                this.mapData[xPos][yPos] = value;
            }
        }

        public bool CheckTileFree(int xPos, int yPos)
        {
            if (this.mapData[xPos][yPos] == 0) {
                return true;
            }
            return false;
        }

        public int GetTileValue(int xPos, int yPos)
        {
            return this.mapData[xPos][yPos];
        }
    }
}
