using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DungeonHunterBusinessLogic;

namespace UnitTests
{
    [TestFixture]
    class MapTest
    {
        [Test]
        public void MapCheckTileFree_ReturnsTrue_IfTileIsFree([Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int xPos, [Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int yPos)
        {
            Map map = Map.GetInstance();
        
            bool answ = map.CheckTileFree(xPos, yPos);

            Assert.IsTrue(answ);
        }

        [Test]
        public void MapCheckTileFree_ReturnsFlase_IfTileIsPopulated([Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int xPos, [Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int yPos)
        {
            Map map = Map.GetInstance();
            int value = 99;


            map.PopulateTile(xPos, yPos, value);

            bool answ = map.CheckTileFree(xPos, yPos);

            Assert.IsFalse(answ);
        }

        [Test]
        public void GetTileValue_ReturnsTheValueOfTheTile([Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int xPos, [Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int yPos)
        {
            Map map = Map.GetInstance();
            int value = 99;

            map.PopulateTile(xPos, yPos, value);
            Assert.AreEqual(99, map.GetTileValue(xPos, yPos));

        }

        [Test]
        public void PopulateTile_DoesNotOverwrite_IfTileIs([Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int xPos, [Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int yPos)
        {
            Map map = Map.GetInstance();
            int value = 99;

            map.PopulateTile(xPos, yPos, value);
            map.PopulateTile(2, 2, 2);
            Assert.AreNotEqual(2, map.GetTileValue(xPos, yPos));

        }
    }
}